namespace jsxbin_to_jsx_GUI
{
    partial class FailAlert
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
            closeButton = new Button();
            alertTextLabel = new Label();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(463, 122);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(117, 29);
            closeButton.TabIndex = 0;
            closeButton.Text = "好捏，知道了";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // alertTextLabel
            // 
            alertTextLabel.AutoSize = true;
            alertTextLabel.Location = new Point(45, 37);
            alertTextLabel.Name = "alertTextLabel";
            alertTextLabel.Size = new Size(84, 20);
            alertTextLabel.TabIndex = 1;
            alertTextLabel.Text = "转换失败！";
            // 
            // FailAlert
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 163);
            Controls.Add(alertTextLabel);
            Controls.Add(closeButton);
            Name = "FailAlert";
            Text = "通知";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Label alertTextLabel;
    }
}