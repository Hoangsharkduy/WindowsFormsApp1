namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btntinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsotiengoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkqsonamgui = new System.Windows.Forms.TextBox();
            this.txtsotienlaisuat = new System.Windows.Forms.TextBox();
            this.lsbkq = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(343, 322);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(137, 66);
            this.btntinh.TabIndex = 0;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính Lãi Suất Ngân Hàng";
            // 
            // txtsotiengoc
            // 
            this.txtsotiengoc.Location = new System.Drawing.Point(132, 129);
            this.txtsotiengoc.Name = "txtsotiengoc";
            this.txtsotiengoc.Size = new System.Drawing.Size(105, 20);
            this.txtsotiengoc.TabIndex = 2;
            this.txtsotiengoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lãi Suất";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Năm Gửi";
            // 
            // txtkqsonamgui
            // 
            this.txtkqsonamgui.Location = new System.Drawing.Point(132, 281);
            this.txtkqsonamgui.Name = "txtkqsonamgui";
            this.txtkqsonamgui.Size = new System.Drawing.Size(105, 20);
            this.txtkqsonamgui.TabIndex = 6;
            // 
            // txtsotienlaisuat
            // 
            this.txtsotienlaisuat.Location = new System.Drawing.Point(132, 197);
            this.txtsotienlaisuat.Name = "txtsotienlaisuat";
            this.txtsotienlaisuat.Size = new System.Drawing.Size(105, 20);
            this.txtsotienlaisuat.TabIndex = 7;
            this.txtsotienlaisuat.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lsbkq
            // 
            this.lsbkq.FormattingEnabled = true;
            this.lsbkq.Location = new System.Drawing.Point(251, 394);
            this.lsbkq.Name = "lsbkq";
            this.lsbkq.Size = new System.Drawing.Size(323, 199);
            this.lsbkq.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.lsbkq);
            this.Controls.Add(this.txtsotienlaisuat);
            this.Controls.Add(this.txtkqsonamgui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsotiengoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsotiengoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkqsonamgui;
        private System.Windows.Forms.TextBox txtsotienlaisuat;
        private System.Windows.Forms.CheckedListBox lsbkq;
    }
}

