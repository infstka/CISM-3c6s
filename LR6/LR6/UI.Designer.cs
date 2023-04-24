namespace LR6
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
            this.LRotor_combobox = new System.Windows.Forms.ComboBox();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.reflector_combobox = new System.Windows.Forms.TextBox();
            this.LRotor_label = new System.Windows.Forms.Label();
            this.MRotor_label = new System.Windows.Forms.Label();
            this.RRotor_label = new System.Windows.Forms.Label();
            this.MRotor_combobox = new System.Windows.Forms.ComboBox();
            this.RRotor_combobox = new System.Windows.Forms.ComboBox();
            this.reflector_label = new System.Windows.Forms.Label();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.input_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LRotor_combobox
            // 
            this.LRotor_combobox.FormattingEnabled = true;
            this.LRotor_combobox.Items.AddRange(new object[] {
            "e",
            "s",
            "o",
            "v",
            "p",
            "z",
            "j",
            "a",
            "y",
            "q",
            "u",
            "i",
            "r",
            "h",
            "x",
            "l",
            "n",
            "f",
            "t",
            "g",
            "k",
            "d",
            "c",
            "m",
            "w",
            "b"});
            this.LRotor_combobox.Location = new System.Drawing.Point(234, 25);
            this.LRotor_combobox.Name = "LRotor_combobox";
            this.LRotor_combobox.Size = new System.Drawing.Size(215, 21);
            this.LRotor_combobox.TabIndex = 1;
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(234, 171);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(215, 23);
            this.encrypt_button.TabIndex = 2;
            this.encrypt_button.Text = "Зашифровать";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // reflector_combobox
            // 
            this.reflector_combobox.Location = new System.Drawing.Point(234, 145);
            this.reflector_combobox.Name = "reflector_combobox";
            this.reflector_combobox.ReadOnly = true;
            this.reflector_combobox.Size = new System.Drawing.Size(215, 20);
            this.reflector_combobox.TabIndex = 3;
            this.reflector_combobox.Text = "C Dunn";
            // 
            // LRotor_label
            // 
            this.LRotor_label.AutoSize = true;
            this.LRotor_label.Location = new System.Drawing.Point(233, 9);
            this.LRotor_label.Name = "LRotor_label";
            this.LRotor_label.Size = new System.Drawing.Size(65, 13);
            this.LRotor_label.TabIndex = 4;
            this.LRotor_label.Text = "Ротор L - IV";
            // 
            // MRotor_label
            // 
            this.MRotor_label.AutoSize = true;
            this.MRotor_label.Location = new System.Drawing.Point(233, 49);
            this.MRotor_label.Name = "MRotor_label";
            this.MRotor_label.Size = new System.Drawing.Size(67, 13);
            this.MRotor_label.TabIndex = 5;
            this.MRotor_label.Text = "Ротор М - III";
            // 
            // RRotor_label
            // 
            this.RRotor_label.AutoSize = true;
            this.RRotor_label.Location = new System.Drawing.Point(233, 89);
            this.RRotor_label.Name = "RRotor_label";
            this.RRotor_label.Size = new System.Drawing.Size(63, 13);
            this.RRotor_label.TabIndex = 6;
            this.RRotor_label.Text = "Ротор R - II";
            // 
            // MRotor_combobox
            // 
            this.MRotor_combobox.FormattingEnabled = true;
            this.MRotor_combobox.Items.AddRange(new object[] {
            "b",
            "d",
            "f",
            "h",
            "j",
            "l",
            "c",
            "p",
            "r",
            "t",
            "x",
            "v",
            "z",
            "n",
            "y",
            "e",
            "i",
            "w",
            "g",
            "a",
            "k",
            "m",
            "u",
            "s",
            "q",
            "o"});
            this.MRotor_combobox.Location = new System.Drawing.Point(234, 65);
            this.MRotor_combobox.Name = "MRotor_combobox";
            this.MRotor_combobox.Size = new System.Drawing.Size(215, 21);
            this.MRotor_combobox.TabIndex = 7;
            // 
            // RRotor_combobox
            // 
            this.RRotor_combobox.FormattingEnabled = true;
            this.RRotor_combobox.Items.AddRange(new object[] {
            "a",
            "j",
            "d",
            "k",
            "s",
            "i",
            "r",
            "u",
            "x",
            "b",
            "l",
            "h",
            "w",
            "t",
            "m",
            "c",
            "q",
            "g",
            "z",
            "n",
            "p",
            "y",
            "f",
            "v",
            "o",
            "e"});
            this.RRotor_combobox.Location = new System.Drawing.Point(234, 105);
            this.RRotor_combobox.Name = "RRotor_combobox";
            this.RRotor_combobox.Size = new System.Drawing.Size(215, 21);
            this.RRotor_combobox.TabIndex = 8;
            // 
            // reflector_label
            // 
            this.reflector_label.AutoSize = true;
            this.reflector_label.Location = new System.Drawing.Point(233, 129);
            this.reflector_label.Name = "reflector_label";
            this.reflector_label.Size = new System.Drawing.Size(72, 13);
            this.reflector_label.TabIndex = 9;
            this.reflector_label.Text = "Отражатель ";
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 25);
            this.input_textbox.Multiline = true;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(215, 413);
            this.input_textbox.TabIndex = 11;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(12, 9);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(109, 13);
            this.input_label.TabIndex = 12;
            this.input_label.Text = "Введите сообщение";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(451, 9);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(59, 13);
            this.result_label.TabIndex = 15;
            this.result_label.Text = "Результат";
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(454, 25);
            this.result_textbox.Multiline = true;
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.Size = new System.Drawing.Size(215, 413);
            this.result_textbox.TabIndex = 17;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.reflector_label);
            this.Controls.Add(this.RRotor_combobox);
            this.Controls.Add(this.MRotor_combobox);
            this.Controls.Add(this.RRotor_label);
            this.Controls.Add(this.MRotor_label);
            this.Controls.Add(this.LRotor_label);
            this.Controls.Add(this.reflector_combobox);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.LRotor_combobox);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox LRotor_combobox;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.TextBox reflector_combobox;
        private System.Windows.Forms.Label LRotor_label;
        private System.Windows.Forms.Label MRotor_label;
        private System.Windows.Forms.Label RRotor_label;
        private System.Windows.Forms.ComboBox MRotor_combobox;
        private System.Windows.Forms.ComboBox RRotor_combobox;
        private System.Windows.Forms.Label reflector_label;
        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.TextBox result_textbox;
    }
}