namespace BankFormProject
{
    partial class Form_ACCESS
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
            this.Label_LOGIN = new System.Windows.Forms.Label();
            this.Label_PASSWORD = new System.Windows.Forms.Label();
            this.Button_ACCESS = new System.Windows.Forms.Button();
            this.TextBox_LOGIN = new System.Windows.Forms.TextBox();
            this.TextBox_PASSWORD = new System.Windows.Forms.TextBox();
            this.Label_ACCESS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_LOGIN
            // 
            this.Label_LOGIN.AutoSize = true;
            this.Label_LOGIN.Location = new System.Drawing.Point(165, 165);
            this.Label_LOGIN.Name = "Label_LOGIN";
            this.Label_LOGIN.Size = new System.Drawing.Size(41, 13);
            this.Label_LOGIN.TabIndex = 0;
            this.Label_LOGIN.Text = "Логин:";
            // 
            // Label_PASSWORD
            // 
            this.Label_PASSWORD.AutoSize = true;
            this.Label_PASSWORD.Location = new System.Drawing.Point(158, 191);
            this.Label_PASSWORD.Name = "Label_PASSWORD";
            this.Label_PASSWORD.Size = new System.Drawing.Size(48, 13);
            this.Label_PASSWORD.TabIndex = 1;
            this.Label_PASSWORD.Text = "Пароль:";
            // 
            // Button_ACCESS
            // 
            this.Button_ACCESS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ACCESS.Location = new System.Drawing.Point(161, 210);
            this.Button_ACCESS.Name = "Button_ACCESS";
            this.Button_ACCESS.Size = new System.Drawing.Size(151, 23);
            this.Button_ACCESS.TabIndex = 2;
            this.Button_ACCESS.Text = "Вход";
            this.Button_ACCESS.UseVisualStyleBackColor = true;
            this.Button_ACCESS.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_LOGIN
            // 
            this.TextBox_LOGIN.Location = new System.Drawing.Point(212, 158);
            this.TextBox_LOGIN.Name = "TextBox_LOGIN";
            this.TextBox_LOGIN.Size = new System.Drawing.Size(100, 20);
            this.TextBox_LOGIN.TabIndex = 3;
            // 
            // TextBox_PASSWORD
            // 
            this.TextBox_PASSWORD.Location = new System.Drawing.Point(212, 184);
            this.TextBox_PASSWORD.Name = "TextBox_PASSWORD";
            this.TextBox_PASSWORD.PasswordChar = '*';
            this.TextBox_PASSWORD.Size = new System.Drawing.Size(100, 20);
            this.TextBox_PASSWORD.TabIndex = 4;
            // 
            // Label_ACCESS
            // 
            this.Label_ACCESS.AutoSize = true;
            this.Label_ACCESS.BackColor = System.Drawing.SystemColors.Control;
            this.Label_ACCESS.ForeColor = System.Drawing.Color.Green;
            this.Label_ACCESS.Location = new System.Drawing.Point(158, 236);
            this.Label_ACCESS.Name = "Label_ACCESS";
            this.Label_ACCESS.Size = new System.Drawing.Size(129, 13);
            this.Label_ACCESS.TabIndex = 5;
            this.Label_ACCESS.Text = "Введите логин и пароль";
            // 
            // Form_ACCESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.Label_ACCESS);
            this.Controls.Add(this.TextBox_PASSWORD);
            this.Controls.Add(this.TextBox_LOGIN);
            this.Controls.Add(this.Button_ACCESS);
            this.Controls.Add(this.Label_PASSWORD);
            this.Controls.Add(this.Label_LOGIN);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form_ACCESS";
            this.Text = "AdminBankApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Label_LOGIN;
        private System.Windows.Forms.Label Label_PASSWORD;
        private System.Windows.Forms.Button Button_ACCESS;
        private System.Windows.Forms.TextBox TextBox_LOGIN;
        private System.Windows.Forms.TextBox TextBox_PASSWORD;
        private System.Windows.Forms.Label Label_ACCESS;
    }
}