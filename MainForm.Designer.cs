namespace jsxbin_to_jsx_GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            inputButton = new Button();
            outputButton = new Button();
            textInput = new TextBox();
            textOutput = new TextBox();
            outputLabel = new Label();
            inputLabel = new Label();
            converButton = new Button();
            aboutButton = new Button();
            textFileName = new TextBox();
            outputFileLabel = new Label();
            CloseButton = new Button();
            formatName = new Label();
            SuspendLayout();
            // 
            // inputButton
            // 
            inputButton.Location = new Point(652, 29);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(94, 29);
            inputButton.TabIndex = 0;
            inputButton.Text = "选择文件";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // outputButton
            // 
            outputButton.Location = new Point(652, 91);
            outputButton.Name = "outputButton";
            outputButton.Size = new Size(94, 29);
            outputButton.TabIndex = 1;
            outputButton.Text = "选择文件夹";
            outputButton.UseVisualStyleBackColor = true;
            outputButton.Click += outputButton_Click;
            // 
            // textInput
            // 
            textInput.Location = new Point(121, 29);
            textInput.Name = "textInput";
            textInput.Size = new Size(525, 27);
            textInput.TabIndex = 2;
            // 
            // textOutput
            // 
            textOutput.Location = new Point(121, 91);
            textOutput.Name = "textOutput";
            textOutput.Size = new Size(525, 27);
            textOutput.TabIndex = 3;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(34, 95);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(69, 20);
            outputLabel.TabIndex = 4;
            outputLabel.Text = "输出文件";
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(34, 36);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(69, 20);
            inputLabel.TabIndex = 5;
            inputLabel.Text = "输入文件";
            // 
            // converButton
            // 
            converButton.Location = new Point(652, 149);
            converButton.Name = "converButton";
            converButton.Size = new Size(94, 29);
            converButton.TabIndex = 6;
            converButton.Text = "转换";
            converButton.UseVisualStyleBackColor = true;
            converButton.Click += converButton_Click;
            // 
            // aboutButton
            // 
            aboutButton.Location = new Point(34, 211);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(94, 29);
            aboutButton.TabIndex = 7;
            aboutButton.Text = "关于";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click;
            // 
            // textFileName
            // 
            textFileName.Location = new Point(121, 149);
            textFileName.Name = "textFileName";
            textFileName.Size = new Size(497, 27);
            textFileName.TabIndex = 8;
            // 
            // outputFileLabel
            // 
            outputFileLabel.AutoSize = true;
            outputFileLabel.Location = new Point(38, 153);
            outputFileLabel.Name = "outputFileLabel";
            outputFileLabel.Size = new Size(54, 20);
            outputFileLabel.TabIndex = 9;
            outputFileLabel.Text = "文件名";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(652, 211);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 10;
            CloseButton.Text = "关闭";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // formatName
            // 
            formatName.AutoSize = true;
            formatName.Location = new Point(615, 156);
            formatName.Name = "formatName";
            formatName.Size = new Size(31, 20);
            formatName.TabIndex = 11;
            formatName.Text = ".jsx";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(792, 263);
            Controls.Add(formatName);
            Controls.Add(CloseButton);
            Controls.Add(outputFileLabel);
            Controls.Add(textFileName);
            Controls.Add(aboutButton);
            Controls.Add(converButton);
            Controls.Add(inputLabel);
            Controls.Add(outputLabel);
            Controls.Add(textOutput);
            Controls.Add(textInput);
            Controls.Add(inputButton);
            Controls.Add(outputButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 300);
            MinimumSize = new Size(800, 300);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jsxbin_to_Jsx_GUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inputButton;
        private Button outputButton;
        private TextBox textInput;
        private TextBox textOutput;
        private Label outputLabel;
        private Label inputLabel;
        private Button converButton;
        private Button aboutButton;
        private TextBox textFileName;
        private Label outputFileLabel;
        private Button CloseButton;
        private Label formatName;
    }
}