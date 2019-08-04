namespace MyLittleBookshelf
{
    partial class ReadingChallangeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadingChallangeControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RC_CircleProgressbar1 = new ns1.BunifuCircleProgressbar();
            this.DaysLeftLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wantToReadAmountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "READING CHALLENGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Challenge Progress";
            // 
            // RC_CircleProgressbar1
            // 
            this.RC_CircleProgressbar1.animated = true;
            this.RC_CircleProgressbar1.animationIterval = 5;
            this.RC_CircleProgressbar1.animationSpeed = 100;
            this.RC_CircleProgressbar1.BackColor = System.Drawing.Color.Lavender;
            this.RC_CircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RC_CircleProgressbar1.BackgroundImage")));
            this.RC_CircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.RC_CircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.RC_CircleProgressbar1.LabelVisible = true;
            this.RC_CircleProgressbar1.LineProgressThickness = 10;
            this.RC_CircleProgressbar1.LineThickness = 5;
            this.RC_CircleProgressbar1.Location = new System.Drawing.Point(754, 9);
            this.RC_CircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.RC_CircleProgressbar1.MaxValue = 100;
            this.RC_CircleProgressbar1.Name = "RC_CircleProgressbar1";
            this.RC_CircleProgressbar1.ProgressBackColor = System.Drawing.Color.DarkGray;
            this.RC_CircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.RC_CircleProgressbar1.Size = new System.Drawing.Size(117, 117);
            this.RC_CircleProgressbar1.TabIndex = 3;
            this.RC_CircleProgressbar1.Value = 0;
            // 
            // DaysLeftLabel
            // 
            this.DaysLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DaysLeftLabel.Font = new System.Drawing.Font("Kristen ITC", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DaysLeftLabel.ForeColor = System.Drawing.Color.Maroon;
            this.DaysLeftLabel.Location = new System.Drawing.Point(244, 102);
            this.DaysLeftLabel.Name = "DaysLeftLabel";
            this.DaysLeftLabel.Size = new System.Drawing.Size(50, 32);
            this.DaysLeftLabel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(30, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 86);
            this.label4.TabIndex = 12;
            this.label4.Text = "Days Left: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 86);
            this.label3.TabIndex = 14;
            this.label3.Text = "I WANT TO READ ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wantToReadAmountLabel
            // 
            this.wantToReadAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wantToReadAmountLabel.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F);
            this.wantToReadAmountLabel.Location = new System.Drawing.Point(216, 32);
            this.wantToReadAmountLabel.Name = "wantToReadAmountLabel";
            this.wantToReadAmountLabel.Size = new System.Drawing.Size(58, 22);
            this.wantToReadAmountLabel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(280, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "BOOKS IN ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year
            // 
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.year.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F);
            this.year.Location = new System.Drawing.Point(359, 32);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(58, 22);
            this.year.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F);
            this.label7.Location = new System.Drawing.Point(318, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(280, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "OF";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F);
            this.label9.Location = new System.Drawing.Point(216, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 22);
            this.label9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(3, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 86);
            this.label10.TabIndex = 18;
            this.label10.Text = "YOU HAVE READ ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(382, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "BOOKS ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.wantToReadAmountLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(26, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 200);
            this.panel1.TabIndex = 23;
            // 
            // ReadingChallangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DaysLeftLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RC_CircleProgressbar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReadingChallangeControl";
            this.Size = new System.Drawing.Size(871, 549);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuCircleProgressbar RC_CircleProgressbar1;
        private System.Windows.Forms.Label DaysLeftLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wantToReadAmountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
    }
}
