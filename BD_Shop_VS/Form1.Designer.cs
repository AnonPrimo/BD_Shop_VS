namespace BD_Shop_VS
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
            this.button_Ok = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Pass = new System.Windows.Forms.Label();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.comboBox_Login = new System.Windows.Forms.ComboBox();
            this.button_Prihod = new System.Windows.Forms.Button();
            this.button_Rashod = new System.Windows.Forms.Button();
            this.button_Correct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(45, 94);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(13, 29);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(33, 13);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "Login";
            // 
            // label_Pass
            // 
            this.label_Pass.AutoSize = true;
            this.label_Pass.Location = new System.Drawing.Point(13, 58);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(53, 13);
            this.label_Pass.TabIndex = 3;
            this.label_Pass.Text = "Password";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(86, 55);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.PasswordChar = '*';
            this.textBox_Pass.Size = new System.Drawing.Size(121, 20);
            this.textBox_Pass.TabIndex = 4;
            // 
            // comboBox_Login
            // 
            this.comboBox_Login.FormattingEnabled = true;
            this.comboBox_Login.Location = new System.Drawing.Point(86, 29);
            this.comboBox_Login.Name = "comboBox_Login";
            this.comboBox_Login.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Login.TabIndex = 5;
            // 
            // button_Prihod
            // 
            this.button_Prihod.Location = new System.Drawing.Point(45, 132);
            this.button_Prihod.Name = "button_Prihod";
            this.button_Prihod.Size = new System.Drawing.Size(75, 23);
            this.button_Prihod.TabIndex = 6;
            this.button_Prihod.Text = "Prihod";
            this.button_Prihod.UseVisualStyleBackColor = true;
            this.button_Prihod.Click += new System.EventHandler(this.button_Prihod_Click);
            // 
            // button_Rashod
            // 
            this.button_Rashod.Location = new System.Drawing.Point(45, 161);
            this.button_Rashod.Name = "button_Rashod";
            this.button_Rashod.Size = new System.Drawing.Size(75, 23);
            this.button_Rashod.TabIndex = 7;
            this.button_Rashod.Text = "Rashod";
            this.button_Rashod.UseVisualStyleBackColor = true;
            // 
            // button_Correct
            // 
            this.button_Correct.Location = new System.Drawing.Point(45, 190);
            this.button_Correct.Name = "button_Correct";
            this.button_Correct.Size = new System.Drawing.Size(75, 23);
            this.button_Correct.TabIndex = 8;
            this.button_Correct.Text = "Correct";
            this.button_Correct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 225);
            this.Controls.Add(this.button_Correct);
            this.Controls.Add(this.button_Rashod);
            this.Controls.Add(this.button_Prihod);
            this.Controls.Add(this.comboBox_Login);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.label_Pass);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.button_Ok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Pass;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.ComboBox comboBox_Login;
        private System.Windows.Forms.Button button_Prihod;
        private System.Windows.Forms.Button button_Rashod;
        private System.Windows.Forms.Button button_Correct;
    }
}

