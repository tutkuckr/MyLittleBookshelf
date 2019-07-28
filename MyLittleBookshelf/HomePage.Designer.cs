namespace MyLittleBookshelf
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.RC_CircleProgressbar1 = new ns1.BunifuCircleProgressbar();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // RC_CircleProgressbar1
            // 
            this.RC_CircleProgressbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.RC_CircleProgressbar1.Location = new System.Drawing.Point(391, 9);
            this.RC_CircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.RC_CircleProgressbar1.MaxValue = 100;
            this.RC_CircleProgressbar1.Name = "RC_CircleProgressbar1";
            this.RC_CircleProgressbar1.ProgressBackColor = System.Drawing.Color.DarkGray;
            this.RC_CircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.RC_CircleProgressbar1.Size = new System.Drawing.Size(117, 117);
            this.RC_CircleProgressbar1.TabIndex = 5;
            this.RC_CircleProgressbar1.Value = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(255, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reading Progress";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.Location = new System.Drawing.Point(776, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel1.Size = new System.Drawing.Size(92, 108);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tutku ÇAKIR";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.RC_CircleProgressbar1);
            this.Controls.Add(this.label2);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(871, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCircleProgressbar RC_CircleProgressbar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
