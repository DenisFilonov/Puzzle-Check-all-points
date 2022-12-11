namespace WindowsFormsApp6_pd
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
            this.chbFirst = new System.Windows.Forms.CheckBox();
            this.chbSecond = new System.Windows.Forms.CheckBox();
            this.chbThird = new System.Windows.Forms.CheckBox();
            this.chbFourth = new System.Windows.Forms.CheckBox();
            this.chbFifth = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chbFirst
            // 
            this.chbFirst.AutoSize = true;
            this.chbFirst.Location = new System.Drawing.Point(186, 85);
            this.chbFirst.Name = "chbFirst";
            this.chbFirst.Size = new System.Drawing.Size(36, 20);
            this.chbFirst.TabIndex = 0;
            this.chbFirst.Text = "1";
            this.chbFirst.UseVisualStyleBackColor = true;
            this.chbFirst.CheckedChanged += new System.EventHandler(this.Check);
            // 
            // chbSecond
            // 
            this.chbSecond.AutoSize = true;
            this.chbSecond.Location = new System.Drawing.Point(186, 111);
            this.chbSecond.Name = "chbSecond";
            this.chbSecond.Size = new System.Drawing.Size(36, 20);
            this.chbSecond.TabIndex = 1;
            this.chbSecond.Text = "2";
            this.chbSecond.UseVisualStyleBackColor = true;
            this.chbSecond.CheckedChanged += new System.EventHandler(this.Check);
            // 
            // chbThird
            // 
            this.chbThird.AutoSize = true;
            this.chbThird.Location = new System.Drawing.Point(186, 137);
            this.chbThird.Name = "chbThird";
            this.chbThird.Size = new System.Drawing.Size(36, 20);
            this.chbThird.TabIndex = 2;
            this.chbThird.Text = "3";
            this.chbThird.UseVisualStyleBackColor = true;
            this.chbThird.CheckedChanged += new System.EventHandler(this.Check);
            // 
            // chbFourth
            // 
            this.chbFourth.AutoSize = true;
            this.chbFourth.Location = new System.Drawing.Point(186, 163);
            this.chbFourth.Name = "chbFourth";
            this.chbFourth.Size = new System.Drawing.Size(36, 20);
            this.chbFourth.TabIndex = 3;
            this.chbFourth.Text = "4";
            this.chbFourth.UseVisualStyleBackColor = true;
            this.chbFourth.CheckedChanged += new System.EventHandler(this.Check);
            // 
            // chbFifth
            // 
            this.chbFifth.AutoSize = true;
            this.chbFifth.Location = new System.Drawing.Point(186, 189);
            this.chbFifth.Name = "chbFifth";
            this.chbFifth.Size = new System.Drawing.Size(36, 20);
            this.chbFifth.TabIndex = 4;
            this.chbFifth.Text = "5";
            this.chbFifth.UseVisualStyleBackColor = true;
            this.chbFifth.CheckedChanged += new System.EventHandler(this.Check);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 331);
            this.Controls.Add(this.chbFifth);
            this.Controls.Add(this.chbFourth);
            this.Controls.Add(this.chbThird);
            this.Controls.Add(this.chbSecond);
            this.Controls.Add(this.chbFirst);
            this.Name = "Form1";
            this.Text = "Отметь все галочки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbFirst;
        private System.Windows.Forms.CheckBox chbSecond;
        private System.Windows.Forms.CheckBox chbThird;
        private System.Windows.Forms.CheckBox chbFourth;
        private System.Windows.Forms.CheckBox chbFifth;
    }
}

