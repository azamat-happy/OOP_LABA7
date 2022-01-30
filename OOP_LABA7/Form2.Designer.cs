
namespace OOP_LABA7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.orangelabel = new System.Windows.Forms.Label();
            this.redlabel = new System.Windows.Forms.Label();
            this.yellowlabel = new System.Windows.Forms.Label();
            this.greenlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ChoosedObject = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_ObjectCounter = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Передвижение \"↑ ↓ ⇆\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Уменьшить - \"-\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Увеличить - \"+\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.orangelabel);
            this.panel2.Controls.Add(this.redlabel);
            this.panel2.Controls.Add(this.yellowlabel);
            this.panel2.Controls.Add(this.greenlabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(713, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 179);
            this.panel2.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Удалить - delete";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Удалить - delete";
            // 
            // orangelabel
            // 
            this.orangelabel.BackColor = System.Drawing.Color.Orange;
            this.orangelabel.Location = new System.Drawing.Point(130, 40);
            this.orangelabel.Name = "orangelabel";
            this.orangelabel.Size = new System.Drawing.Size(35, 35);
            this.orangelabel.TabIndex = 6;
            this.orangelabel.Text = "O";
            this.orangelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redlabel
            // 
            this.redlabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.redlabel.Location = new System.Drawing.Point(89, 40);
            this.redlabel.Name = "redlabel";
            this.redlabel.Size = new System.Drawing.Size(35, 35);
            this.redlabel.TabIndex = 5;
            this.redlabel.Text = "L";
            this.redlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yellowlabel
            // 
            this.yellowlabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowlabel.Location = new System.Drawing.Point(48, 40);
            this.yellowlabel.Name = "yellowlabel";
            this.yellowlabel.Size = new System.Drawing.Size(35, 35);
            this.yellowlabel.TabIndex = 2;
            this.yellowlabel.Text = "Y";
            this.yellowlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenlabel
            // 
            this.greenlabel.BackColor = System.Drawing.Color.Green;
            this.greenlabel.ForeColor = System.Drawing.SystemColors.Window;
            this.greenlabel.Location = new System.Drawing.Point(7, 40);
            this.greenlabel.Name = "greenlabel";
            this.greenlabel.Size = new System.Drawing.Size(35, 35);
            this.greenlabel.TabIndex = 1;
            this.greenlabel.Text = "G";
            this.greenlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Выбрать цвет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 - Круг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Выделенных объектов:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(713, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 64);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "3 - Треугольник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "2 - Квадрат";
            // 
            // lb_ChoosedObject
            // 
            this.lb_ChoosedObject.AutoSize = true;
            this.lb_ChoosedObject.Location = new System.Drawing.Point(372, 4);
            this.lb_ChoosedObject.Name = "lb_ChoosedObject";
            this.lb_ChoosedObject.Size = new System.Drawing.Size(13, 15);
            this.lb_ChoosedObject.TabIndex = 3;
            this.lb_ChoosedObject.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Объектов на форме:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(10, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 450);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lb_ObjectCounter
            // 
            this.lb_ObjectCounter.AutoSize = true;
            this.lb_ObjectCounter.Location = new System.Drawing.Point(129, 4);
            this.lb_ObjectCounter.Name = "lb_ObjectCounter";
            this.lb_ObjectCounter.Size = new System.Drawing.Size(13, 15);
            this.lb_ObjectCounter.TabIndex = 0;
            this.lb_ObjectCounter.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.lb_ChoosedObject);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lb_ObjectCounter);
            this.panel4.Location = new System.Drawing.Point(10, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(885, 23);
            this.panel4.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label orangelabel;
        private System.Windows.Forms.Label redlabel;
        public System.Windows.Forms.Label yellowlabel;
        private System.Windows.Forms.Label greenlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ChoosedObject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_ObjectCounter;
        private System.Windows.Forms.Panel panel4;
    }
}