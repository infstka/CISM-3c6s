namespace LR5
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
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.NOS_textbox = new System.Windows.Forms.TextBox();
            this.time_textbox = new System.Windows.Forms.TextBox();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.permutation_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NOS_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.table_textbox = new System.Windows.Forms.TextBox();
            this.table_label = new System.Windows.Forms.Label();
            this.letter_textbox = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 25);
            this.input_textbox.Multiline = true;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input_textbox.Size = new System.Drawing.Size(227, 412);
            this.input_textbox.TabIndex = 0;
            // 
            // NOS_textbox
            // 
            this.NOS_textbox.Location = new System.Drawing.Point(245, 133);
            this.NOS_textbox.Name = "NOS_textbox";
            this.NOS_textbox.Size = new System.Drawing.Size(194, 20);
            this.NOS_textbox.TabIndex = 1;
            this.NOS_textbox.Visible = false;
            // 
            // time_textbox
            // 
            this.time_textbox.Location = new System.Drawing.Point(245, 65);
            this.time_textbox.Name = "time_textbox";
            this.time_textbox.Size = new System.Drawing.Size(194, 20);
            this.time_textbox.TabIndex = 2;
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(245, 91);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(91, 23);
            this.decrypt_button.TabIndex = 3;
            this.decrypt_button.Text = "Зашифровать";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // permutation_combobox
            // 
            this.permutation_combobox.FormattingEnabled = true;
            this.permutation_combobox.Items.AddRange(new object[] {
            "Route",
            "Multiple"});
            this.permutation_combobox.Location = new System.Drawing.Point(245, 25);
            this.permutation_combobox.Name = "permutation_combobox";
            this.permutation_combobox.Size = new System.Drawing.Size(194, 21);
            this.permutation_combobox.TabIndex = 5;
            this.permutation_combobox.SelectedIndexChanged += new System.EventHandler(this.choose_permutation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите текст";
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(445, 25);
            this.result_textbox.Multiline = true;
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_textbox.Size = new System.Drawing.Size(227, 412);
            this.result_textbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выберите вид перестановки";
            // 
            // NOS_label
            // 
            this.NOS_label.AutoSize = true;
            this.NOS_label.Location = new System.Drawing.Point(242, 117);
            this.NOS_label.Name = "NOS_label";
            this.NOS_label.Size = new System.Drawing.Size(142, 13);
            this.NOS_label.TabIndex = 10;
            this.NOS_label.Text = "Введите количество строк";
            this.NOS_label.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Время выполнения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Частоты букв";
            // 
            // table_textbox
            // 
            this.table_textbox.Location = new System.Drawing.Point(681, 247);
            this.table_textbox.Multiline = true;
            this.table_textbox.Name = "table_textbox";
            this.table_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.table_textbox.Size = new System.Drawing.Size(227, 190);
            this.table_textbox.TabIndex = 14;
            this.table_textbox.Visible = false;
            // 
            // table_label
            // 
            this.table_label.AutoSize = true;
            this.table_label.Location = new System.Drawing.Point(678, 231);
            this.table_label.Name = "table_label";
            this.table_label.Size = new System.Drawing.Size(50, 13);
            this.table_label.TabIndex = 15;
            this.table_label.Text = "Таблица";
            this.table_label.Visible = false;
            // 
            // letter_textbox
            // 
            this.letter_textbox.Location = new System.Drawing.Point(681, 25);
            this.letter_textbox.Multiline = true;
            this.letter_textbox.Name = "letter_textbox";
            this.letter_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.letter_textbox.Size = new System.Drawing.Size(227, 190);
            this.letter_textbox.TabIndex = 16;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(245, 160);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(194, 23);
            this.clear_button.TabIndex = 17;
            this.clear_button.Text = "Clear all";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.letter_textbox);
            this.Controls.Add(this.table_label);
            this.Controls.Add(this.table_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NOS_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.permutation_combobox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.time_textbox);
            this.Controls.Add(this.NOS_textbox);
            this.Controls.Add(this.input_textbox);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.TextBox NOS_textbox;
        private System.Windows.Forms.TextBox time_textbox;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox permutation_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NOS_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox table_textbox;
        private System.Windows.Forms.Label table_label;
        private System.Windows.Forms.TextBox letter_textbox;
        private System.Windows.Forms.Button clear_button;
    }
}