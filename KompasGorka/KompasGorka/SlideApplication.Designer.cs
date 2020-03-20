namespace KompasGorka
{
    partial class SlideApplication
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
            this.buttonBuildSlide = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelPlatformLeght = new System.Windows.Forms.Label();
            this.groupBoxSlide = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.labelPlatformHeight = new System.Windows.Forms.Label();
            this.labelBorderHeight = new System.Windows.Forms.Label();
            this.labelSlideWidth = new System.Windows.Forms.Label();
            this.labelSlideBeginLegth = new System.Windows.Forms.Label();
            this.labelSlideLegth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBoxSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuildSlide
            // 
            this.buttonBuildSlide.Location = new System.Drawing.Point(70, 340);
            this.buttonBuildSlide.Name = "buttonBuildSlide";
            this.buttonBuildSlide.Size = new System.Drawing.Size(147, 23);
            this.buttonBuildSlide.TabIndex = 0;
            this.buttonBuildSlide.Text = "Построить горку";
            this.buttonBuildSlide.UseVisualStyleBackColor = true;
            this.buttonBuildSlide.Click += new System.EventHandler(this.buttonBuildSlide_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(70, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(147, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Запустить Kompas 3D";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // labelPlatformLeght
            // 
            this.labelPlatformLeght.AutoSize = true;
            this.labelPlatformLeght.Location = new System.Drawing.Point(6, 25);
            this.labelPlatformLeght.Name = "labelPlatformLeght";
            this.labelPlatformLeght.Size = new System.Drawing.Size(102, 13);
            this.labelPlatformLeght.TabIndex = 6;
            this.labelPlatformLeght.Text = "Длина платформы";
            // 
            // groupBoxSlide
            // 
            this.groupBoxSlide.Controls.Add(this.textBox7);
            this.groupBoxSlide.Controls.Add(this.labelPlatformHeight);
            this.groupBoxSlide.Controls.Add(this.labelBorderHeight);
            this.groupBoxSlide.Controls.Add(this.labelSlideWidth);
            this.groupBoxSlide.Controls.Add(this.labelSlideBeginLegth);
            this.groupBoxSlide.Controls.Add(this.labelSlideLegth);
            this.groupBoxSlide.Controls.Add(this.label2);
            this.groupBoxSlide.Controls.Add(this.textBox6);
            this.groupBoxSlide.Controls.Add(this.textBox5);
            this.groupBoxSlide.Controls.Add(this.textBox2);
            this.groupBoxSlide.Controls.Add(this.labelPlatformLeght);
            this.groupBoxSlide.Controls.Add(this.textBox1);
            this.groupBoxSlide.Controls.Add(this.textBox4);
            this.groupBoxSlide.Controls.Add(this.textBox3);
            this.groupBoxSlide.Location = new System.Drawing.Point(12, 41);
            this.groupBoxSlide.Name = "groupBoxSlide";
            this.groupBoxSlide.Size = new System.Drawing.Size(242, 293);
            this.groupBoxSlide.TabIndex = 7;
            this.groupBoxSlide.TabStop = false;
            this.groupBoxSlide.Text = "Параметры горки";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(132, 258);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // labelPlatformHeight
            // 
            this.labelPlatformHeight.AutoSize = true;
            this.labelPlatformHeight.Location = new System.Drawing.Point(6, 258);
            this.labelPlatformHeight.Name = "labelPlatformHeight";
            this.labelPlatformHeight.Size = new System.Drawing.Size(107, 13);
            this.labelPlatformHeight.TabIndex = 14;
            this.labelPlatformHeight.Text = "Высота платформы";
            // 
            // labelBorderHeight
            // 
            this.labelBorderHeight.AutoSize = true;
            this.labelBorderHeight.Location = new System.Drawing.Point(6, 222);
            this.labelBorderHeight.Name = "labelBorderHeight";
            this.labelBorderHeight.Size = new System.Drawing.Size(92, 13);
            this.labelBorderHeight.TabIndex = 13;
            this.labelBorderHeight.Text = "Высота бордюра";
            // 
            // labelSlideWidth
            // 
            this.labelSlideWidth.AutoSize = true;
            this.labelSlideWidth.Location = new System.Drawing.Point(6, 186);
            this.labelSlideWidth.Name = "labelSlideWidth";
            this.labelSlideWidth.Size = new System.Drawing.Size(78, 13);
            this.labelSlideWidth.TabIndex = 12;
            this.labelSlideWidth.Text = "Ширина горки";
            // 
            // labelSlideBeginLegth
            // 
            this.labelSlideBeginLegth.AutoSize = true;
            this.labelSlideBeginLegth.Location = new System.Drawing.Point(6, 64);
            this.labelSlideBeginLegth.Name = "labelSlideBeginLegth";
            this.labelSlideBeginLegth.Size = new System.Drawing.Size(110, 13);
            this.labelSlideBeginLegth.TabIndex = 11;
            this.labelSlideBeginLegth.Text = "Длина начала горки";
            // 
            // labelSlideLegth
            // 
            this.labelSlideLegth.AutoSize = true;
            this.labelSlideLegth.Location = new System.Drawing.Point(6, 145);
            this.labelSlideLegth.Name = "labelSlideLegth";
            this.labelSlideLegth.Size = new System.Drawing.Size(72, 13);
            this.labelSlideLegth.TabIndex = 10;
            this.labelSlideLegth.Text = "Длина горки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Длина конца горки";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 219);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            // 
            // SlideApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 372);
            this.Controls.Add(this.groupBoxSlide);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBuildSlide);
            this.Name = "SlideApplication";
            this.Text = "SlideApplication";
            this.Load += new System.EventHandler(this.SlideApplication_Load);
            this.groupBoxSlide.ResumeLayout(false);
            this.groupBoxSlide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuildSlide;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelPlatformLeght;
        private System.Windows.Forms.GroupBox groupBoxSlide;
        private System.Windows.Forms.Label labelSlideBeginLegth;
        private System.Windows.Forms.Label labelSlideLegth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label labelPlatformHeight;
        private System.Windows.Forms.Label labelBorderHeight;
        private System.Windows.Forms.Label labelSlideWidth;
    }
}

