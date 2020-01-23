namespace WindowsFormsApp1
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 525);
            this.hScrollBar1.Maximum = 180;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(800, 17);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Value = 90;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(783, 0);
            this.vScrollBar1.Maximum = 180;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 525);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Value = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 525);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.button1.Location = new System.Drawing.Point(3, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.radioButton32);
            this.panel6.Controls.Add(this.radioButton31);
            this.panel6.Location = new System.Drawing.Point(3, 459);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 73);
            this.panel6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Зарисовка";
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.Checked = true;
            this.radioButton32.Location = new System.Drawing.Point(87, 37);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(80, 17);
            this.radioButton32.TabIndex = 6;
            this.radioButton32.TabStop = true;
            this.radioButton32.Text = "Каркасная";
            this.radioButton32.UseVisualStyleBackColor = true;
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.Location = new System.Drawing.Point(8, 37);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(76, 17);
            this.radioButton31.TabIndex = 5;
            this.radioButton31.Text = "Сплошная";
            this.radioButton31.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.checkBox4);
            this.panel5.Controls.Add(this.checkBox3);
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 351);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 102);
            this.panel5.TabIndex = 3;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(98, 65);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Точка Г";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(98, 29);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Точка В";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Точка Б";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Точка А";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Траектория";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 119);
            this.panel4.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Кинематические";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Kinematic_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Геометрические";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Geometry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Параметры";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButton22);
            this.panel3.Controls.Add(this.radioButton21);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 111);
            this.panel3.TabIndex = 1;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Checked = true;
            this.radioButton22.Location = new System.Drawing.Point(9, 75);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(85, 17);
            this.radioButton22.TabIndex = 7;
            this.radioButton22.TabStop = true;
            this.radioButton22.Text = "Остановить";
            this.radioButton22.UseVisualStyleBackColor = true;
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(8, 43);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(61, 17);
            this.radioButton21.TabIndex = 5;
            this.radioButton21.Text = "Начать";
            this.radioButton21.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Движение";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton12);
            this.panel2.Controls.Add(this.radioButton11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 100);
            this.panel2.TabIndex = 0;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Checked = true;
            this.radioButton12.Location = new System.Drawing.Point(12, 60);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(126, 17);
            this.radioButton12.TabIndex = 9;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Спрятать механизм";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(12, 27);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(128, 17);
            this.radioButton11.TabIndex = 8;
            this.radioButton11.Text = "Показать механизм";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Рисунок";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MouseWheel1);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton32;
        private System.Windows.Forms.RadioButton radioButton31;
    }
}

