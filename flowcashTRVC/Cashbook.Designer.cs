﻿namespace flowcashTRVC
{
    partial class Cashbook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayKindCash = new System.Windows.Forms.Label();
            this.cbbKindCach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerCash = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.insertCashBook = new System.Windows.Forms.Button();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.displayBalance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.displayKindCash);
            this.panel1.Controls.Add(this.cbbKindCach);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePickerCash);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 198);
            this.panel1.TabIndex = 0;
            // 
            // displayBalance
            // 
            this.displayBalance.AutoSize = true;
            this.displayBalance.Location = new System.Drawing.Point(447, 124);
            this.displayBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayBalance.Name = "displayBalance";
            this.displayBalance.Size = new System.Drawing.Size(46, 16);
            this.displayBalance.TabIndex = 18;
            this.displayBalance.Text = "Defaut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Balance";
            // 
            // displayKindCash
            // 
            this.displayKindCash.AutoSize = true;
            this.displayKindCash.Location = new System.Drawing.Point(89, 55);
            this.displayKindCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayKindCash.Name = "displayKindCash";
            this.displayKindCash.Size = new System.Drawing.Size(46, 16);
            this.displayKindCash.TabIndex = 15;
            this.displayKindCash.Text = "Defaut";
            this.displayKindCash.TextChanged += new System.EventHandler(this.label8_TextChanged);
            this.displayKindCash.Click += new System.EventHandler(this.maCash_Click);
            // 
            // cbbKindCach
            // 
            this.cbbKindCach.FormattingEnabled = true;
            this.cbbKindCach.Items.AddRange(new object[] {
            "H15-795-011595"});
            this.cbbKindCach.Location = new System.Drawing.Point(93, 9);
            this.cbbKindCach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbKindCach.Name = "cbbKindCach";
            this.cbbKindCach.Size = new System.Drawing.Size(160, 24);
            this.cbbKindCach.TabIndex = 1;
            this.cbbKindCach.Tag = "Cash";
            this.cbbKindCach.Text = "Cash";
            this.cbbKindCach.DropDown += new System.EventHandler(this.comboKindcash_DropDown);
            this.cbbKindCach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbbKindCach.SelectedValueChanged += new System.EventHandler(this.cbbKindCach_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ma";
            // 
            // dateTimePickerCash
            // 
            this.dateTimePickerCash.Location = new System.Drawing.Point(93, 91);
            this.dateTimePickerCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerCash.Name = "dateTimePickerCash";
            this.dateTimePickerCash.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerCash.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Payment";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(451, 55);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 22);
            this.textBox6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Income";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(451, 12);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 22);
            this.textBox5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Decscription";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 140);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kind";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnPrinter);
            this.panel2.Controls.Add(this.insertCashBook);
            this.panel2.Location = new System.Drawing.Point(672, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 198);
            this.panel2.TabIndex = 1;
            // 
            // insertCashBook
            // 
            this.insertCashBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertCashBook.Location = new System.Drawing.Point(4, 9);
            this.insertCashBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertCashBook.Name = "insertCashBook";
            this.insertCashBook.Size = new System.Drawing.Size(100, 28);
            this.insertCashBook.TabIndex = 0;
            this.insertCashBook.Text = "Insert";
            this.insertCashBook.UseVisualStyleBackColor = false;
            this.insertCashBook.Click += new System.EventHandler(this.insertCashBook_Click);
            // 
            // btnPrinter
            // 
            this.btnPrinter.Location = new System.Drawing.Point(112, 10);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(75, 23);
            this.btnPrinter.TabIndex = 1;
            this.btnPrinter.Text = "printer";
            this.btnPrinter.UseVisualStyleBackColor = true;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // Cashbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cashbook";
            this.Text = "Cashbook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePickerCash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbKindCach;
        private System.Windows.Forms.Label displayKindCash;
        private System.Windows.Forms.Label displayBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button insertCashBook;
        private System.Windows.Forms.Button btnPrinter;
    }
}