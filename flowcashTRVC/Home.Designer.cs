namespace flowcashTRVC
{
    partial class Home
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
            this.btnCashBook1 = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCashBook1);
            this.panel1.Controls.Add(this.btnCode);
            this.panel1.Location = new System.Drawing.Point(16, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 287);
            this.panel1.TabIndex = 0;
            // 
            // btnCashBook1
            // 
            this.btnCashBook1.Location = new System.Drawing.Point(190, 32);
            this.btnCashBook1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCashBook1.Name = "btnCashBook1";
            this.btnCashBook1.Size = new System.Drawing.Size(129, 50);
            this.btnCashBook1.TabIndex = 1;
            this.btnCashBook1.Text = "CashBook";
            this.btnCashBook1.UseVisualStyleBackColor = true;
            this.btnCashBook1.Click += new System.EventHandler(this.btnCashBook1_Click);
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(24, 32);
            this.btnCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(129, 50);
            this.btnCode.TabIndex = 0;
            this.btnCode.Text = "Code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 400);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnCashBook1;
    }
}