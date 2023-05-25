namespace El_Gamal
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
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.execTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(15, 63);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "El-Gamal";
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(15, 167);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(206, 23);
            this.sign.TabIndex = 2;
            this.sign.Text = "Подписать";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "p";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "g";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(121, 63);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите значения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "k";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(121, 102);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "x";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(15, 102);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "H";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(15, 141);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(206, 20);
            this.txtH.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "b";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(15, 305);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(206, 20);
            this.txtB.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(121, 266);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(15, 266);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 13;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(15, 331);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(206, 23);
            this.check.TabIndex = 19;
            this.check.Text = "Проверить подписи";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // execTime
            // 
            this.execTime.Location = new System.Drawing.Point(15, 211);
            this.execTime.Name = "execTime";
            this.execTime.Size = new System.Drawing.Size(206, 20);
            this.execTime.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 366);
            this.Controls.Add(this.execTime);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP);
            this.Name = "Form1";
            this.Text = "LR11 - El-Gamal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox execTime;
    }
}

