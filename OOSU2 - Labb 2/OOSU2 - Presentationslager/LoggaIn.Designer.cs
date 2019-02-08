namespace OOSU2___Presentationslager
{
    partial class LoggaIn
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
            this.anvandareNamnTextBox = new System.Windows.Forms.TextBox();
            this.anvandareLosenordTextBox = new System.Windows.Forms.TextBox();
            this.anvandareNamnLabel = new System.Windows.Forms.Label();
            this.losenordLabel = new System.Windows.Forms.Label();
            this.loggaInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anvandareNamnTextBox
            // 
            this.anvandareNamnTextBox.Location = new System.Drawing.Point(184, 198);
            this.anvandareNamnTextBox.Name = "anvandareNamnTextBox";
            this.anvandareNamnTextBox.Size = new System.Drawing.Size(212, 22);
            this.anvandareNamnTextBox.TabIndex = 0;
            this.anvandareNamnTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anvandareNamnTextBox_KeyDown);
            // 
            // anvandareLosenordTextBox
            // 
            this.anvandareLosenordTextBox.Location = new System.Drawing.Point(184, 315);
            this.anvandareLosenordTextBox.Name = "anvandareLosenordTextBox";
            this.anvandareLosenordTextBox.Size = new System.Drawing.Size(212, 22);
            this.anvandareLosenordTextBox.TabIndex = 1;
            this.anvandareLosenordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anvandareLosenordTextBox_KeyDown);
            // 
            // anvandareNamnLabel
            // 
            this.anvandareNamnLabel.AutoSize = true;
            this.anvandareNamnLabel.Location = new System.Drawing.Point(228, 178);
            this.anvandareNamnLabel.Name = "anvandareNamnLabel";
            this.anvandareNamnLabel.Size = new System.Drawing.Size(120, 17);
            this.anvandareNamnLabel.TabIndex = 2;
            this.anvandareNamnLabel.Text = "Använadre namn:";
            // 
            // losenordLabel
            // 
            this.losenordLabel.AutoSize = true;
            this.losenordLabel.Location = new System.Drawing.Point(228, 295);
            this.losenordLabel.Name = "losenordLabel";
            this.losenordLabel.Size = new System.Drawing.Size(68, 17);
            this.losenordLabel.TabIndex = 3;
            this.losenordLabel.Text = "Lösenord";
            // 
            // loggaInButton
            // 
            this.loggaInButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loggaInButton.Location = new System.Drawing.Point(231, 354);
            this.loggaInButton.Name = "loggaInButton";
            this.loggaInButton.Size = new System.Drawing.Size(83, 34);
            this.loggaInButton.TabIndex = 6;
            this.loggaInButton.TabStop = false;
            this.loggaInButton.Text = "Logga in";
            this.loggaInButton.UseVisualStyleBackColor = true;
            this.loggaInButton.Click += new System.EventHandler(this.loggaInButton_Click);
            // 
            // LoggaIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 603);
            this.Controls.Add(this.loggaInButton);
            this.Controls.Add(this.losenordLabel);
            this.Controls.Add(this.anvandareNamnLabel);
            this.Controls.Add(this.anvandareLosenordTextBox);
            this.Controls.Add(this.anvandareNamnTextBox);
            this.Name = "LoggaIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox anvandareNamnTextBox;
        private System.Windows.Forms.TextBox anvandareLosenordTextBox;
        private System.Windows.Forms.Label anvandareNamnLabel;
        private System.Windows.Forms.Label losenordLabel;
        private System.Windows.Forms.Button loggaInButton;
    }
}

