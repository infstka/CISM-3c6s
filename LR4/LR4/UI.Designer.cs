namespace LR4
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
            this.encode_button = new System.Windows.Forms.Button();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.cipher_combobox = new System.Windows.Forms.ComboBox();
            this.encode_decode_label = new System.Windows.Forms.Label();
            this.decode_button = new System.Windows.Forms.Button();
            this.key_textbox = new System.Windows.Forms.TextBox();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cipher_label = new System.Windows.Forms.Label();
            this.key_label = new System.Windows.Forms.Label();
            this.execTime_label = new System.Windows.Forms.Label();
            this.execTime_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(288, 48);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(93, 23);
            this.encode_button.TabIndex = 0;
            this.encode_button.Text = "Зашифровать";
            this.encode_button.UseVisualStyleBackColor = true;
            this.encode_button.Click += new System.EventHandler(this.encode_button_Click);
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 25);
            this.input_textbox.Multiline = true;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input_textbox.Size = new System.Drawing.Size(267, 413);
            this.input_textbox.TabIndex = 1;
            // 
            // cipher_combobox
            // 
            this.cipher_combobox.FormattingEnabled = true;
            this.cipher_combobox.Items.AddRange(new object[] {
            "Шифр 1",
            "Шифр 2"});
            this.cipher_combobox.Location = new System.Drawing.Point(288, 25);
            this.cipher_combobox.Name = "cipher_combobox";
            this.cipher_combobox.Size = new System.Drawing.Size(192, 21);
            this.cipher_combobox.TabIndex = 2;
            this.cipher_combobox.SelectedIndexChanged += new System.EventHandler(this.cipher_combobox_SelectedIndexChanged);
            // 
            // encode_decode_label
            // 
            this.encode_decode_label.AutoSize = true;
            this.encode_decode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encode_decode_label.Location = new System.Drawing.Point(12, 9);
            this.encode_decode_label.Name = "encode_decode_label";
            this.encode_decode_label.Size = new System.Drawing.Size(267, 13);
            this.encode_decode_label.TabIndex = 3;
            this.encode_decode_label.Text = "Введите текст для зашифрования/расшифрования";
            // 
            // decode_button
            // 
            this.decode_button.Location = new System.Drawing.Point(387, 48);
            this.decode_button.Name = "decode_button";
            this.decode_button.Size = new System.Drawing.Size(93, 23);
            this.decode_button.TabIndex = 4;
            this.decode_button.Text = "Расшифровать";
            this.decode_button.UseVisualStyleBackColor = true;
            this.decode_button.Click += new System.EventHandler(this.decode_button_Click);
            // 
            // key_textbox
            // 
            this.key_textbox.Location = new System.Drawing.Point(288, 129);
            this.key_textbox.Name = "key_textbox";
            this.key_textbox.Size = new System.Drawing.Size(192, 20);
            this.key_textbox.TabIndex = 5;
            this.key_textbox.Visible = false;
            // 
            // output_textbox
            // 
            this.output_textbox.Location = new System.Drawing.Point(486, 25);
            this.output_textbox.Multiline = true;
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.ReadOnly = true;
            this.output_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_textbox.Size = new System.Drawing.Size(267, 413);
            this.output_textbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результат";
            // 
            // cipher_label
            // 
            this.cipher_label.AutoSize = true;
            this.cipher_label.Location = new System.Drawing.Point(285, 9);
            this.cipher_label.Name = "cipher_label";
            this.cipher_label.Size = new System.Drawing.Size(88, 13);
            this.cipher_label.TabIndex = 8;
            this.cipher_label.Text = "Выберите шифр";
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Location = new System.Drawing.Point(285, 113);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(90, 13);
            this.key_label.TabIndex = 9;
            this.key_label.Text = "Ключевое слово";
            this.key_label.Visible = false;
            // 
            // execTime_label
            // 
            this.execTime_label.AutoSize = true;
            this.execTime_label.Location = new System.Drawing.Point(285, 74);
            this.execTime_label.Name = "execTime_label";
            this.execTime_label.Size = new System.Drawing.Size(105, 13);
            this.execTime_label.TabIndex = 11;
            this.execTime_label.Text = "Время выполнения";
            // 
            // execTime_textbox
            // 
            this.execTime_textbox.Location = new System.Drawing.Point(288, 90);
            this.execTime_textbox.Name = "execTime_textbox";
            this.execTime_textbox.Size = new System.Drawing.Size(192, 20);
            this.execTime_textbox.TabIndex = 10;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.execTime_label);
            this.Controls.Add(this.execTime_textbox);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.cipher_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.key_textbox);
            this.Controls.Add(this.decode_button);
            this.Controls.Add(this.encode_decode_label);
            this.Controls.Add(this.cipher_combobox);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.encode_button);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.ComboBox cipher_combobox;
        private System.Windows.Forms.Label encode_decode_label;
        private System.Windows.Forms.Button decode_button;
        private System.Windows.Forms.TextBox key_textbox;
        private System.Windows.Forms.TextBox output_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cipher_label;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.Label execTime_label;
        private System.Windows.Forms.TextBox execTime_textbox;
    }
}