namespace LR9
{
    partial class UI
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
            this.encode_button = new System.Windows.Forms.Button();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decode_button = new System.Windows.Forms.Button();
            this.exectime_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sp_textbox = new System.Windows.Forms.TextBox();
            this.generate_button = new System.Windows.Forms.Button();
            this.calc_button = new System.Windows.Forms.Button();
            this.np_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сообщение";
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(227, 25);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(346, 23);
            this.encode_button.TabIndex = 1;
            this.encode_button.Text = "Зашифровать";
            this.encode_button.UseVisualStyleBackColor = true;
            this.encode_button.Click += new System.EventHandler(this.encode_button_Click);
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 25);
            this.input_textbox.Multiline = true;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(209, 413);
            this.input_textbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат";
            // 
            // decode_button
            // 
            this.decode_button.Location = new System.Drawing.Point(227, 54);
            this.decode_button.Name = "decode_button";
            this.decode_button.Size = new System.Drawing.Size(346, 23);
            this.decode_button.TabIndex = 6;
            this.decode_button.Text = "Расшифровать";
            this.decode_button.UseVisualStyleBackColor = true;
            this.decode_button.Click += new System.EventHandler(this.decode_button_Click);
            // 
            // exectime_textbox
            // 
            this.exectime_textbox.Location = new System.Drawing.Point(227, 96);
            this.exectime_textbox.Name = "exectime_textbox";
            this.exectime_textbox.Size = new System.Drawing.Size(346, 20);
            this.exectime_textbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время выполнения";
            // 
            // output_textbox
            // 
            this.output_textbox.Location = new System.Drawing.Point(579, 25);
            this.output_textbox.Multiline = true;
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.Size = new System.Drawing.Size(209, 413);
            this.output_textbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сверхвозрастающая последовательность";
            // 
            // sp_textbox
            // 
            this.sp_textbox.Location = new System.Drawing.Point(227, 135);
            this.sp_textbox.Multiline = true;
            this.sp_textbox.Name = "sp_textbox";
            this.sp_textbox.Size = new System.Drawing.Size(346, 113);
            this.sp_textbox.TabIndex = 11;
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(227, 254);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(346, 23);
            this.generate_button.TabIndex = 12;
            this.generate_button.Text = "Сгенерировать";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(227, 415);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(346, 23);
            this.calc_button.TabIndex = 15;
            this.calc_button.Text = "Вычислить";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // np_textbox
            // 
            this.np_textbox.Location = new System.Drawing.Point(227, 296);
            this.np_textbox.Multiline = true;
            this.np_textbox.Name = "np_textbox";
            this.np_textbox.Size = new System.Drawing.Size(346, 113);
            this.np_textbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Нормальная последовательность";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.np_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.sp_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exectime_textbox);
            this.Controls.Add(this.decode_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.encode_button);
            this.Controls.Add(this.label1);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decode_button;
        private System.Windows.Forms.TextBox exectime_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox output_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sp_textbox;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.TextBox np_textbox;
        private System.Windows.Forms.Label label5;
    }
}

