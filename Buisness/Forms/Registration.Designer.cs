namespace Buisness.Forms
{
    partial class Registration
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.secretKeyField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(281, 141);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(238, 20);
            this.nameField.TabIndex = 0;
            this.nameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя пользователя (используется для входа)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(281, 183);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(238, 20);
            this.usernameField.TabIndex = 2;
            this.usernameField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(281, 225);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(238, 20);
            this.passwordField.TabIndex = 4;
            this.passwordField.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Секретный ключ (для администраторов)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // secretKeyField
            // 
            this.secretKeyField.Location = new System.Drawing.Point(281, 267);
            this.secretKeyField.Name = "secretKeyField";
            this.secretKeyField.Size = new System.Drawing.Size(238, 20);
            this.secretKeyField.TabIndex = 6;
            this.secretKeyField.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(329, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Регистрация";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Помощь";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secretKeyField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Name = "Registration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secretKeyField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}