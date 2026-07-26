namespace KafkaChatApp
{
    partial class Form1
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

        private void InitializeComponent()
        {
            txtMessages = new RichTextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtMessages
            // 
            txtMessages.Location = new Point(20, 20);
            txtMessages.Name = "txtMessages";
            txtMessages.ReadOnly = true;
            txtMessages.Size = new Size(500, 250);
            txtMessages.TabIndex = 0;
            txtMessages.Text = "";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(20, 290);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(400, 27);
            txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(435, 288);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(85, 30);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 340);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtMessages);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kafka Chat Application";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtMessages;
        private TextBox txtMessage;
        private Button btnSend;
    }
}