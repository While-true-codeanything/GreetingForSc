namespace Miles_kilometers
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Info1 = new System.Windows.Forms.Label();
            this.Mil = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Info2 = new System.Windows.Forms.Label();
            this.Kilo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info1.Location = new System.Drawing.Point(76, 73);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(59, 24);
            this.Info1.TabIndex = 0;
            this.Info1.Text = "Miles:";
            // 
            // Mil
            // 
            this.Mil.Location = new System.Drawing.Point(287, 78);
            this.Mil.Name = "Mil";
            this.Mil.Size = new System.Drawing.Size(116, 22);
            this.Mil.TabIndex = 1;
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Convert.Location = new System.Drawing.Point(140, 126);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(178, 65);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Сonvert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info2.Location = new System.Drawing.Point(30, 249);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(215, 48);
            this.Info2.TabIndex = 3;
            this.Info2.Text = "Equals the number \r\nof kilometers:";
            this.Info2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Kilo
            // 
            this.Kilo.Location = new System.Drawing.Point(287, 267);
            this.Kilo.Name = "Kilo";
            this.Kilo.ReadOnly = true;
            this.Kilo.Size = new System.Drawing.Size(152, 22);
            this.Kilo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 332);
            this.Controls.Add(this.Kilo);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Mil);
            this.Controls.Add(this.Info1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miles-kilometers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.TextBox Mil;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.TextBox Kilo;
    }
}

