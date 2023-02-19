namespace Lab6_2
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
            this.textBox_originalText = new System.Windows.Forms.TextBox();
            this.textBox_resultText = new System.Windows.Forms.TextBox();
            this.groupBox_task1 = new System.Windows.Forms.GroupBox();
            this.groupBox_task2 = new System.Windows.Forms.GroupBox();
            this.textBox_origAddress = new System.Windows.Forms.TextBox();
            this.textBox_resultAddress = new System.Windows.Forms.TextBox();
            this.groupBox_task1.SuspendLayout();
            this.groupBox_task2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_originalText
            // 
            this.textBox_originalText.Location = new System.Drawing.Point(124, 67);
            this.textBox_originalText.Name = "textBox_originalText";
            this.textBox_originalText.Size = new System.Drawing.Size(555, 26);
            this.textBox_originalText.TabIndex = 0;
            this.textBox_originalText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_originalText_KeyDown);
            // 
            // textBox_resultText
            // 
            this.textBox_resultText.Location = new System.Drawing.Point(124, 115);
            this.textBox_resultText.Name = "textBox_resultText";
            this.textBox_resultText.ReadOnly = true;
            this.textBox_resultText.Size = new System.Drawing.Size(555, 26);
            this.textBox_resultText.TabIndex = 1;
            // 
            // groupBox_task1
            // 
            this.groupBox_task1.Controls.Add(this.textBox_originalText);
            this.groupBox_task1.Controls.Add(this.textBox_resultText);
            this.groupBox_task1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_task1.Location = new System.Drawing.Point(0, 0);
            this.groupBox_task1.Name = "groupBox_task1";
            this.groupBox_task1.Size = new System.Drawing.Size(800, 215);
            this.groupBox_task1.TabIndex = 2;
            this.groupBox_task1.TabStop = false;
            this.groupBox_task1.Text = "Слова с гласной буквы";
            // 
            // groupBox_task2
            // 
            this.groupBox_task2.Controls.Add(this.textBox_origAddress);
            this.groupBox_task2.Controls.Add(this.textBox_resultAddress);
            this.groupBox_task2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_task2.Location = new System.Drawing.Point(0, 221);
            this.groupBox_task2.Name = "groupBox_task2";
            this.groupBox_task2.Size = new System.Drawing.Size(800, 229);
            this.groupBox_task2.TabIndex = 3;
            this.groupBox_task2.TabStop = false;
            this.groupBox_task2.Text = "IPv4 адреса";
            // 
            // textBox_origAddress
            // 
            this.textBox_origAddress.Location = new System.Drawing.Point(124, 75);
            this.textBox_origAddress.Name = "textBox_origAddress";
            this.textBox_origAddress.Size = new System.Drawing.Size(555, 26);
            this.textBox_origAddress.TabIndex = 0;
            this.textBox_origAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_origAddress_KeyDown);
            // 
            // textBox_resultAddress
            // 
            this.textBox_resultAddress.Location = new System.Drawing.Point(124, 123);
            this.textBox_resultAddress.Name = "textBox_resultAddress";
            this.textBox_resultAddress.ReadOnly = true;
            this.textBox_resultAddress.Size = new System.Drawing.Size(555, 26);
            this.textBox_resultAddress.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_task2);
            this.Controls.Add(this.groupBox_task1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_task1.ResumeLayout(false);
            this.groupBox_task1.PerformLayout();
            this.groupBox_task2.ResumeLayout(false);
            this.groupBox_task2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_originalText;
        private System.Windows.Forms.TextBox textBox_resultText;
        private System.Windows.Forms.GroupBox groupBox_task1;
        private System.Windows.Forms.GroupBox groupBox_task2;
        private System.Windows.Forms.TextBox textBox_origAddress;
        private System.Windows.Forms.TextBox textBox_resultAddress;
    }
}

