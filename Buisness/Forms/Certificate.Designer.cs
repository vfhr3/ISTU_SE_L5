
namespace Buisness.Forms
{
    partial class Certificate
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.OptionRole = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.OptionRole);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 52);
            this.panel1.TabIndex = 0;
            // 
            // OptionRole
            // 
            this.OptionRole.Location = new System.Drawing.Point(578, 8);
            this.OptionRole.Name = "OptionRole";
            this.OptionRole.Size = new System.Drawing.Size(157, 39);
            this.OptionRole.TabIndex = 2;
            this.OptionRole.Text = "Одобрить";
            this.OptionRole.UseVisualStyleBackColor = true;
            this.OptionRole.Click += new System.EventHandler(this.OptionRole_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Просмотреть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(34, 21);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(91, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "CertificateNameId";
            // 
            // Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Certificate";
            this.Size = new System.Drawing.Size(747, 52);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label LabelName;
        public System.Windows.Forms.Button OptionRole;
    }
}
