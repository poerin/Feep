namespace Feep
{
    partial class Viewer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Picture.BackColor = System.Drawing.Color.Black;
            this.Picture.ErrorImage = null;
            this.Picture.InitialImage = null;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(256, 256);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // Viewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(256, 256);
            this.ControlBox = false;
            this.Controls.Add(this.Picture);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Viewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Viewer_Load);
            this.SizeChanged += new System.EventHandler(this.Viewer_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Viewer_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.PictureBox Picture;

    }
}