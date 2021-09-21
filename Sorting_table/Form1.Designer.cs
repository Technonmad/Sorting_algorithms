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
            this.components = new System.ComponentModel.Container();
            this.sizeArrayBox = new System.Windows.Forms.ComboBox();
            this.bubbleTime = new System.Windows.Forms.Label();
            this.bubbleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bubbleProgress = new System.Windows.Forms.ProgressBar();
            this.shellProgress = new System.Windows.Forms.ProgressBar();
            this.quickProgress = new System.Windows.Forms.ProgressBar();
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
            this.bubbleTime.Location = new System.Drawing.Point(161, 43);
            this.bubbleTime.Name = "bubbleTime";
            this.bubbleTime.Size = new System.Drawing.Size(33, 13);
            this.bubbleTime.TabIndex = 1;
            this.bubbleTime.Text = "Time:";
            this.bubbleTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // bubbleButton
            // 
            this.bubbleButton.Enabled = false;
            this.bubbleButton.Location = new System.Drawing.Point(164, 10);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(75, 23);
            this.bubbleButton.TabIndex = 3;
            this.bubbleButton.Text = "Bubble";
            this.bubbleButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(270, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Shell";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(376, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quick Sort";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bubbleProgress
            // 
            this.bubbleProgress.Location = new System.Drawing.Point(155, 59);
            this.bubbleProgress.Name = "bubbleProgress";
            this.bubbleProgress.Size = new System.Drawing.Size(100, 10);
            this.bubbleProgress.TabIndex = 15;
            // 
            // shellProgress
            // 
            this.shellProgress.Location = new System.Drawing.Point(261, 59);
            this.shellProgress.Name = "shellProgress";
            this.shellProgress.Size = new System.Drawing.Size(100, 10);
            this.shellProgress.TabIndex = 16;
            this.shellProgress.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // quickProgress
            // 
            this.quickProgress.Location = new System.Drawing.Point(367, 59);
            this.quickProgress.Name = "quickProgress";
            this.quickProgress.Size = new System.Drawing.Size(100, 10);
            this.quickProgress.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 119);
            this.Controls.Add(this.quickProgress);
            this.Controls.Add(this.shellProgress);
            this.Controls.Add(this.bubbleProgress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bubbleButton);
            this.Controls.Add(this.bubbleTime);
            this.Controls.Add(this.sizeArrayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        public System.Windows.Forms.ComboBox sizeArrayBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar bubbleProgress;
        private System.Windows.Forms.ProgressBar shellProgress;
        private System.Windows.Forms.ProgressBar quickProgress;
    }
}

