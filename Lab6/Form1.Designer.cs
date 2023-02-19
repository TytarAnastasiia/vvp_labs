namespace Lab6
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
            this.textBox_oroginalText = new System.Windows.Forms.TextBox();
            this.textBox_resultText = new System.Windows.Forms.TextBox();
            this.groupBox_invertWord = new System.Windows.Forms.GroupBox();
            this.groupBox_numberName = new System.Windows.Forms.GroupBox();
            this.textBox_numbers = new System.Windows.Forms.TextBox();
            this.textBox_numbersNames = new System.Windows.Forms.TextBox();
            this.groupBox_invertWord.SuspendLayout();
            this.groupBox_numberName.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_oroginalText
            // 
            this.textBox_oroginalText.Location = new System.Drawing.Point(182, 77);
            this.textBox_oroginalText.Name = "textBox_oroginalText";
            this.textBox_oroginalText.Size = new System.Drawing.Size(422, 26);
            this.textBox_oroginalText.TabIndex = 0;
            this.textBox_oroginalText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_oroginalText_KeyDown);
            // 
            // textBox_resultText
            // 
            this.textBox_resultText.Location = new System.Drawing.Point(182, 109);
            this.textBox_resultText.Name = "textBox_resultText";
            this.textBox_resultText.ReadOnly = true;
            this.textBox_resultText.Size = new System.Drawing.Size(422, 26);
            this.textBox_resultText.TabIndex = 1;
            // 
            // groupBox_invertWord
            // 
            this.groupBox_invertWord.Controls.Add(this.textBox_oroginalText);
            this.groupBox_invertWord.Controls.Add(this.textBox_resultText);
            this.groupBox_invertWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_invertWord.Location = new System.Drawing.Point(0, 0);
            this.groupBox_invertWord.Name = "groupBox_invertWord";
            this.groupBox_invertWord.Size = new System.Drawing.Size(800, 216);
            this.groupBox_invertWord.TabIndex = 2;
            this.groupBox_invertWord.TabStop = false;
            this.groupBox_invertWord.Text = "Задание 1";
            // 
            // groupBox_numberName
            // 
            this.groupBox_numberName.Controls.Add(this.textBox_numbers);
            this.groupBox_numberName.Controls.Add(this.textBox_numbersNames);
            this.groupBox_numberName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_numberName.Location = new System.Drawing.Point(0, 222);
            this.groupBox_numberName.Name = "groupBox_numberName";
            this.groupBox_numberName.Size = new System.Drawing.Size(800, 228);
            this.groupBox_numberName.TabIndex = 3;
            this.groupBox_numberName.TabStop = false;
            this.groupBox_numberName.Text = "Задание 2";
            // 
            // textBox_numbers
            // 
            this.textBox_numbers.Location = new System.Drawing.Point(182, 77);
            this.textBox_numbers.Name = "textBox_numbers";
            this.textBox_numbers.Size = new System.Drawing.Size(422, 26);
            this.textBox_numbers.TabIndex = 0;
            this.textBox_numbers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_numbers_KeyDown);
            // 
            // textBox_numbersNames
            // 
            this.textBox_numbersNames.Location = new System.Drawing.Point(182, 109);
            this.textBox_numbersNames.Name = "textBox_numbersNames";
            this.textBox_numbersNames.ReadOnly = true;
            this.textBox_numbersNames.Size = new System.Drawing.Size(422, 26);
            this.textBox_numbersNames.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_numberName);
            this.Controls.Add(this.groupBox_invertWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_invertWord.ResumeLayout(false);
            this.groupBox_invertWord.PerformLayout();
            this.groupBox_numberName.ResumeLayout(false);
            this.groupBox_numberName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_oroginalText;
        private System.Windows.Forms.TextBox textBox_resultText;
        private System.Windows.Forms.GroupBox groupBox_invertWord;
        private System.Windows.Forms.GroupBox groupBox_numberName;
        private System.Windows.Forms.TextBox textBox_numbers;
        private System.Windows.Forms.TextBox textBox_numbersNames;
    }
}

