namespace Lab_10
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
            this.image = new System.Windows.Forms.PictureBox();
            this.lab = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.LUX = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LUY = new System.Windows.Forms.MaskedTextBox();
            this.RDX = new System.Windows.Forms.MaskedTextBox();
            this.RDY = new System.Windows.Forms.MaskedTextBox();
            this.P1X = new System.Windows.Forms.MaskedTextBox();
            this.P1Y = new System.Windows.Forms.MaskedTextBox();
            this.P2X = new System.Windows.Forms.MaskedTextBox();
            this.P2Y = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.Location = new System.Drawing.Point(10, 11);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(580, 210);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Paint += new System.Windows.Forms.PaintEventHandler(this.image_Paint);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(11, 244);
            this.lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(20, 13);
            this.lab.TabIndex = 1;
            this.lab.Text = "X1";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(11, 268);
            this.lab1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(20, 13);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "Y1";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(11, 305);
            this.lab3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(20, 13);
            this.lab3.TabIndex = 3;
            this.lab3.Text = "X2";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(11, 329);
            this.lab4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(20, 13);
            this.lab4.TabIndex = 4;
            this.lab4.Text = "Y2";
            // 
            // LUX
            // 
            this.LUX.Location = new System.Drawing.Point(45, 244);
            this.LUX.Margin = new System.Windows.Forms.Padding(2);
            this.LUX.Mask = "000";
            this.LUX.Name = "LUX";
            this.LUX.Size = new System.Drawing.Size(76, 20);
            this.LUX.TabIndex = 5;
            this.LUX.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Верхний левый угол прямоугольника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Первая точка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y";
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Location = new System.Drawing.Point(214, 305);
            this.lab7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(14, 13);
            this.lab7.TabIndex = 12;
            this.lab7.Text = "X";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(214, 268);
            this.lab6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(14, 13);
            this.lab6.TabIndex = 11;
            this.lab6.Text = "Y";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(214, 244);
            this.lab5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(14, 13);
            this.lab5.TabIndex = 10;
            this.lab5.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 275);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Площадь фигуры =";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(453, 275);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(0, 13);
            this.areaLabel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Правый нижний угол прямоугольника";
            // 
            // LUY
            // 
            this.LUY.Location = new System.Drawing.Point(45, 268);
            this.LUY.Margin = new System.Windows.Forms.Padding(2);
            this.LUY.Mask = "000";
            this.LUY.Name = "LUY";
            this.LUY.Size = new System.Drawing.Size(76, 20);
            this.LUY.TabIndex = 22;
            this.LUY.Text = "100";
            // 
            // RDX
            // 
            this.RDX.Location = new System.Drawing.Point(45, 305);
            this.RDX.Margin = new System.Windows.Forms.Padding(2);
            this.RDX.Mask = "000";
            this.RDX.Name = "RDX";
            this.RDX.Size = new System.Drawing.Size(76, 20);
            this.RDX.TabIndex = 23;
            this.RDX.Text = "400";
            // 
            // RDY
            // 
            this.RDY.Location = new System.Drawing.Point(45, 329);
            this.RDY.Margin = new System.Windows.Forms.Padding(2);
            this.RDY.Mask = "000";
            this.RDY.Name = "RDY";
            this.RDY.Size = new System.Drawing.Size(76, 20);
            this.RDY.TabIndex = 24;
            this.RDY.Text = "200";
            // 
            // P1X
            // 
            this.P1X.Location = new System.Drawing.Point(236, 244);
            this.P1X.Margin = new System.Windows.Forms.Padding(2);
            this.P1X.Mask = "000";
            this.P1X.Name = "P1X";
            this.P1X.Size = new System.Drawing.Size(76, 20);
            this.P1X.TabIndex = 25;
            this.P1X.Text = "150";
            // 
            // P1Y
            // 
            this.P1Y.Location = new System.Drawing.Point(236, 268);
            this.P1Y.Margin = new System.Windows.Forms.Padding(2);
            this.P1Y.Mask = "000";
            this.P1Y.Name = "P1Y";
            this.P1Y.Size = new System.Drawing.Size(76, 20);
            this.P1Y.TabIndex = 26;
            this.P1Y.Text = "100";
            // 
            // P2X
            // 
            this.P2X.Location = new System.Drawing.Point(236, 305);
            this.P2X.Margin = new System.Windows.Forms.Padding(2);
            this.P2X.Mask = "000";
            this.P2X.Name = "P2X";
            this.P2X.Size = new System.Drawing.Size(76, 20);
            this.P2X.TabIndex = 27;
            this.P2X.Text = "200";
            // 
            // P2Y
            // 
            this.P2Y.Location = new System.Drawing.Point(236, 329);
            this.P2Y.Margin = new System.Windows.Forms.Padding(2);
            this.P2Y.Mask = "000";
            this.P2Y.Name = "P2Y";
            this.P2Y.Size = new System.Drawing.Size(76, 20);
            this.P2Y.TabIndex = 28;
            this.P2Y.Text = "200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Вторая точка";
            // 
            // PlayB
            // 
            this.PlayB.Location = new System.Drawing.Point(418, 244);
            this.PlayB.Margin = new System.Windows.Forms.Padding(2);
            this.PlayB.Name = "PlayB";
            this.PlayB.Size = new System.Drawing.Size(56, 19);
            this.PlayB.TabIndex = 30;
            this.PlayB.Text = "Запуск";
            this.PlayB.UseVisualStyleBackColor = true;
            this.PlayB.Click += new System.EventHandler(this.PlayB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.PlayB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P2Y);
            this.Controls.Add(this.P2X);
            this.Controls.Add(this.P1Y);
            this.Controls.Add(this.P1X);
            this.Controls.Add(this.RDY);
            this.Controls.Add(this.RDX);
            this.Controls.Add(this.LUY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lab7);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LUX);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.image);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.MaskedTextBox LUX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox LUY;
        private System.Windows.Forms.MaskedTextBox RDX;
        private System.Windows.Forms.MaskedTextBox RDY;
        private System.Windows.Forms.MaskedTextBox P1X;
        private System.Windows.Forms.MaskedTextBox P1Y;
        private System.Windows.Forms.MaskedTextBox P2X;
        private System.Windows.Forms.MaskedTextBox P2Y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlayB;
    }
}

