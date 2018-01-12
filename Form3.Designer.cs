namespace QuizGame
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kllnc1 = new System.Windows.Forms.Label();
            this.kllnc2 = new System.Windows.Forms.Label();
            this.kllnc3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1-)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2-)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "3-)";
            // 
            // kllnc1
            // 
            this.kllnc1.AutoSize = true;
            this.kllnc1.Location = new System.Drawing.Point(115, 83);
            this.kllnc1.Name = "kllnc1";
            this.kllnc1.Size = new System.Drawing.Size(35, 13);
            this.kllnc1.TabIndex = 0;
            this.kllnc1.Text = "label1";
            this.kllnc1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kllnc2
            // 
            this.kllnc2.AutoSize = true;
            this.kllnc2.Location = new System.Drawing.Point(115, 118);
            this.kllnc2.Name = "kllnc2";
            this.kllnc2.Size = new System.Drawing.Size(35, 13);
            this.kllnc2.TabIndex = 1;
            this.kllnc2.Text = "label2";
            // 
            // kllnc3
            // 
            this.kllnc3.AutoSize = true;
            this.kllnc3.Location = new System.Drawing.Point(115, 150);
            this.kllnc3.Name = "kllnc3";
            this.kllnc3.Size = new System.Drawing.Size(35, 13);
            this.kllnc3.TabIndex = 1;
            this.kllnc3.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "PUAN TABLOSU";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ana sayfaya dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(184, 113);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 23);
            this.result.TabIndex = 3;
            this.result.Text = "Sonuç";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kllnc3);
            this.Controls.Add(this.kllnc2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kllnc1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "RE";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kllnc1;
        private System.Windows.Forms.Label kllnc2;
        private System.Windows.Forms.Label kllnc3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button result;
    }
}