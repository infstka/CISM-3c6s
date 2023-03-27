
namespace LR2
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
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.language = new System.Windows.Forms.ComboBox();
            this.ASCII = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.CheckBox();
            this.countButton = new System.Windows.Forms.Button();
            this.AlphabetBUL = new System.Windows.Forms.Label();
            this.Bulgarian = new System.Windows.Forms.TextBox();
            this.Polski = new System.Windows.Forms.TextBox();
            this.AlphabetPL = new System.Windows.Forms.Label();
            this.textBULBox = new System.Windows.Forms.TextBox();
            this.textPLBox = new System.Windows.Forms.TextBox();
            this.textBULButton = new System.Windows.Forms.Button();
            this.textPLButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBINBox = new System.Windows.Forms.TextBox();
            this.textBINButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chooseFileButton.Location = new System.Drawing.Point(15, 137);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(774, 23);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Choose file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.FileSelection_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.result.Location = new System.Drawing.Point(15, 193);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(774, 273);
            this.result.TabIndex = 1;
            this.result.Text = "";
            // 
            // language
            // 
            this.language.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.language.FormattingEnabled = true;
            this.language.Items.AddRange(new object[] {
            "Бинарный",
            "Польский",
            "Болгарский"});
            this.language.Location = new System.Drawing.Point(15, 110);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(774, 21);
            this.language.TabIndex = 2;
            this.language.SelectedIndexChanged += new System.EventHandler(this.language_Selection);
            // 
            // ASCII
            // 
            this.ASCII.AutoSize = true;
            this.ASCII.Checked = true;
            this.ASCII.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ASCII.Location = new System.Drawing.Point(651, 12);
            this.ASCII.Name = "ASCII";
            this.ASCII.Size = new System.Drawing.Size(53, 17);
            this.ASCII.TabIndex = 3;
            this.ASCII.Text = "ASCII";
            this.ASCII.UseVisualStyleBackColor = true;
            this.ASCII.Visible = false;
            this.ASCII.CheckedChanged += new System.EventHandler(this.invsbleASCII_CB);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Checked = true;
            this.error.CheckState = System.Windows.Forms.CheckState.Checked;
            this.error.Enabled = false;
            this.error.Location = new System.Drawing.Point(710, 12);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(66, 17);
            this.error.TabIndex = 4;
            this.error.Text = "Ошибки";
            this.error.UseVisualStyleBackColor = true;
            this.error.Visible = false;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(15, 166);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(774, 21);
            this.countButton.TabIndex = 5;
            this.countButton.Text = "Show result";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.count_Click);
            // 
            // AlphabetBUL
            // 
            this.AlphabetBUL.AutoSize = true;
            this.AlphabetBUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlphabetBUL.Location = new System.Drawing.Point(262, 9);
            this.AlphabetBUL.Name = "AlphabetBUL";
            this.AlphabetBUL.Size = new System.Drawing.Size(127, 17);
            this.AlphabetBUL.TabIndex = 15;
            this.AlphabetBUL.Text = "Bulgarian alphabet";
            // 
            // Bulgarian
            // 
            this.Bulgarian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bulgarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bulgarian.Location = new System.Drawing.Point(265, 29);
            this.Bulgarian.Multiline = true;
            this.Bulgarian.Name = "Bulgarian";
            this.Bulgarian.ReadOnly = true;
            this.Bulgarian.Size = new System.Drawing.Size(248, 20);
            this.Bulgarian.TabIndex = 14;
            this.Bulgarian.Text = "абвгдежзийклмнопрстуфхцчшщъьюя\r\n";
            // 
            // Polski
            // 
            this.Polski.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Polski.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Polski.Location = new System.Drawing.Point(15, 29);
            this.Polski.Multiline = true;
            this.Polski.Name = "Polski";
            this.Polski.ReadOnly = true;
            this.Polski.Size = new System.Drawing.Size(220, 20);
            this.Polski.TabIndex = 13;
            this.Polski.Text = "aąbcćdeęfghijklłmnńoóprsśtuwyzźż";
            // 
            // AlphabetPL
            // 
            this.AlphabetPL.AutoSize = true;
            this.AlphabetPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlphabetPL.Location = new System.Drawing.Point(12, 9);
            this.AlphabetPL.Name = "AlphabetPL";
            this.AlphabetPL.Size = new System.Drawing.Size(105, 17);
            this.AlphabetPL.TabIndex = 12;
            this.AlphabetPL.Text = "Polish alphabet";
            // 
            // textBULBox
            // 
            this.textBULBox.Location = new System.Drawing.Point(265, 55);
            this.textBULBox.Name = "textBULBox";
            this.textBULBox.Size = new System.Drawing.Size(248, 20);
            this.textBULBox.TabIndex = 11;
            // 
            // textPLBox
            // 
            this.textPLBox.Location = new System.Drawing.Point(15, 55);
            this.textPLBox.Name = "textPLBox";
            this.textPLBox.Size = new System.Drawing.Size(220, 20);
            this.textPLBox.TabIndex = 10;
            // 
            // textBULButton
            // 
            this.textBULButton.Location = new System.Drawing.Point(265, 81);
            this.textBULButton.Name = "textBULButton";
            this.textBULButton.Size = new System.Drawing.Size(248, 23);
            this.textBULButton.TabIndex = 9;
            this.textBULButton.Text = "Insert into \"textBUL.txt\"";
            this.textBULButton.UseVisualStyleBackColor = true;
            this.textBULButton.Click += new System.EventHandler(this.textBULButton_Click);
            // 
            // textPLButton
            // 
            this.textPLButton.Location = new System.Drawing.Point(15, 81);
            this.textPLButton.Name = "textPLButton";
            this.textPLButton.Size = new System.Drawing.Size(220, 23);
            this.textPLButton.TabIndex = 8;
            this.textPLButton.Text = "Insert into \"textPL.txt\"";
            this.textPLButton.UseVisualStyleBackColor = true;
            this.textPLButton.Click += new System.EventHandler(this.textPLButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(538, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Binary alphabet";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(541, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "10";
            // 
            // textBINBox
            // 
            this.textBINBox.Location = new System.Drawing.Point(541, 55);
            this.textBINBox.Name = "textBINBox";
            this.textBINBox.Size = new System.Drawing.Size(248, 20);
            this.textBINBox.TabIndex = 17;
            // 
            // textBINButton
            // 
            this.textBINButton.Location = new System.Drawing.Point(541, 81);
            this.textBINButton.Name = "textBINButton";
            this.textBINButton.Size = new System.Drawing.Size(248, 23);
            this.textBINButton.TabIndex = 16;
            this.textBINButton.Text = "Insert into \"textBIN.txt\"";
            this.textBINButton.UseVisualStyleBackColor = true;
            this.textBINButton.Click += new System.EventHandler(this.textBINButton_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBINBox);
            this.Controls.Add(this.textBINButton);
            this.Controls.Add(this.AlphabetBUL);
            this.Controls.Add(this.Bulgarian);
            this.Controls.Add(this.Polski);
            this.Controls.Add(this.AlphabetPL);
            this.Controls.Add(this.textBULBox);
            this.Controls.Add(this.textPLBox);
            this.Controls.Add(this.textBULButton);
            this.Controls.Add(this.textPLButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.error);
            this.Controls.Add(this.ASCII);
            this.Controls.Add(this.language);
            this.Controls.Add(this.result);
            this.Controls.Add(this.chooseFileButton);
            this.MaximumSize = new System.Drawing.Size(817, 514);
            this.MinimumSize = new System.Drawing.Size(817, 514);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.CheckBox ASCII;
        private System.Windows.Forms.CheckBox error;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label AlphabetBUL;
        private System.Windows.Forms.TextBox Bulgarian;
        private System.Windows.Forms.TextBox Polski;
        private System.Windows.Forms.Label AlphabetPL;
        private System.Windows.Forms.TextBox textBULBox;
        private System.Windows.Forms.TextBox textPLBox;
        private System.Windows.Forms.Button textBULButton;
        private System.Windows.Forms.Button textPLButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBINBox;
        private System.Windows.Forms.Button textBINButton;
    }
}

