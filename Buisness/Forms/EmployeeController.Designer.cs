namespace Buisness.Forms
{
    partial class EmployeeController
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CertificatesList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Помощь";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EmployeeName.Location = new System.Drawing.Point(595, 7);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(181, 24);
            this.EmployeeName.TabIndex = 16;
            this.EmployeeName.Text = "Ф.И.О. Сотрудника";
            this.EmployeeName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Удостоверения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CertificatesList
            // 
            this.CertificatesList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CertificatesList.Location = new System.Drawing.Point(29, 68);
            this.CertificatesList.Name = "CertificatesList";
            this.CertificatesList.Size = new System.Drawing.Size(747, 337);
            this.CertificatesList.TabIndex = 14;
            // 
            // EmployeeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CertificatesList);
            this.Name = "EmployeeController";
            this.Text = "EmployeeController";
            this.Load += new System.EventHandler(this.EmployeeController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel CertificatesList;
        public System.Windows.Forms.Label EmployeeName;
    }
}