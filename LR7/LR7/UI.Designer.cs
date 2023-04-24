namespace LR7
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
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.encode_button = new System.Windows.Forms.Button();
            this.key2_textbox = new System.Windows.Forms.TextBox();
            this.key1_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.decode_button = new System.Windows.Forms.Button();
            this.execTime_label = new System.Windows.Forms.Label();
            this.execTime_textbox = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сообщение";
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(13, 30);
            this.input_textbox.Multiline = true;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(210, 408);
            this.input_textbox.TabIndex = 1;
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(229, 135);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(216, 23);
            this.encode_button.TabIndex = 2;
            this.encode_button.Text = "Зашифровать";
            this.encode_button.UseVisualStyleBackColor = true;
            this.encode_button.Click += new System.EventHandler(this.encode_button_Click);
            // 
            // key2_textbox
            // 
            this.key2_textbox.Location = new System.Drawing.Point(229, 69);
            this.key2_textbox.Name = "key2_textbox";
            this.key2_textbox.Size = new System.Drawing.Size(216, 20);
            this.key2_textbox.TabIndex = 3;
            // 
            // key1_textbox
            // 
            this.key1_textbox.Location = new System.Drawing.Point(229, 30);
            this.key1_textbox.Name = "key1_textbox";
            this.key1_textbox.Size = new System.Drawing.Size(216, 20);
            this.key1_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Первый ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Второй ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат";
            // 
            // output_textbox
            // 
            this.output_textbox.Location = new System.Drawing.Point(451, 30);
            this.output_textbox.Multiline = true;
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.Size = new System.Drawing.Size(210, 408);
            this.output_textbox.TabIndex = 8;
            // 
            // decode_button
            // 
            this.decode_button.Location = new System.Drawing.Point(229, 164);
            this.decode_button.Name = "decode_button";
            this.decode_button.Size = new System.Drawing.Size(216, 23);
            this.decode_button.TabIndex = 9;
            this.decode_button.Text = "Расшифровать";
            this.decode_button.UseVisualStyleBackColor = true;
            this.decode_button.Click += new System.EventHandler(this.decode_button_Click);
            // 
            // execTime_label
            // 
            this.execTime_label.AutoSize = true;
            this.execTime_label.Location = new System.Drawing.Point(229, 92);
            this.execTime_label.Name = "execTime_label";
            this.execTime_label.Size = new System.Drawing.Size(105, 13);
            this.execTime_label.TabIndex = 10;
            this.execTime_label.Text = "Время выполнения";
            // 
            // execTime_textbox
            // 
            this.execTime_textbox.Location = new System.Drawing.Point(229, 109);
            this.execTime_textbox.Name = "execTime_textbox";
            this.execTime_textbox.Size = new System.Drawing.Size(216, 20);
            this.execTime_textbox.TabIndex = 11;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(229, 193);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(216, 23);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "Очистить все";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.execTime_textbox);
            this.Controls.Add(this.execTime_label);
            this.Controls.Add(this.decode_button);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key1_textbox);
            this.Controls.Add(this.key2_textbox);
            this.Controls.Add(this.encode_button);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.label1);
            this.Name = "UI";
            this.Text = "LR7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.TextBox key2_textbox;
        private System.Windows.Forms.TextBox key1_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox output_textbox;
        private System.Windows.Forms.Button decode_button;
        private System.Windows.Forms.Label execTime_label;
        private System.Windows.Forms.TextBox execTime_textbox;
        private System.Windows.Forms.Button clear_button;
    }
}

