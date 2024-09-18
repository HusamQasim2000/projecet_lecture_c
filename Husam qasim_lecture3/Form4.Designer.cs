namespace Husam_qasim_lecture3
{
    partial class Form4
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
            this.txt_inqut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_fact = new System.Windows.Forms.Button();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.lbl_fact = new System.Windows.Forms.Label();
            this.lbl_sqrt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_inqut
            // 
            this.txt_inqut.Location = new System.Drawing.Point(62, 52);
            this.txt_inqut.Name = "txt_inqut";
            this.txt_inqut.Size = new System.Drawing.Size(116, 20);
            this.txt_inqut.TabIndex = 0;
            this.txt_inqut.TextChanged += new System.EventHandler(this.Form4_Load);
            this.txt_inqut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inqut_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ادخل العدد";
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Location = new System.Drawing.Point(143, 203);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(75, 23);
            this.btn_sqrt.TabIndex = 2;
            this.btn_sqrt.Text = "الجذر";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_fact
            // 
            this.btn_fact.Location = new System.Drawing.Point(143, 163);
            this.btn_fact.Name = "btn_fact";
            this.btn_fact.Size = new System.Drawing.Size(75, 23);
            this.btn_fact.TabIndex = 4;
            this.btn_fact.Text = "المضروب";
            this.btn_fact.UseVisualStyleBackColor = true;
            this.btn_fact.Click += new System.EventHandler(this.btn_fact_Click);
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(59, 129);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(35, 13);
            this.lbl_sum.TabIndex = 3;
            this.lbl_sum.Text = "label2";
            this.lbl_sum.Visible = false;
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(143, 124);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(75, 23);
            this.btn_sum.TabIndex = 6;
            this.btn_sum.Text = "المجموع";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // lbl_fact
            // 
            this.lbl_fact.AutoSize = true;
            this.lbl_fact.Location = new System.Drawing.Point(59, 168);
            this.lbl_fact.Name = "lbl_fact";
            this.lbl_fact.Size = new System.Drawing.Size(35, 13);
            this.lbl_fact.TabIndex = 5;
            this.lbl_fact.Text = "label3";
            this.lbl_fact.Visible = false;
            // 
            // lbl_sqrt
            // 
            this.lbl_sqrt.AutoSize = true;
            this.lbl_sqrt.Location = new System.Drawing.Point(59, 209);
            this.lbl_sqrt.Name = "lbl_sqrt";
            this.lbl_sqrt.Size = new System.Drawing.Size(35, 13);
            this.lbl_sqrt.TabIndex = 7;
            this.lbl_sqrt.Text = "label4";
            this.lbl_sqrt.Visible = false;
            this.lbl_sqrt.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.lbl_sqrt);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.lbl_fact);
            this.Controls.Add(this.btn_fact);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_inqut);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_inqut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_fact;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Label lbl_fact;
        private System.Windows.Forms.Label lbl_sqrt;
    }
}