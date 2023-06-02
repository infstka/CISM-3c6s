namespace LR13
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
            this.task1 = new System.Windows.Forms.TextBox();
            this.task2 = new System.Windows.Forms.TextBox();
            this.task3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exec_task1 = new System.Windows.Forms.Button();
            this.exec_task2 = new System.Windows.Forms.Button();
            this.exec_task3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(12, 25);
            this.task1.Multiline = true;
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(157, 366);
            this.task1.TabIndex = 0;
            // 
            // task2
            // 
            this.task2.Location = new System.Drawing.Point(175, 25);
            this.task2.Multiline = true;
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(221, 366);
            this.task2.TabIndex = 1;
            // 
            // task3
            // 
            this.task3.Location = new System.Drawing.Point(402, 25);
            this.task3.Multiline = true;
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(157, 366);
            this.task3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Задание 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Задание 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Задание 3";
            // 
            // exec_task1
            // 
            this.exec_task1.Location = new System.Drawing.Point(12, 397);
            this.exec_task1.Name = "exec_task1";
            this.exec_task1.Size = new System.Drawing.Size(157, 23);
            this.exec_task1.TabIndex = 6;
            this.exec_task1.Text = "Выполнить task1";
            this.exec_task1.UseVisualStyleBackColor = true;
            this.exec_task1.Click += new System.EventHandler(this.exec_task1_Click);
            // 
            // exec_task2
            // 
            this.exec_task2.Location = new System.Drawing.Point(175, 397);
            this.exec_task2.Name = "exec_task2";
            this.exec_task2.Size = new System.Drawing.Size(221, 23);
            this.exec_task2.TabIndex = 7;
            this.exec_task2.Text = "Выполнить task2";
            this.exec_task2.UseVisualStyleBackColor = true;
            this.exec_task2.Click += new System.EventHandler(this.exec_task2_Click);
            // 
            // exec_task3
            // 
            this.exec_task3.Location = new System.Drawing.Point(402, 397);
            this.exec_task3.Name = "exec_task3";
            this.exec_task3.Size = new System.Drawing.Size(157, 23);
            this.exec_task3.TabIndex = 8;
            this.exec_task3.Text = "Выполнить task3";
            this.exec_task3.UseVisualStyleBackColor = true;
            this.exec_task3.Click += new System.EventHandler(this.exec_task3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 432);
            this.Controls.Add(this.exec_task3);
            this.Controls.Add(this.exec_task2);
            this.Controls.Add(this.exec_task1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox task1;
        private System.Windows.Forms.TextBox task2;
        private System.Windows.Forms.TextBox task3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exec_task1;
        private System.Windows.Forms.Button exec_task2;
        private System.Windows.Forms.Button exec_task3;
    }
}

