namespace KompasGorka.GUI
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
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.labelPlatformLeght = new System.Windows.Forms.Label();
            this.groupBoxSlide = new System.Windows.Forms.GroupBox();
            this.labelPlatformThickness = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.labelPlatformHeight = new System.Windows.Forms.Label();
            this.labelBorderHeight = new System.Windows.Forms.Label();
            this.labelSlideWidth = new System.Windows.Forms.Label();
            this.labelSlideBeginLegth = new System.Windows.Forms.Label();
            this.labelSlideLegth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.labelT = new System.Windows.Forms.Label();
            this.groupBoxSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuildSlide
            // 
            this.buttonBuildSlide.Location = new System.Drawing.Point(159, 359);
            this.buttonBuildSlide.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuildSlide.Name = "buttonBuildSlide";
            this.buttonBuildSlide.Size = new System.Drawing.Size(196, 28);
            this.buttonBuildSlide.TabIndex = 0;
            this.buttonBuildSlide.Text = "Построить горку";
            this.buttonBuildSlide.UseVisualStyleBackColor = true;
            this.buttonBuildSlide.Click += new System.EventHandler(this.ButtonBuildSlide_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(159, 15);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(196, 28);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Запустить Kompas 3D";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(188, 161);
            this.textBoxF.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(132, 22);
            this.textBoxF.TabIndex = 1;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(188, 97);
            this.textBoxL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(132, 22);
            this.textBoxL.TabIndex = 4;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(188, 65);
            this.textBoxD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(132, 22);
            this.textBoxD.TabIndex = 3;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(188, 225);
            this.textBoxE.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(132, 22);
            this.textBoxE.TabIndex = 2;
            // 
            // labelPlatformLeght
            // 
            this.labelPlatformLeght.AutoSize = true;
            this.labelPlatformLeght.Location = new System.Drawing.Point(8, 161);
            this.labelPlatformLeght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlatformLeght.Name = "labelPlatformLeght";
            this.labelPlatformLeght.Size = new System.Drawing.Size(158, 17);
            this.labelPlatformLeght.TabIndex = 6;
            this.labelPlatformLeght.Text = "Длина платформы (F):";
            // 
            // groupBoxSlide
            // 
            this.groupBoxSlide.Controls.Add(this.labelT);
            this.groupBoxSlide.Controls.Add(this.textBoxT);
            this.groupBoxSlide.Controls.Add(this.labelPlatformThickness);
            this.groupBoxSlide.Controls.Add(this.labelG);
            this.groupBoxSlide.Controls.Add(this.labelC);
            this.groupBoxSlide.Controls.Add(this.labelA);
            this.groupBoxSlide.Controls.Add(this.labelL);
            this.groupBoxSlide.Controls.Add(this.labelD);
            this.groupBoxSlide.Controls.Add(this.labelE);
            this.groupBoxSlide.Controls.Add(this.labelF);
            this.groupBoxSlide.Controls.Add(this.textBoxG);
            this.groupBoxSlide.Controls.Add(this.labelPlatformHeight);
            this.groupBoxSlide.Controls.Add(this.labelBorderHeight);
            this.groupBoxSlide.Controls.Add(this.labelSlideWidth);
            this.groupBoxSlide.Controls.Add(this.labelSlideBeginLegth);
            this.groupBoxSlide.Controls.Add(this.labelSlideLegth);
            this.groupBoxSlide.Controls.Add(this.label2);
            this.groupBoxSlide.Controls.Add(this.textBoxC);
            this.groupBoxSlide.Controls.Add(this.textBoxA);
            this.groupBoxSlide.Controls.Add(this.textBoxL);
            this.groupBoxSlide.Controls.Add(this.labelPlatformLeght);
            this.groupBoxSlide.Controls.Add(this.textBoxF);
            this.groupBoxSlide.Controls.Add(this.textBoxE);
            this.groupBoxSlide.Controls.Add(this.textBoxD);
            this.groupBoxSlide.Location = new System.Drawing.Point(16, 50);
            this.groupBoxSlide.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSlide.Name = "groupBoxSlide";
            this.groupBoxSlide.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSlide.Size = new System.Drawing.Size(468, 301);
            this.groupBoxSlide.TabIndex = 7;
            this.groupBoxSlide.TabStop = false;
            this.groupBoxSlide.Text = "Параметры горки";
            // 
            // labelPlatformThickness
            // 
            this.labelPlatformThickness.AutoSize = true;
            this.labelPlatformThickness.Location = new System.Drawing.Point(7, 260);
            this.labelPlatformThickness.Name = "labelPlatformThickness";
            this.labelPlatformThickness.Size = new System.Drawing.Size(176, 17);
            this.labelPlatformThickness.TabIndex = 23;
            this.labelPlatformThickness.Text = "Толщина платформы (T):";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(329, 129);
            this.labelG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(121, 17);
            this.labelG.TabIndex = 22;
            this.labelG.Text = "(от 40 до 160) см";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(329, 33);
            this.labelC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(105, 17);
            this.labelC.TabIndex = 21;
            this.labelC.Text = "(от 8 до 32) см";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(329, 193);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(113, 17);
            this.labelA.TabIndex = 20;
            this.labelA.Text = "(от 20 до 80) см";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Location = new System.Drawing.Point(329, 97);
            this.labelL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(121, 17);
            this.labelL.TabIndex = 19;
            this.labelL.Text = "(от 80 до 240) см";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(329, 65);
            this.labelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(113, 17);
            this.labelD.TabIndex = 18;
            this.labelD.Text = "(от 20 до 60) см";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(329, 225);
            this.labelE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(113, 17);
            this.labelE.TabIndex = 17;
            this.labelE.Text = "(от 20 до 60) см";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(329, 161);
            this.labelF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(121, 17);
            this.labelF.TabIndex = 16;
            this.labelF.Text = "(от 40 до 120) см";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(188, 129);
            this.textBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(132, 22);
            this.textBoxG.TabIndex = 7;
            // 
            // labelPlatformHeight
            // 
            this.labelPlatformHeight.AutoSize = true;
            this.labelPlatformHeight.Location = new System.Drawing.Point(8, 129);
            this.labelPlatformHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlatformHeight.Name = "labelPlatformHeight";
            this.labelPlatformHeight.Size = new System.Drawing.Size(163, 17);
            this.labelPlatformHeight.TabIndex = 14;
            this.labelPlatformHeight.Text = "Высота платформы (G)";
            // 
            // labelBorderHeight
            // 
            this.labelBorderHeight.AutoSize = true;
            this.labelBorderHeight.Location = new System.Drawing.Point(8, 33);
            this.labelBorderHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBorderHeight.Name = "labelBorderHeight";
            this.labelBorderHeight.Size = new System.Drawing.Size(142, 17);
            this.labelBorderHeight.TabIndex = 13;
            this.labelBorderHeight.Text = "Высота бордюра (C)";
            // 
            // labelSlideWidth
            // 
            this.labelSlideWidth.AutoSize = true;
            this.labelSlideWidth.Location = new System.Drawing.Point(8, 193);
            this.labelSlideWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSlideWidth.Name = "labelSlideWidth";
            this.labelSlideWidth.Size = new System.Drawing.Size(126, 17);
            this.labelSlideWidth.TabIndex = 12;
            this.labelSlideWidth.Text = "Ширина горки (A):";
            // 
            // labelSlideBeginLegth
            // 
            this.labelSlideBeginLegth.AutoSize = true;
            this.labelSlideBeginLegth.Location = new System.Drawing.Point(8, 225);
            this.labelSlideBeginLegth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSlideBeginLegth.Name = "labelSlideBeginLegth";
            this.labelSlideBeginLegth.Size = new System.Drawing.Size(170, 17);
            this.labelSlideBeginLegth.TabIndex = 11;
            this.labelSlideBeginLegth.Text = "Длина начала горки (E):";
            // 
            // labelSlideLegth
            // 
            this.labelSlideLegth.AutoSize = true;
            this.labelSlideLegth.Location = new System.Drawing.Point(8, 97);
            this.labelSlideLegth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSlideLegth.Name = "labelSlideLegth";
            this.labelSlideLegth.Size = new System.Drawing.Size(117, 17);
            this.labelSlideLegth.TabIndex = 10;
            this.labelSlideLegth.Text = "Длина горки (L):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Длина конца горки (D):";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(188, 33);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(132, 22);
            this.textBoxC.TabIndex = 6;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(188, 193);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(132, 22);
            this.textBoxA.TabIndex = 5;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(188, 260);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(132, 22);
            this.textBoxT.TabIndex = 24;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(329, 260);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(105, 17);
            this.labelT.TabIndex = 25;
            this.labelT.Text = "(от 3 до 10) см";
            // 
            // SlideApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.groupBoxSlide);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBuildSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SlideApplication";
            this.Text = "SlideApplication";
            this.groupBoxSlide.ResumeLayout(false);
            this.groupBoxSlide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuildSlide;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label labelPlatformLeght;
        private System.Windows.Forms.GroupBox groupBoxSlide;
        private System.Windows.Forms.Label labelSlideBeginLegth;
        private System.Windows.Forms.Label labelSlideLegth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label labelPlatformHeight;
        private System.Windows.Forms.Label labelBorderHeight;
        private System.Windows.Forms.Label labelSlideWidth;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelPlatformThickness;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.TextBox textBoxT;
    }
}

