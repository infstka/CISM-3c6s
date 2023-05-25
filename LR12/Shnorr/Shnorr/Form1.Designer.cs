namespace Shnorr
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtFakeText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.execTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shnorr";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(12, 79);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите данные";
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(12, 183);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(206, 23);
            this.sign.TabIndex = 4;
            this.sign.Text = "Подписать";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "p";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "q";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(118, 79);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(100, 20);
            this.txtQ.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "g";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(12, 118);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(118, 118);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "x";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(12, 157);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "M";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(118, 157);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 14;
            // 
            // txtFakeText
            // 
            this.txtFakeText.Location = new System.Drawing.Point(12, 293);
            this.txtFakeText.Name = "txtFakeText";
            this.txtFakeText.Size = new System.Drawing.Size(100, 20);
            this.txtFakeText.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Проверка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Введите текст";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Проверить подлинность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // execTime
            // 
            this.execTime.Location = new System.Drawing.Point(12, 222);
            this.execTime.Name = "execTime";
            this.execTime.Size = new System.Drawing.Size(206, 20);
            this.execTime.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 354);
            this.Controls.Add(this.execTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFakeText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LR11 - Shnorr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtFakeText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox execTime;
    }
}

