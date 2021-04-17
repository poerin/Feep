using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Feep.Configure
{
    public partial class Configure : Form
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [Flags]
        public enum HChangeNotifyFlags
        {
            SHCNF_DWORD = 0x0003,
            SHCNF_IDLIST = 0x0000,
            SHCNF_PATHA = 0x0001,
            SHCNF_PATHW = 0x0005,
            SHCNF_PRINTERA = 0x0002,
            SHCNF_PRINTERW = 0x0006,
            SHCNF_FLUSH = 0x1000,
            SHCNF_FLUSHNOWAIT = 0x2000
        }

        [Flags]
        enum HChangeNotifyEventID
        {
            SHCNE_ALLEVENTS = 0x7FFFFFFF,
            SHCNE_ASSOCCHANGED = 0x08000000,
            SHCNE_ATTRIBUTES = 0x00000800,
            SHCNE_CREATE = 0x00000002,
            SHCNE_DELETE = 0x00000004,
            SHCNE_DRIVEADD = 0x00000100,
            SHCNE_DRIVEADDGUI = 0x00010000,
            SHCNE_DRIVEREMOVED = 0x00000080,
            SHCNE_EXTENDED_EVENT = 0x04000000,
            SHCNE_FREESPACE = 0x00040000,
            SHCNE_MEDIAINSERTED = 0x00000020,
            SHCNE_MEDIAREMOVED = 0x00000040,
            SHCNE_MKDIR = 0x00000008,
            SHCNE_NETSHARE = 0x00000200,
            SHCNE_NETUNSHARE = 0x00000400,
            SHCNE_RENAMEFOLDER = 0x00020000,
            SHCNE_RENAMEITEM = 0x00000001,
            SHCNE_RMDIR = 0x00000010,
            SHCNE_SERVERDISCONNECT = 0x00004000,
            SHCNE_UPDATEDIR = 0x00001000,
            SHCNE_UPDATEIMAGE = 0x00008000,
        }

        [DllImport("shell32.dll")]
        static extern void SHChangeNotify(HChangeNotifyEventID wEventId, HChangeNotifyFlags uFlags, IntPtr dwItem1, IntPtr dwItem2);

        public static void RegisterFileType(string ExtendName, string Description, string IcoPath, string ExePath, bool Wish)
        {
            string relationName = "Feep." + ExtendName.Substring(1, ExtendName.Length - 1).ToUpper();

            try
            {
                Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Microsoft", true).OpenSubKey("Windows", true).OpenSubKey("CurrentVersion", true).OpenSubKey("Explorer", true).OpenSubKey("FileExts", true).DeleteSubKeyTree(ExtendName);
                Registry.ClassesRoot.DeleteSubKeyTree(ExtendName);
                Registry.ClassesRoot.DeleteSubKeyTree(relationName);
            }
            catch (Exception)
            {
                try
                {
                    Registry.ClassesRoot.DeleteSubKeyTree(ExtendName);
                    Registry.ClassesRoot.DeleteSubKeyTree(relationName);
                }
                catch
                {
                    try
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree(relationName);
                    }
                    catch
                    { }
                }
            }

            if (Wish)
            {
                RegistryKey fileTypeKey = Registry.ClassesRoot.CreateSubKey(ExtendName);
                fileTypeKey.SetValue("", relationName);
                fileTypeKey.Close();

                RegistryKey relationKey = Registry.ClassesRoot.CreateSubKey(relationName);
                relationKey.SetValue("", Description);

                RegistryKey iconKey = relationKey.CreateSubKey("DefaultIcon");
                iconKey.SetValue("", IcoPath);

                RegistryKey shellKey = relationKey.CreateSubKey("Shell");
                RegistryKey openKey = shellKey.CreateSubKey("Open");
                RegistryKey commandKey = openKey.CreateSubKey("Command");
                commandKey.SetValue("", "\"" + ExePath + "\"" + " \"%1\"");

                relationKey.Close();
            }
            SHChangeNotify(HChangeNotifyEventID.SHCNE_ASSOCCHANGED, HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
        }

        int PointX, PointY, SizeWidth, SizeHeight;
        string screen = "", backColor = "";
        int startState = 0;
        bool showInTaskbar = false;

        public Configure()
        {
            InitializeComponent();

            StringBuilder ReturnedString = new StringBuilder(255);

            GetPrivateProfileString("Location", "X", Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.1).ToString(), ReturnedString, 255, Application.StartupPath + @"\configure.ini");
            Int32.TryParse(ReturnedString.ToString(), out PointX);
            GetPrivateProfileString("Location", "Y", Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.1).ToString(), ReturnedString, 255, Application.StartupPath + @"\configure.ini");
            Int32.TryParse(ReturnedString.ToString(), out PointY);
            GetPrivateProfileString("Size", "Width", Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.8).ToString(), ReturnedString, 255, Application.StartupPath + @"\configure.ini");
            Int32.TryParse(ReturnedString.ToString(), out SizeWidth);
            GetPrivateProfileString("Size", "Height", Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.8).ToString(), ReturnedString, 255, Application.StartupPath + @"\configure.ini");
            Int32.TryParse(ReturnedString.ToString(), out SizeHeight);
            GetPrivateProfileString("Form", "Screen", "None", ReturnedString, 255, Application.StartupPath + @"\configure.ini");
            screen = ReturnedString.ToString();
            GetPrivateProfileString("Form", "BackColor", "#000000", ReturnedString, 255, Application.StartupPath + @"\configure.ini");
            backColor = ReturnedString.ToString();
            GetPrivateProfileString("Form", "StartState", "0", ReturnedString, 255, Application.StartupPath + @"\configure.ini");
            Int32.TryParse(ReturnedString.ToString(), out startState);
            GetPrivateProfileString("Form", "ShowInTaskbar", "False", ReturnedString, 255, Application.StartupPath + @"\configure.ini");
            Boolean.TryParse(ReturnedString.ToString(), out showInTaskbar);

            numWidth.Value = SizeWidth;
            numHeight.Value = SizeHeight;

            try
            {
                pnlColor.BackColor = ColorTranslator.FromHtml(backColor);
                txtColor.Text = backColor.Substring(1);
            }
            catch
            {
                pnlColor.BackColor = Color.Black;
            }

            cmbFormStartState.SelectedIndex = startState;
            chkShowInTaskbar.Checked = showInTaskbar;

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            if (txtColor.Text.Length == 6)
            {
                try
                {
                    pnlColor.BackColor = ColorTranslator.FromHtml("#" + txtColor.Text);
                }
                catch (Exception)
                {
                }
            }
        }

        private void txtColor_MouseClick(object sender, MouseEventArgs e)
        {
            txtColor.SelectAll();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            switch (cmbFormStartState.SelectedIndex)
            {
                case 1:
                    {
                        PointX = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.1);
                        PointY = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.1);
                        SizeWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.8);
                        SizeHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.8);
                    }
                    break;
                case 2:
                    {
                        SizeWidth = (int)numWidth.Value;
                        SizeHeight = (int)numHeight.Value;
                        PointX = 0;
                        PointY = 0;
                    }
                    break;
            }

            WritePrivateProfileString("Location", "X", PointX.ToString(), Application.StartupPath + @"\configure.ini");
            WritePrivateProfileString("Location", "Y", PointY.ToString(), Application.StartupPath + @"\configure.ini");
            WritePrivateProfileString("Size", "Width", SizeWidth.ToString(), Application.StartupPath + @"\configure.ini");
            WritePrivateProfileString("Size", "Height", SizeHeight.ToString(), Application.StartupPath + @"\configure.ini");
            WritePrivateProfileString("Form", "Screen", "None", Application.StartupPath + @"\configure.ini");
            WritePrivateProfileString("Form", "BackColor", ColorTranslator.ToHtml(pnlColor.BackColor), Application.StartupPath + @"\configure.ini");
            WritePrivateProfileString("Form", "StartState", cmbFormStartState.SelectedIndex.ToString(), Application.StartupPath + @"\configure.ini");
            WritePrivateProfileString("Form", "ShowInTaskbar", chkShowInTaskbar.Checked.ToString(), Application.StartupPath + @"\configure.ini");

            RegisterFileType(".jpg", "Feep JPG File", Application.StartupPath + @"\Icon\JPG.ico", Application.StartupPath + @"\Feep.exe", cbJPG.Checked);
            RegisterFileType(".bmp", "Feep BMP File", Application.StartupPath + @"\Icon\BMP.ico", Application.StartupPath + @"\Feep.exe", cbBMP.Checked);
            RegisterFileType(".png", "Feep PNG File", Application.StartupPath + @"\Icon\PNG.ico", Application.StartupPath + @"\Feep.exe", cbPNG.Checked);
            RegisterFileType(".gif", "Feep GIF File", Application.StartupPath + @"\Icon\GIF.ico", Application.StartupPath + @"\Feep.exe", cbGIF.Checked);
            RegisterFileType(".tif", "Feep TIF File", Application.StartupPath + @"\Icon\TIF.ico", Application.StartupPath + @"\Feep.exe", cbTIF.Checked);

            MessageBox.Show("设置成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbFormStartState_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFormStartState.SelectedIndex)
            {
                case 0:
                case 1:
                    {
                        numWidth.Visible = false;
                        numHeight.Visible = false;
                        lblMultiply.Visible = false;
                    }
                    break;
                case 2:
                    {
                        numWidth.Visible = true;
                        numHeight.Visible = true;
                        lblMultiply.Visible = true;
                    }
                    break;
            }
        }
    }
}
