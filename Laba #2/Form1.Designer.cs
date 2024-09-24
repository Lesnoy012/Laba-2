namespace Laba__2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_left = new System.Windows.Forms.Button();
            this.textBox_index_Optim = new System.Windows.Forms.TextBox();
            this.textBox_time_Optim = new System.Windows.Forms.TextBox();
            this.textBox_index_NeOptim = new System.Windows.Forms.TextBox();
            this.textBox_time_NeOptim = new System.Windows.Forms.TextBox();
            this.input_key_NeOptim = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_right = new System.Windows.Forms.Button();
            this.textBox_index_sorted = new System.Windows.Forms.TextBox();
            this.textBox_time_sorted = new System.Windows.Forms.TextBox();
            this.textBox_index_unsorted = new System.Windows.Forms.TextBox();
            this.textBox_time_unsorted = new System.Windows.Forms.TextBox();
            this.input_key_sorted = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_key_NeOptim)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_key_sorted)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная работа №2";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-5, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 64);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Неупорядоченный массив";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(212, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 64);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Упорядоченный массив";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_left);
            this.panel4.Controls.Add(this.textBox_index_Optim);
            this.panel4.Controls.Add(this.textBox_time_Optim);
            this.panel4.Controls.Add(this.textBox_index_NeOptim);
            this.panel4.Controls.Add(this.textBox_time_NeOptim);
            this.panel4.Controls.Add(this.input_key_NeOptim);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-5, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 339);
            this.panel4.TabIndex = 3;
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(53, 309);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 23);
            this.button_left.TabIndex = 16;
            this.button_left.Text = "Find";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // textBox_index_Optim
            // 
            this.textBox_index_Optim.Enabled = false;
            this.textBox_index_Optim.Location = new System.Drawing.Point(87, 265);
            this.textBox_index_Optim.Name = "textBox_index_Optim";
            this.textBox_index_Optim.Size = new System.Drawing.Size(121, 20);
            this.textBox_index_Optim.TabIndex = 15;
            // 
            // textBox_time_Optim
            // 
            this.textBox_time_Optim.Enabled = false;
            this.textBox_time_Optim.Location = new System.Drawing.Point(88, 230);
            this.textBox_time_Optim.Name = "textBox_time_Optim";
            this.textBox_time_Optim.Size = new System.Drawing.Size(120, 20);
            this.textBox_time_Optim.TabIndex = 14;
            // 
            // textBox_index_NeOptim
            // 
            this.textBox_index_NeOptim.Enabled = false;
            this.textBox_index_NeOptim.Location = new System.Drawing.Point(87, 129);
            this.textBox_index_NeOptim.Name = "textBox_index_NeOptim";
            this.textBox_index_NeOptim.Size = new System.Drawing.Size(121, 20);
            this.textBox_index_NeOptim.TabIndex = 13;
            // 
            // textBox_time_NeOptim
            // 
            this.textBox_time_NeOptim.Enabled = false;
            this.textBox_time_NeOptim.Location = new System.Drawing.Point(88, 95);
            this.textBox_time_NeOptim.Name = "textBox_time_NeOptim";
            this.textBox_time_NeOptim.Size = new System.Drawing.Size(120, 20);
            this.textBox_time_NeOptim.TabIndex = 12;
            // 
            // input_key_NeOptim
            // 
            this.input_key_NeOptim.Location = new System.Drawing.Point(88, 59);
            this.input_key_NeOptim.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.input_key_NeOptim.Name = "input_key_NeOptim";
            this.input_key_NeOptim.Size = new System.Drawing.Size(120, 20);
            this.input_key_NeOptim.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(26, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Индекс";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(26, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Время";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(22, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Оптимальный поиск";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(26, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Индекс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Время";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Неоптиамльный поиск";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button_right);
            this.panel5.Controls.Add(this.textBox_index_sorted);
            this.panel5.Controls.Add(this.textBox_time_sorted);
            this.panel5.Controls.Add(this.textBox_index_unsorted);
            this.panel5.Controls.Add(this.textBox_time_unsorted);
            this.panel5.Controls.Add(this.input_key_sorted);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(212, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 339);
            this.panel5.TabIndex = 4;
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(67, 309);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 23);
            this.button_right.TabIndex = 17;
            this.button_right.Text = "Find";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // textBox_index_sorted
            // 
            this.textBox_index_sorted.Enabled = false;
            this.textBox_index_sorted.Location = new System.Drawing.Point(79, 266);
            this.textBox_index_sorted.Name = "textBox_index_sorted";
            this.textBox_index_sorted.Size = new System.Drawing.Size(120, 20);
            this.textBox_index_sorted.TabIndex = 17;
            // 
            // textBox_time_sorted
            // 
            this.textBox_time_sorted.Enabled = false;
            this.textBox_time_sorted.Location = new System.Drawing.Point(79, 230);
            this.textBox_time_sorted.Name = "textBox_time_sorted";
            this.textBox_time_sorted.Size = new System.Drawing.Size(120, 20);
            this.textBox_time_sorted.TabIndex = 16;
            // 
            // textBox_index_unsorted
            // 
            this.textBox_index_unsorted.Enabled = false;
            this.textBox_index_unsorted.Location = new System.Drawing.Point(79, 129);
            this.textBox_index_unsorted.Name = "textBox_index_unsorted";
            this.textBox_index_unsorted.Size = new System.Drawing.Size(120, 20);
            this.textBox_index_unsorted.TabIndex = 15;
            // 
            // textBox_time_unsorted
            // 
            this.textBox_time_unsorted.Enabled = false;
            this.textBox_time_unsorted.Location = new System.Drawing.Point(79, 94);
            this.textBox_time_unsorted.Name = "textBox_time_unsorted";
            this.textBox_time_unsorted.Size = new System.Drawing.Size(120, 20);
            this.textBox_time_unsorted.TabIndex = 14;
            // 
            // input_key_sorted
            // 
            this.input_key_sorted.Location = new System.Drawing.Point(79, 59);
            this.input_key_sorted.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.input_key_sorted.Name = "input_key_sorted";
            this.input_key_sorted.Size = new System.Drawing.Size(120, 20);
            this.input_key_sorted.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(21, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 15);
            this.label17.TabIndex = 7;
            this.label17.Text = "Индекс";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(21, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "Время";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(10, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Как в упорядоченном";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(21, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "Индекс";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(21, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Время";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(21, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Ключ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Как в неупорядоченном";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button_exit);
            this.panel6.Location = new System.Drawing.Point(-5, 428);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(425, 61);
            this.panel6.TabIndex = 5;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(175, 9);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(417, 473);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ипатов В.М. 23ВП1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_key_NeOptim)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_key_sorted)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown input_key_sorted;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox textBox_index_NeOptim;
        private System.Windows.Forms.TextBox textBox_time_NeOptim;
        private System.Windows.Forms.NumericUpDown input_key_NeOptim;
        private System.Windows.Forms.TextBox textBox_index_Optim;
        private System.Windows.Forms.TextBox textBox_time_Optim;
        private System.Windows.Forms.TextBox textBox_time_unsorted;
        private System.Windows.Forms.TextBox textBox_index_unsorted;
        private System.Windows.Forms.TextBox textBox_index_sorted;
        private System.Windows.Forms.TextBox textBox_time_sorted;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
    }
}

