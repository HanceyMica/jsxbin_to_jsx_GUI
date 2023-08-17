namespace jsxbin_to_jsx_GUI
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            MITLicense = new RichTextBox();
            closeButton = new Button();
            AboutMessage = new RichTextBox();
            SuspendLayout();
            // 
            // MITLicense
            // 
            MITLicense.AccessibleRole = AccessibleRole.None;
            MITLicense.BorderStyle = BorderStyle.None;
            MITLicense.Cursor = Cursors.No;
            MITLicense.Location = new Point(392, 12);
            MITLicense.Name = "MITLicense";
            MITLicense.ReadOnly = true;
            MITLicense.Size = new Size(396, 378);
            MITLicense.TabIndex = 0;
            MITLicense.Text = resources.GetString("MITLicense.Text");
            // 
            // closeButton
            // 
            closeButton.Location = new Point(679, 416);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 1;
            closeButton.Text = "关闭";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += button1_Click;
            // 
            // AboutMessage
            // 
            AboutMessage.BorderStyle = BorderStyle.None;
            AboutMessage.Location = new Point(12, 12);
            AboutMessage.MaximumSize = new Size(375, 300);
            AboutMessage.MinimumSize = new Size(375, 300);
            AboutMessage.Name = "AboutMessage";
            AboutMessage.ReadOnly = true;
            AboutMessage.Size = new Size(375, 300);
            AboutMessage.TabIndex = 2;
            AboutMessage.Text = "命令行版本：\nhttps://github.com/codecopy/jsxbin-to-jsx-converter\n本项目仓库：\nhttps://github.com/HanceyMica/jsxbin_to_jsx_GUI\n\n本项目基于命令行版本改造而来，\n功能并无任何修改，\n仅适用于jsxbin文件开头为“@JSXBIN@ES@2.0@”的文件。\n\n遵照MIT协议开源。";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 463);
            Controls.Add(AboutMessage);
            Controls.Add(closeButton);
            Controls.Add(MITLicense);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "AboutForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "关于";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox MITLicense;
        private Button closeButton;
        private RichTextBox AboutMessage;
    }
}