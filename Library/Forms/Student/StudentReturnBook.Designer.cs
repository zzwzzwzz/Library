﻿namespace Library
{
    partial class StudentReturnBook
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
            button1 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(478, 394);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(169, 59);
            button1.TabIndex = 37;
            button1.Text = "Back";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(256, 394);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(169, 59);
            button4.TabIndex = 36;
            button4.Text = "Confirm";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 107);
            label1.Name = "label1";
            label1.Size = new Size(571, 54);
            label1.TabIndex = 35;
            label1.Text = "Student Return Book by BookID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(409, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 32);
            textBox1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label2.Location = new Point(258, 226);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 33;
            label2.Text = "Book ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label3.Location = new Point(258, 309);
            label3.Name = "label3";
            label3.Size = new Size(129, 30);
            label3.TabIndex = 39;
            label3.Text = "Return Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(409, 309);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 32);
            dateTimePicker1.TabIndex = 38;
            // 
            // StudentReturnBook
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "StudentReturnBook";
            Text = "StudentReturnBook";
            Load += StudentReturnBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button4;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}