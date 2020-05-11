namespace Greeting
{
    partial class Greeting
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
            this.Output = new System.Windows.Forms.TextBox();
            this.Action = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(95, 290);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(164, 20);
            this.Output.TabIndex = 0;
            // 
            // Action
            // 
            this.Action.Location = new System.Drawing.Point(129, 192);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(99, 40);
            this.Action.TabIndex = 1;
            this.Action.Text = "Greet";
            this.Action.UseVisualStyleBackColor = true;
            this.Action.Click += new System.EventHandler(this.Action_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(43, 72);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(106, 40);
            this.Info.TabIndex = 2;
            this.Info.Text = "Name\r\n(Additional)";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name2
            // 
            this.Name2.Location = new System.Drawing.Point(202, 84);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(114, 20);
            this.Name2.TabIndex = 3;
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 359);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Output);
            this.Name = "Greeting";
            this.Text = "Greeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Action;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.TextBox Name2;
    }
}

