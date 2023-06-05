namespace task2
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
            this.RSA_Input = new System.Windows.Forms.TextBox();
            this.RSA_Encode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RSA_Output = new System.Windows.Forms.TextBox();
            this.RSA_Decode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RSA_DecodedRes = new System.Windows.Forms.TextBox();
            this.ExecTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EG_DecodedRes = new System.Windows.Forms.TextBox();
            this.EG_Decode = new System.Windows.Forms.Button();
            this.EG_Output = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EG_Encode = new System.Windows.Forms.Button();
            this.EG_Input = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.p_input = new System.Windows.Forms.TextBox();
            this.q_input = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EG_text = new System.Windows.Forms.Label();
            this.El_Gamal_info = new System.Windows.Forms.TextBox();
            this.Clear_All = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA";
            // 
            // RSA_Input
            // 
            this.RSA_Input.Location = new System.Drawing.Point(11, 53);
            this.RSA_Input.Multiline = true;
            this.RSA_Input.Name = "RSA_Input";
            this.RSA_Input.Size = new System.Drawing.Size(217, 80);
            this.RSA_Input.TabIndex = 1;
            // 
            // RSA_Encode
            // 
            this.RSA_Encode.Location = new System.Drawing.Point(11, 139);
            this.RSA_Encode.Name = "RSA_Encode";
            this.RSA_Encode.Size = new System.Drawing.Size(217, 23);
            this.RSA_Encode.TabIndex = 2;
            this.RSA_Encode.Text = "Зашифровать";
            this.RSA_Encode.UseVisualStyleBackColor = true;
            this.RSA_Encode.Click += new System.EventHandler(this.RSA_Encode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите сообщение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зашифрованное сообщение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Время выполнения";
            // 
            // RSA_Output
            // 
            this.RSA_Output.Location = new System.Drawing.Point(11, 181);
            this.RSA_Output.Multiline = true;
            this.RSA_Output.Name = "RSA_Output";
            this.RSA_Output.Size = new System.Drawing.Size(217, 80);
            this.RSA_Output.TabIndex = 10;
            // 
            // RSA_Decode
            // 
            this.RSA_Decode.Location = new System.Drawing.Point(11, 267);
            this.RSA_Decode.Name = "RSA_Decode";
            this.RSA_Decode.Size = new System.Drawing.Size(217, 23);
            this.RSA_Decode.TabIndex = 11;
            this.RSA_Decode.Text = "Расшифровать";
            this.RSA_Decode.UseVisualStyleBackColor = true;
            this.RSA_Decode.Click += new System.EventHandler(this.RSA_Decode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Результат";
            // 
            // RSA_DecodedRes
            // 
            this.RSA_DecodedRes.Location = new System.Drawing.Point(11, 309);
            this.RSA_DecodedRes.Multiline = true;
            this.RSA_DecodedRes.Name = "RSA_DecodedRes";
            this.RSA_DecodedRes.Size = new System.Drawing.Size(217, 80);
            this.RSA_DecodedRes.TabIndex = 12;
            // 
            // ExecTime
            // 
            this.ExecTime.Location = new System.Drawing.Point(234, 142);
            this.ExecTime.Multiline = true;
            this.ExecTime.Name = "ExecTime";
            this.ExecTime.Size = new System.Drawing.Size(232, 20);
            this.ExecTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Результат";
            // 
            // EG_DecodedRes
            // 
            this.EG_DecodedRes.Location = new System.Drawing.Point(472, 309);
            this.EG_DecodedRes.Multiline = true;
            this.EG_DecodedRes.Name = "EG_DecodedRes";
            this.EG_DecodedRes.Size = new System.Drawing.Size(217, 80);
            this.EG_DecodedRes.TabIndex = 22;
            // 
            // EG_Decode
            // 
            this.EG_Decode.Location = new System.Drawing.Point(472, 267);
            this.EG_Decode.Name = "EG_Decode";
            this.EG_Decode.Size = new System.Drawing.Size(217, 23);
            this.EG_Decode.TabIndex = 21;
            this.EG_Decode.Text = "Расшифровать";
            this.EG_Decode.UseVisualStyleBackColor = true;
            this.EG_Decode.Click += new System.EventHandler(this.EG_Decrypt_Click);
            // 
            // EG_Output
            // 
            this.EG_Output.Location = new System.Drawing.Point(472, 181);
            this.EG_Output.Multiline = true;
            this.EG_Output.Name = "EG_Output";
            this.EG_Output.Size = new System.Drawing.Size(217, 80);
            this.EG_Output.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Зашифрованное сообщение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Введите сообщение";
            // 
            // EG_Encode
            // 
            this.EG_Encode.Location = new System.Drawing.Point(472, 139);
            this.EG_Encode.Name = "EG_Encode";
            this.EG_Encode.Size = new System.Drawing.Size(217, 23);
            this.EG_Encode.TabIndex = 17;
            this.EG_Encode.Text = "Зашифровать";
            this.EG_Encode.UseVisualStyleBackColor = true;
            this.EG_Encode.Click += new System.EventHandler(this.EG_Encode_Click);
            // 
            // EG_Input
            // 
            this.EG_Input.Location = new System.Drawing.Point(472, 53);
            this.EG_Input.Multiline = true;
            this.EG_Input.Name = "EG_Input";
            this.EG_Input.Size = new System.Drawing.Size(217, 80);
            this.EG_Input.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "El-Gamal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Введите p";
            // 
            // p_input
            // 
            this.p_input.Location = new System.Drawing.Point(234, 53);
            this.p_input.Multiline = true;
            this.p_input.Name = "p_input";
            this.p_input.Size = new System.Drawing.Size(232, 20);
            this.p_input.TabIndex = 25;
            // 
            // q_input
            // 
            this.q_input.Location = new System.Drawing.Point(234, 90);
            this.q_input.Multiline = true;
            this.q_input.Name = "q_input";
            this.q_input.Size = new System.Drawing.Size(232, 20);
            this.q_input.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Введите q";
            // 
            // EG_text
            // 
            this.EG_text.AutoSize = true;
            this.EG_text.Location = new System.Drawing.Point(234, 165);
            this.EG_text.Name = "EG_text";
            this.EG_text.Size = new System.Drawing.Size(69, 13);
            this.EG_text.TabIndex = 28;
            this.EG_text.Text = "El-Gamal info";
            this.EG_text.Visible = false;
            // 
            // El_Gamal_info
            // 
            this.El_Gamal_info.Location = new System.Drawing.Point(234, 181);
            this.El_Gamal_info.Multiline = true;
            this.El_Gamal_info.Name = "El_Gamal_info";
            this.El_Gamal_info.Size = new System.Drawing.Size(232, 80);
            this.El_Gamal_info.TabIndex = 29;
            this.El_Gamal_info.Visible = false;
            // 
            // Clear_All
            // 
            this.Clear_All.Location = new System.Drawing.Point(234, 267);
            this.Clear_All.Name = "Clear_All";
            this.Clear_All.Size = new System.Drawing.Size(229, 23);
            this.Clear_All.TabIndex = 30;
            this.Clear_All.Text = "Очистить все";
            this.Clear_All.UseVisualStyleBackColor = true;
            this.Clear_All.Click += new System.EventHandler(this.Clear_All_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 398);
            this.Controls.Add(this.Clear_All);
            this.Controls.Add(this.El_Gamal_info);
            this.Controls.Add(this.EG_text);
            this.Controls.Add(this.q_input);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.p_input);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EG_DecodedRes);
            this.Controls.Add(this.EG_Decode);
            this.Controls.Add(this.EG_Output);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EG_Encode);
            this.Controls.Add(this.EG_Input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExecTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RSA_DecodedRes);
            this.Controls.Add(this.RSA_Decode);
            this.Controls.Add(this.RSA_Output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RSA_Encode);
            this.Controls.Add(this.RSA_Input);
            this.Controls.Add(this.label1);
            this.Name = "UI";
            this.Text = "LR10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RSA_Input;
        private System.Windows.Forms.Button RSA_Encode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RSA_Output;
        private System.Windows.Forms.Button RSA_Decode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RSA_DecodedRes;
        private System.Windows.Forms.TextBox ExecTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EG_DecodedRes;
        private System.Windows.Forms.Button EG_Decode;
        private System.Windows.Forms.TextBox EG_Output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EG_Encode;
        private System.Windows.Forms.TextBox EG_Input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox p_input;
        private System.Windows.Forms.TextBox q_input;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label EG_text;
        private System.Windows.Forms.TextBox El_Gamal_info;
        private System.Windows.Forms.Button Clear_All;
    }
}

