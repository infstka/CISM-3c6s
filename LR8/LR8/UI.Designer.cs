namespace LR8
{
    partial class UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encode_button = new System.Windows.Forms.Button();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.decode_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exectime_textbox = new System.Windows.Forms.TextBox();
            this.psp_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bbs_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
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
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 25);
            this.input_textbox.Multiline = true;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(188, 413);
            this.input_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Результат";
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(206, 25);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(201, 23);
            this.encode_button.TabIndex = 3;
            this.encode_button.Text = "Зашифровать";
            this.encode_button.UseVisualStyleBackColor = true;
            this.encode_button.Click += new System.EventHandler(this.encode_button_Click);
            // 
            // output_textbox
            // 
            this.output_textbox.Location = new System.Drawing.Point(413, 25);
            this.output_textbox.Multiline = true;
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.Size = new System.Drawing.Size(188, 413);
            this.output_textbox.TabIndex = 4;
            // 
            // decode_button
            // 
            this.decode_button.Location = new System.Drawing.Point(206, 54);
            this.decode_button.Name = "decode_button";
            this.decode_button.Size = new System.Drawing.Size(201, 23);
            this.decode_button.TabIndex = 5;
            this.decode_button.Text = "Расшифровать";
            this.decode_button.UseVisualStyleBackColor = true;
            this.decode_button.Click += new System.EventHandler(this.decode_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время выполнения";
            // 
            // exectime_textbox
            // 
            this.exectime_textbox.Location = new System.Drawing.Point(206, 96);
            this.exectime_textbox.Name = "exectime_textbox";
            this.exectime_textbox.Size = new System.Drawing.Size(201, 20);
            this.exectime_textbox.TabIndex = 7;
            // 
            // psp_textbox
            // 
            this.psp_textbox.Location = new System.Drawing.Point(206, 361);
            this.psp_textbox.Multiline = true;
            this.psp_textbox.Name = "psp_textbox";
            this.psp_textbox.Size = new System.Drawing.Size(201, 48);
            this.psp_textbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ПСП";
            // 
            // bbs_textbox
            // 
            this.bbs_textbox.Location = new System.Drawing.Point(206, 135);
            this.bbs_textbox.Multiline = true;
            this.bbs_textbox.Name = "bbs_textbox";
            this.bbs_textbox.Size = new System.Drawing.Size(201, 207);
            this.bbs_textbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "BBS";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(206, 415);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(201, 23);
            this.clear_button.TabIndex = 13;
            this.clear_button.Text = "Очистить все";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.bbs_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.psp_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exectime_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decode_button);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.encode_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.label1);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.TextBox output_textbox;
        private System.Windows.Forms.Button decode_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exectime_textbox;
        private System.Windows.Forms.TextBox psp_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bbs_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear_button;
    }
}