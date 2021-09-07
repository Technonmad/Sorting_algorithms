namespace Sorting_table
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
            this.sizeArrayBox = new System.Windows.Forms.ComboBox();
            this.bubbleTime = new System.Windows.Forms.Label();
            this.bubbleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sizeArrayBox
            // 
            this.sizeArrayBox.FormattingEnabled = true;
            this.sizeArrayBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sizeArrayBox.Items.AddRange(new object[] {
            "10",
            "5000",
            "10000",
            "20000",
            "50000",
            "100000",
            "200000"});
            this.sizeArrayBox.Location = new System.Drawing.Point(12, 12);
            this.sizeArrayBox.Name = "sizeArrayBox";
            this.sizeArrayBox.Size = new System.Drawing.Size(121, 21);
            this.sizeArrayBox.TabIndex = 0;
            this.sizeArrayBox.Text = "10";
            // 
            // bubbleTime
            // 
            this.bubbleTime.AutoSize = true;
            this.bubbleTime.Location = new System.Drawing.Point(176, 46);
            this.bubbleTime.Name = "bubbleTime";
            this.bubbleTime.Size = new System.Drawing.Size(33, 13);
            this.bubbleTime.TabIndex = 1;
            this.bubbleTime.Text = "Time:";
            this.bubbleTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // bubbleButton
            // 
            this.bubbleButton.Enabled = false;
            this.bubbleButton.Location = new System.Drawing.Point(179, 10);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(75, 23);
            this.bubbleButton.TabIndex = 3;
            this.bubbleButton.Text = "Bubble";
            this.bubbleButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(279, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bubble";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(379, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bubble";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 227);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 82);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 227);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(391, 82);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 227);
            this.textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 452);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bubbleButton);
            this.Controls.Add(this.bubbleTime);
            this.Controls.Add(this.sizeArrayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bubbleTime;
        private System.Windows.Forms.Button bubbleButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox sizeArrayBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

