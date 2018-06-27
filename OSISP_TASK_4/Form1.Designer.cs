namespace OSISP_TASK_4
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
            this.randomNumbersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomNumbersLabel
            // 
            this.randomNumbersLabel.AutoSize = true;
            this.randomNumbersLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.randomNumbersLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomNumbersLabel.Location = new System.Drawing.Point(54, 24);
            this.randomNumbersLabel.Name = "randomNumbersLabel";
            this.randomNumbersLabel.Size = new System.Drawing.Size(2, 30);
            this.randomNumbersLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 100);
            this.Controls.Add(this.randomNumbersLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomNumbersLabel;
    }
}

