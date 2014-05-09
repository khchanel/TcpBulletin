namespace TcpBulletinClient
{
    partial class BulletinForm
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusLogBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(68, 24);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(204, 20);
            this.messageBox.TabIndex = 0;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 24);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Message";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(197, 87);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 92);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status";
            // 
            // statusLogBox
            // 
            this.statusLogBox.Location = new System.Drawing.Point(12, 116);
            this.statusLogBox.Multiline = true;
            this.statusLogBox.Name = "statusLogBox";
            this.statusLogBox.ReadOnly = true;
            this.statusLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusLogBox.Size = new System.Drawing.Size(260, 133);
            this.statusLogBox.TabIndex = 5;
            // 
            // BulletinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusLogBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.messageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BulletinForm";
            this.Text = "BulletinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox statusLogBox;
    }
}