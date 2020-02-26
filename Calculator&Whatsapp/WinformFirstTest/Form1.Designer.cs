namespace WinformFirstTest
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.multipleBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(87, 106);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(438, 20);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Text = "0";
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(87, 249);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(438, 20);
            this.secondNumberTextBox.TabIndex = 1;
            this.secondNumberTextBox.Text = "0";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Gisha", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(264, 307);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(31, 38);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "?";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(103, 177);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(75, 23);
            this.PlusBtn.TabIndex = 3;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // multipleBtn
            // 
            this.multipleBtn.Location = new System.Drawing.Point(216, 177);
            this.multipleBtn.Name = "multipleBtn";
            this.multipleBtn.Size = new System.Drawing.Size(75, 23);
            this.multipleBtn.TabIndex = 4;
            this.multipleBtn.Text = "*";
            this.multipleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.multipleBtn.UseVisualStyleBackColor = true;
            this.multipleBtn.Click += new System.EventHandler(this.multipleBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(331, 177);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(75, 23);
            this.minusBtn.TabIndex = 5;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Location = new System.Drawing.Point(436, 177);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(75, 23);
            this.divideBtn.TabIndex = 6;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 376);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.multipleBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button multipleBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button divideBtn;
    }
}

