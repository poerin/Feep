namespace Feep.Configure
{
    partial class Configure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configure));
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.cbTIF = new System.Windows.Forms.CheckBox();
            this.cbGIF = new System.Windows.Forms.CheckBox();
            this.cbPNG = new System.Windows.Forms.CheckBox();
            this.cbBMP = new System.Windows.Forms.CheckBox();
            this.cbJPG = new System.Windows.Forms.CheckBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.gbBackColor = new System.Windows.Forms.GroupBox();
            this.cmbFormStartState = new System.Windows.Forms.ComboBox();
            this.lblFormStartState = new System.Windows.Forms.Label();
            this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.gbFiles.SuspendLayout();
            this.gbBackColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.cbTIF);
            this.gbFiles.Controls.Add(this.cbGIF);
            this.gbFiles.Controls.Add(this.cbPNG);
            this.gbFiles.Controls.Add(this.cbBMP);
            this.gbFiles.Controls.Add(this.cbJPG);
            this.gbFiles.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbFiles.Location = new System.Drawing.Point(12, 12);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(402, 65);
            this.gbFiles.TabIndex = 0;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "关联文件";
            // 
            // cbTIF
            // 
            this.cbTIF.AutoSize = true;
            this.cbTIF.Checked = true;
            this.cbTIF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTIF.Location = new System.Drawing.Point(344, 30);
            this.cbTIF.Name = "cbTIF";
            this.cbTIF.Size = new System.Drawing.Size(47, 24);
            this.cbTIF.TabIndex = 4;
            this.cbTIF.Text = "TIF";
            this.cbTIF.UseVisualStyleBackColor = true;
            // 
            // cbGIF
            // 
            this.cbGIF.AutoSize = true;
            this.cbGIF.Checked = true;
            this.cbGIF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGIF.Location = new System.Drawing.Point(269, 30);
            this.cbGIF.Name = "cbGIF";
            this.cbGIF.Size = new System.Drawing.Size(49, 24);
            this.cbGIF.TabIndex = 3;
            this.cbGIF.Text = "GIF";
            this.cbGIF.UseVisualStyleBackColor = true;
            // 
            // cbPNG
            // 
            this.cbPNG.AutoSize = true;
            this.cbPNG.Checked = true;
            this.cbPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPNG.Location = new System.Drawing.Point(185, 30);
            this.cbPNG.Name = "cbPNG";
            this.cbPNG.Size = new System.Drawing.Size(58, 24);
            this.cbPNG.TabIndex = 2;
            this.cbPNG.Text = "PNG";
            this.cbPNG.UseVisualStyleBackColor = true;
            // 
            // cbBMP
            // 
            this.cbBMP.AutoSize = true;
            this.cbBMP.Checked = true;
            this.cbBMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBMP.Location = new System.Drawing.Point(99, 30);
            this.cbBMP.Name = "cbBMP";
            this.cbBMP.Size = new System.Drawing.Size(60, 24);
            this.cbBMP.TabIndex = 1;
            this.cbBMP.Text = "BMP";
            this.cbBMP.UseVisualStyleBackColor = true;
            // 
            // cbJPG
            // 
            this.cbJPG.AutoSize = true;
            this.cbJPG.Checked = true;
            this.cbJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJPG.Location = new System.Drawing.Point(20, 30);
            this.cbJPG.Name = "cbJPG";
            this.cbJPG.Size = new System.Drawing.Size(53, 24);
            this.cbJPG.TabIndex = 0;
            this.cbJPG.Text = "JPG";
            this.cbJPG.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Location = new System.Drawing.Point(354, 193);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(60, 28);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // gbBackColor
            // 
            this.gbBackColor.Controls.Add(this.numHeight);
            this.gbBackColor.Controls.Add(this.numWidth);
            this.gbBackColor.Controls.Add(this.cmbFormStartState);
            this.gbBackColor.Controls.Add(this.lblFormStartState);
            this.gbBackColor.Controls.Add(this.chkShowInTaskbar);
            this.gbBackColor.Controls.Add(this.txtColor);
            this.gbBackColor.Controls.Add(this.lblColor);
            this.gbBackColor.Controls.Add(this.pnlColor);
            this.gbBackColor.Controls.Add(this.lblMultiply);
            this.gbBackColor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbBackColor.Location = new System.Drawing.Point(12, 83);
            this.gbBackColor.Name = "gbBackColor";
            this.gbBackColor.Size = new System.Drawing.Size(402, 104);
            this.gbBackColor.TabIndex = 1;
            this.gbBackColor.TabStop = false;
            this.gbBackColor.Text = "窗体设置";
            // 
            // cmbFormStartState
            // 
            this.cmbFormStartState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormStartState.FormattingEnabled = true;
            this.cmbFormStartState.Items.AddRange(new object[] {
            "默认",
            "全屏",
            "自定"});
            this.cmbFormStartState.Location = new System.Drawing.Point(89, 66);
            this.cmbFormStartState.Name = "cmbFormStartState";
            this.cmbFormStartState.Size = new System.Drawing.Size(90, 28);
            this.cmbFormStartState.TabIndex = 6;
            this.cmbFormStartState.SelectedIndexChanged += new System.EventHandler(this.cmbFormStartState_SelectedIndexChanged);
            // 
            // lblFormStartState
            // 
            this.lblFormStartState.AutoSize = true;
            this.lblFormStartState.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lblFormStartState.Location = new System.Drawing.Point(16, 70);
            this.lblFormStartState.Name = "lblFormStartState";
            this.lblFormStartState.Size = new System.Drawing.Size(79, 20);
            this.lblFormStartState.TabIndex = 5;
            this.lblFormStartState.Text = "启动状态：";
            // 
            // chkShowInTaskbar
            // 
            this.chkShowInTaskbar.AutoSize = true;
            this.chkShowInTaskbar.Location = new System.Drawing.Point(225, 29);
            this.chkShowInTaskbar.Name = "chkShowInTaskbar";
            this.chkShowInTaskbar.Size = new System.Drawing.Size(154, 24);
            this.chkShowInTaskbar.TabIndex = 4;
            this.chkShowInTaskbar.Text = "在任务栏中显示图标";
            this.chkShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(89, 28);
            this.txtColor.MaxLength = 6;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(65, 26);
            this.txtColor.TabIndex = 2;
            this.txtColor.Text = "444444";
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtColor_MouseClick);
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lblColor.Location = new System.Drawing.Point(14, 31);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(74, 20);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "背景色：#";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(159, 31);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(20, 20);
            this.pnlColor.TabIndex = 0;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(198, 67);
            this.numWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(60, 26);
            this.numWidth.TabIndex = 7;
            this.numWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numWidth.Visible = false;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(279, 67);
            this.numHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(60, 26);
            this.numHeight.TabIndex = 8;
            this.numHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numHeight.Visible = false;
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.Location = new System.Drawing.Point(259, 70);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(19, 20);
            this.lblMultiply.TabIndex = 9;
            this.lblMultiply.Text = "×";
            this.lblMultiply.Visible = false;
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(426, 233);
            this.Controls.Add(this.gbBackColor);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.gbFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configure";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feep 配置辅助程序";
            this.gbFiles.ResumeLayout(false);
            this.gbFiles.PerformLayout();
            this.gbBackColor.ResumeLayout(false);
            this.gbBackColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.CheckBox cbTIF;
        private System.Windows.Forms.CheckBox cbGIF;
        private System.Windows.Forms.CheckBox cbPNG;
        private System.Windows.Forms.CheckBox cbBMP;
        private System.Windows.Forms.CheckBox cbJPG;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.GroupBox gbBackColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.ComboBox cmbFormStartState;
        private System.Windows.Forms.Label lblFormStartState;
        private System.Windows.Forms.CheckBox chkShowInTaskbar;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblMultiply;
    }
}