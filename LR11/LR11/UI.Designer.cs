namespace LR11
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
            this.execTime_textbox = new System.Windows.Forms.TextBox();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сообщение";
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(254, 55);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(220, 23);
            this.encode_button.TabIndex = 1;
            this.encode_button.Text = "Хешировать";
            this.encode_button.UseVisualStyleBackColor = true;
            this.encode_button.Click += new System.EventHandler(this.encode_button_Click);
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 29);
            this.input_textbox.Multiline = true;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(236, 409);
            this.input_textbox.TabIndex = 2;
            // 
            // execTime_textbox
            // 
            this.execTime_textbox.Location = new System.Drawing.Point(254, 29);
            this.execTime_textbox.Name = "execTime_textbox";
            this.execTime_textbox.Size = new System.Drawing.Size(220, 20);
            this.execTime_textbox.TabIndex = 3;
            // 
            // output_textbox
            // 
            this.output_textbox.Location = new System.Drawing.Point(480, 29);
            this.output_textbox.Multiline = true;
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.Size = new System.Drawing.Size(236, 409);
            this.output_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время выполнения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(254, 85);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(220, 23);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Очистить все";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.execTime_textbox);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.encode_button);
            this.Controls.Add(this.label1);
            this.Name = "UI";
            this.Text = "LR11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.TextBox execTime_textbox;
        private System.Windows.Forms.TextBox output_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear_button;
    }
}

