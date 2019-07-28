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
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
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
            this.RC_CircleProgressbar1.Location = new System.Drawing.Point(758, 9);
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
            this.DaysLeftLabel.Location = new System.Drawing.Point(236, 86);
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
            this.label4.Location = new System.Drawing.Point(22, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 86);
            this.label4.TabIndex = 12;
            this.label4.Text = "Days Left: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReadingChallangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.DaysLeftLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RC_CircleProgressbar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReadingChallangeControl";
            this.Size = new System.Drawing.Size(871, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuCircleProgressbar RC_CircleProgressbar1;
        private System.Windows.Forms.Label DaysLeftLabel;
        private System.Windows.Forms.Label label4;
    }
}
