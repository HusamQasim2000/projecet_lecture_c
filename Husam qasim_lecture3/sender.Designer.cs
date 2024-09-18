namespace Husam_qasim_lecture3
{
    partial class sender
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
            this.button1 = new System.Windows.Forms.Button();
            this.ptnred = new System.Windows.Forms.Button();
            this.ptngreen = new System.Windows.Forms.Button();
            this.ptnyellow = new System.Windows.Forms.Button();
            this.device1 = new System.Windows.Forms.Label();
            this.device2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ptnred
            // 
            this.ptnred.Location = new System.Drawing.Point(12, 42);
            this.ptnred.Name = "ptnred";
            this.ptnred.Size = new System.Drawing.Size(75, 23);
            this.ptnred.TabIndex = 1;
            this.ptnred.Text = "احمر";
            this.ptnred.UseVisualStyleBackColor = true;
            this.ptnred.Click += new System.EventHandler(this.traingforsender);
            // 
            // ptngreen
            // 
            this.ptngreen.Location = new System.Drawing.Point(96, 42);
            this.ptngreen.Name = "ptngreen";
            this.ptngreen.Size = new System.Drawing.Size(75, 23);
            this.ptngreen.TabIndex = 2;
            this.ptngreen.Text = "اخضر";
            this.ptngreen.UseVisualStyleBackColor = true;
            this.ptngreen.Click += new System.EventHandler(this.traingforsender);
            // 
            // ptnyellow
            // 
            this.ptnyellow.Location = new System.Drawing.Point(177, 42);
            this.ptnyellow.Name = "ptnyellow";
            this.ptnyellow.Size = new System.Drawing.Size(75, 23);
            this.ptnyellow.TabIndex = 3;
            this.ptnyellow.Text = "اصفر";
            this.ptnyellow.UseVisualStyleBackColor = true;
            this.ptnyellow.Click += new System.EventHandler(this.traingforsender);
            // 
            // device1
            // 
            this.device1.AutoSize = true;
            this.device1.Location = new System.Drawing.Point(30, 22);
            this.device1.Name = "device1";
            this.device1.Size = new System.Drawing.Size(39, 13);
            this.device1.TabIndex = 4;
            this.device1.Text = "الجهاز1";
            this.device1.Click += new System.EventHandler(this.traingforsender);
            // 
            // device2
            // 
            this.device2.AutoSize = true;
            this.device2.Location = new System.Drawing.Point(115, 22);
            this.device2.Name = "device2";
            this.device2.Size = new System.Drawing.Size(39, 13);
            this.device2.TabIndex = 5;
            this.device2.Text = "الجهاز2";
            this.device2.Click += new System.EventHandler(this.traingforsender);
            // 
            // sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.device2);
            this.Controls.Add(this.device1);
            this.Controls.Add(this.ptnyellow);
            this.Controls.Add(this.ptngreen);
            this.Controls.Add(this.ptnred);
            this.Controls.Add(this.button1);
            this.Name = "sender";
            this.Text = "`";
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ptnred;
        private System.Windows.Forms.Button ptngreen;
        private System.Windows.Forms.Button ptnyellow;
        private System.Windows.Forms.Label device1;
        private System.Windows.Forms.Label device2;
    }
}