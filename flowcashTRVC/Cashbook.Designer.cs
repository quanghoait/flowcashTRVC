namespace flowcashTRVC
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
            this.lbMaCode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.bynshowCode = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.insertCashBook = new System.Windows.Forms.Button();
            this.dataViewCashBook = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCashBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbMaCode);
            this.panel1.Controls.Add(this.label9);
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
            this.panel1.Location = new System.Drawing.Point(12, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 198);
            this.panel1.TabIndex = 0;
            // 
            // lbMaCode
            // 
            this.lbMaCode.AutoSize = true;
            this.lbMaCode.Location = new System.Drawing.Point(663, 97);
            this.lbMaCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaCode.Name = "lbMaCode";
            this.lbMaCode.Size = new System.Drawing.Size(46, 16);
            this.lbMaCode.TabIndex = 20;
            this.lbMaCode.Text = "Defaut";
           
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "MaCode";
            // 
            // displayBalance
            // 
            this.displayBalance.AutoSize = true;
            this.displayBalance.Location = new System.Drawing.Point(661, 143);
            this.displayBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayBalance.Name = "displayBalance";
            this.displayBalance.Size = new System.Drawing.Size(46, 16);
            this.displayBalance.TabIndex = 18;
            this.displayBalance.Text = "Defaut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 143);
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
            this.displayKindCash.Size = new System.Drawing.Size(27, 16);
            this.displayKindCash.TabIndex = 15;
            this.displayKindCash.Text = "TM";
            this.displayKindCash.TextChanged += new System.EventHandler(this.label8_TextChanged);
            this.displayKindCash.Click += new System.EventHandler(this.maCash_Click);
            // 
            // cbbKindCach
            // 
            this.cbbKindCach.FormattingEnabled = true;
            this.cbbKindCach.Items.AddRange(new object[] {
            "H15-795-011595"});
            this.cbbKindCach.Location = new System.Drawing.Point(92, 9);
            this.cbbKindCach.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKindCach.Name = "cbbKindCach";
            this.cbbKindCach.Size = new System.Drawing.Size(160, 24);
            this.cbbKindCach.TabIndex = 1;
            this.cbbKindCach.Tag = "Cash";
            this.cbbKindCach.Text = "Cash";
            this.cbbKindCach.DropDown += new System.EventHandler(this.comboKindcash_DropDown);
            this.cbbKindCach.SelectedIndexChanged += new System.EventHandler(this.cbbKindCach_SelectedIndexChanged);
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
            this.dateTimePickerCash.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerCash.Name = "dateTimePickerCash";
            this.dateTimePickerCash.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerCash.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Payment";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(664, 52);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 22);
            this.textBox6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Income";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(664, 13);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
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
            this.textBox4.Location = new System.Drawing.Point(93, 121);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(474, 73);
            this.textBox4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
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
            this.panel2.Controls.Add(this.bynshowCode);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnPrinter);
            this.panel2.Controls.Add(this.insertCashBook);
            this.panel2.Location = new System.Drawing.Point(849, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 231);
            this.panel2.TabIndex = 1;
            // 
            // bynshowCode
            // 
            this.bynshowCode.Location = new System.Drawing.Point(126, 125);
            this.bynshowCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bynshowCode.Name = "bynshowCode";
            this.bynshowCode.Size = new System.Drawing.Size(81, 25);
            this.bynshowCode.TabIndex = 19;
            this.bynshowCode.Text = "Code";
            this.bynshowCode.UseVisualStyleBackColor = true;
            this.bynshowCode.Click += new System.EventHandler(this.bynshowCode_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(4, 180);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = "Refesh";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(4, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Seach";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(4, 144);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(4, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPrinter
            // 
            this.btnPrinter.Location = new System.Drawing.Point(126, 75);
            this.btnPrinter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(81, 25);
            this.btnPrinter.TabIndex = 1;
            this.btnPrinter.Text = "printer";
            this.btnPrinter.UseVisualStyleBackColor = true;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // insertCashBook
            // 
            this.insertCashBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertCashBook.Location = new System.Drawing.Point(4, 72);
            this.insertCashBook.Margin = new System.Windows.Forms.Padding(4);
            this.insertCashBook.Name = "insertCashBook";
            this.insertCashBook.Size = new System.Drawing.Size(100, 28);
            this.insertCashBook.TabIndex = 0;
            this.insertCashBook.Text = "Insert";
            this.insertCashBook.UseVisualStyleBackColor = false;
            this.insertCashBook.Click += new System.EventHandler(this.insertCashBook_Click);
            // 
            // dataViewCashBook
            // 
            this.dataViewCashBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCashBook.Location = new System.Drawing.Point(12, 336);
            this.dataViewCashBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataViewCashBook.Name = "dataViewCashBook";
            this.dataViewCashBook.RowHeadersWidth = 51;
            this.dataViewCashBook.RowTemplate.Height = 24;
            this.dataViewCashBook.Size = new System.Drawing.Size(1122, 207);
            this.dataViewCashBook.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "H15-795-011595"});
            this.comboBox1.Location = new System.Drawing.Point(104, 75);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Tag = "Cash";
            this.comboBox1.Text = "Cash";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Look for";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 22);
            this.textBox1.TabIndex = 17;
            // 
            // Cashbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 555);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataViewCashBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cashbook";
            this.Text = "Cashbook";
            this.Load += new System.EventHandler(this.Cashbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCashBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dataViewCashBook;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lbMaCode;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bynshowCode;
    }
}