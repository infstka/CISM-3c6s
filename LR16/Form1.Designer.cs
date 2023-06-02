namespace LR16
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
            this.sync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.k_input = new System.Windows.Forms.TextBox();
            this.n_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.res_tb = new System.Windows.Forms.RichTextBox();
            this.avgSteps = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.avgTime = new System.Windows.Forms.TextBox();
            this.rlztns = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sync
            // 
            this.sync.Location = new System.Drawing.Point(12, 136);
            this.sync.Name = "sync";
            this.sync.Size = new System.Drawing.Size(119, 23);
            this.sync.TabIndex = 0;
            this.sync.Text = "Синхронизировать";
            this.sync.UseVisualStyleBackColor = true;
            this.sync.Click += new System.EventHandler(this.sync_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите K";
            // 
            // k_input
            // 
            this.k_input.Location = new System.Drawing.Point(13, 30);
            this.k_input.Multiline = true;
            this.k_input.Name = "k_input";
            this.k_input.Size = new System.Drawing.Size(117, 20);
            this.k_input.TabIndex = 2;
            this.k_input.Text = "5";
            // 
            // n_input
            // 
            this.n_input.Location = new System.Drawing.Point(13, 70);
            this.n_input.Multiline = true;
            this.n_input.Name = "n_input";
            this.n_input.Size = new System.Drawing.Size(117, 20);
            this.n_input.TabIndex = 4;
            this.n_input.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите N";
            // 
            // l_input
            // 
            this.l_input.Location = new System.Drawing.Point(13, 110);
            this.l_input.Multiline = true;
            this.l_input.Name = "l_input";
            this.l_input.Size = new System.Drawing.Size(117, 20);
            this.l_input.TabIndex = 6;
            this.l_input.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат";
            // 
            // res_tb
            // 
            this.res_tb.Location = new System.Drawing.Point(136, 29);
            this.res_tb.Name = "res_tb";
            this.res_tb.Size = new System.Drawing.Size(316, 129);
            this.res_tb.TabIndex = 9;
            this.res_tb.Text = "";
            // 
            // avgSteps
            // 
            this.avgSteps.Location = new System.Drawing.Point(136, 178);
            this.avgSteps.Name = "avgSteps";
            this.avgSteps.Size = new System.Drawing.Size(155, 20);
            this.avgSteps.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Среднее кол-во шагов";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(297, 162);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(150, 13);
            this.label.TabIndex = 13;
            this.label.Text = "Среднее время выполнения";
            // 
            // avgTime
            // 
            this.avgTime.Location = new System.Drawing.Point(297, 178);
            this.avgTime.Name = "avgTime";
            this.avgTime.Size = new System.Drawing.Size(155, 20);
            this.avgTime.TabIndex = 14;
            // 
            // rlztns
            // 
            this.rlztns.Location = new System.Drawing.Point(13, 178);
            this.rlztns.Name = "rlztns";
            this.rlztns.Size = new System.Drawing.Size(117, 20);
            this.rlztns.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кол-во реализаций";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 210);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rlztns);
            this.Controls.Add(this.avgTime);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.avgSteps);
            this.Controls.Add(this.res_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.k_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox k_input;
        private System.Windows.Forms.TextBox n_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox l_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox res_tb;
        private System.Windows.Forms.TextBox avgSteps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox avgTime;
        private System.Windows.Forms.TextBox rlztns;
        private System.Windows.Forms.Label label6;
    }
}

