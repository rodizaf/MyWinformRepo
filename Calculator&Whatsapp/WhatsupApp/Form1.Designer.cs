namespace WhatsupApp
{
    partial class myWinform
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
            this.user1TextBox = new System.Windows.Forms.TextBox();
            this.user2TextBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.user1NameLbl = new System.Windows.Forms.Label();
            this.user2NameLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.chatListBx = new System.Windows.Forms.ListBox();
            this.sendBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user1TextBox
            // 
            this.user1TextBox.Location = new System.Drawing.Point(150, 152);
            this.user1TextBox.Name = "user1TextBox";
            this.user1TextBox.Size = new System.Drawing.Size(287, 20);
            this.user1TextBox.TabIndex = 0;
            this.user1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user1TextBox_KeyDown);
            this.user1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user1TextBox_KeyPress);
            // 
            // user2TextBox
            // 
            this.user2TextBox.Location = new System.Drawing.Point(150, 251);
            this.user2TextBox.Name = "user2TextBox";
            this.user2TextBox.Size = new System.Drawing.Size(287, 20);
            this.user2TextBox.TabIndex = 1;
            this.user2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user2TextBox_KeyDown);
            this.user2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user2TextBox_KeyPress);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(467, 143);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(91, 36);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "&Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // user1NameLbl
            // 
            this.user1NameLbl.AutoSize = true;
            this.user1NameLbl.Location = new System.Drawing.Point(56, 159);
            this.user1NameLbl.Name = "user1NameLbl";
            this.user1NameLbl.Size = new System.Drawing.Size(20, 13);
            this.user1NameLbl.TabIndex = 3;
            this.user1NameLbl.Text = "Bill\r\n";
            // 
            // user2NameLbl
            // 
            this.user2NameLbl.AutoSize = true;
            this.user2NameLbl.Location = new System.Drawing.Point(56, 258);
            this.user2NameLbl.Name = "user2NameLbl";
            this.user2NameLbl.Size = new System.Drawing.Size(30, 13);
            this.user2NameLbl.TabIndex = 4;
            this.user2NameLbl.Text = "Sami";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.statusLbl.Location = new System.Drawing.Point(46, 80);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(116, 13);
            this.statusLbl.TabIndex = 5;
            this.statusLbl.Text = "Welcome to Whatsapp";
            // 
            // chatListBx
            // 
            this.chatListBx.FormattingEnabled = true;
            this.chatListBx.Location = new System.Drawing.Point(59, 325);
            this.chatListBx.Name = "chatListBx";
            this.chatListBx.Size = new System.Drawing.Size(426, 95);
            this.chatListBx.TabIndex = 6;
            // 
            // sendBtn2
            // 
            this.sendBtn2.Location = new System.Drawing.Point(467, 235);
            this.sendBtn2.Name = "sendBtn2";
            this.sendBtn2.Size = new System.Drawing.Size(91, 36);
            this.sendBtn2.TabIndex = 7;
            this.sendBtn2.Text = "S&end";
            this.sendBtn2.UseVisualStyleBackColor = true;
            this.sendBtn2.Click += new System.EventHandler(this.sendBtn2_Click);
            // 
            // myWinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 441);
            this.Controls.Add(this.sendBtn2);
            this.Controls.Add(this.chatListBx);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.user2NameLbl);
            this.Controls.Add(this.user1NameLbl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.user2TextBox);
            this.Controls.Add(this.user1TextBox);
            this.Name = "myWinform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsUp Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user1TextBox;
        private System.Windows.Forms.TextBox user2TextBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label user1NameLbl;
        private System.Windows.Forms.Label user2NameLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ListBox chatListBx;
        private System.Windows.Forms.Button sendBtn2;
    }
}

