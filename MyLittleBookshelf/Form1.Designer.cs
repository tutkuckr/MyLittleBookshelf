namespace MyLittleBookshelf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.HOME = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.WantToReadButton = new System.Windows.Forms.Button();
            this.ReadingChallengeButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.CurrentlyReadingButton = new System.Windows.Forms.Button();
            this.FavouriteButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExitButton = new ns1.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BOOKSHELF = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.homePage1 = new MyLittleBookshelf.HomePage();
            this.readingChallangeControl1 = new MyLittleBookshelf.ReadingChallangeControl();
            this.addNewBookPage1 = new MyLittleBookshelf.AddNewBookPage();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.HOME);
            this.panel1.Controls.Add(this.ReadButton);
            this.panel1.Controls.Add(this.WantToReadButton);
            this.panel1.Controls.Add(this.ReadingChallengeButton);
            this.panel1.Controls.Add(this.AddBookButton);
            this.panel1.Controls.Add(this.CurrentlyReadingButton);
            this.panel1.Controls.Add(this.FavouriteButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 846);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SidePanel.Location = new System.Drawing.Point(222, 13);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(18, 92);
            this.SidePanel.TabIndex = 3;
            // 
            // HOME
            // 
            this.HOME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HOME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HOME.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HOME.FlatAppearance.BorderSize = 0;
            this.HOME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOME.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HOME.Image = ((System.Drawing.Image)(resources.GetObject("HOME.Image")));
            this.HOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HOME.Location = new System.Drawing.Point(0, 13);
            this.HOME.Name = "HOME";
            this.HOME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HOME.Size = new System.Drawing.Size(233, 92);
            this.HOME.TabIndex = 3;
            this.HOME.Text = "HOME";
            this.HOME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HOME.UseVisualStyleBackColor = false;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReadButton.FlatAppearance.BorderSize = 0;
            this.ReadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReadButton.Image")));
            this.ReadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadButton.Location = new System.Drawing.Point(-1, 606);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(231, 93);
            this.ReadButton.TabIndex = 9;
            this.ReadButton.Text = "READ";
            this.ReadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReadButton.UseVisualStyleBackColor = false;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // WantToReadButton
            // 
            this.WantToReadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WantToReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WantToReadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WantToReadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WantToReadButton.FlatAppearance.BorderSize = 0;
            this.WantToReadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WantToReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WantToReadButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WantToReadButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WantToReadButton.Image = ((System.Drawing.Image)(resources.GetObject("WantToReadButton.Image")));
            this.WantToReadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WantToReadButton.Location = new System.Drawing.Point(-1, 408);
            this.WantToReadButton.Name = "WantToReadButton";
            this.WantToReadButton.Size = new System.Drawing.Size(231, 93);
            this.WantToReadButton.TabIndex = 8;
            this.WantToReadButton.Text = "WANT TO READ";
            this.WantToReadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WantToReadButton.UseVisualStyleBackColor = false;
            this.WantToReadButton.Click += new System.EventHandler(this.WantToReadButton_Click);
            // 
            // ReadingChallengeButton
            // 
            this.ReadingChallengeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReadingChallengeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReadingChallengeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadingChallengeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReadingChallengeButton.FlatAppearance.BorderSize = 0;
            this.ReadingChallengeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReadingChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadingChallengeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadingChallengeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReadingChallengeButton.Image = ((System.Drawing.Image)(resources.GetObject("ReadingChallengeButton.Image")));
            this.ReadingChallengeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadingChallengeButton.Location = new System.Drawing.Point(-1, 210);
            this.ReadingChallengeButton.Name = "ReadingChallengeButton";
            this.ReadingChallengeButton.Size = new System.Drawing.Size(231, 93);
            this.ReadingChallengeButton.TabIndex = 7;
            this.ReadingChallengeButton.Text = "READING CHALLENGE";
            this.ReadingChallengeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReadingChallengeButton.UseVisualStyleBackColor = false;
            this.ReadingChallengeButton.Click += new System.EventHandler(this.ReadingChallengeButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddBookButton.FlatAppearance.BorderSize = 0;
            this.AddBookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddBookButton.Image = ((System.Drawing.Image)(resources.GetObject("AddBookButton.Image")));
            this.AddBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBookButton.Location = new System.Drawing.Point(-1, 309);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(231, 93);
            this.AddBookButton.TabIndex = 4;
            this.AddBookButton.Text = "ADD BOOK";
            this.AddBookButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // CurrentlyReadingButton
            // 
            this.CurrentlyReadingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CurrentlyReadingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentlyReadingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentlyReadingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CurrentlyReadingButton.FlatAppearance.BorderSize = 0;
            this.CurrentlyReadingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CurrentlyReadingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentlyReadingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentlyReadingButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CurrentlyReadingButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrentlyReadingButton.Image")));
            this.CurrentlyReadingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentlyReadingButton.Location = new System.Drawing.Point(0, 111);
            this.CurrentlyReadingButton.Name = "CurrentlyReadingButton";
            this.CurrentlyReadingButton.Size = new System.Drawing.Size(231, 93);
            this.CurrentlyReadingButton.TabIndex = 6;
            this.CurrentlyReadingButton.Text = "CURRENTLY READING";
            this.CurrentlyReadingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CurrentlyReadingButton.UseVisualStyleBackColor = false;
            this.CurrentlyReadingButton.Click += new System.EventHandler(this.CurrentlyReadingButton_Click);
            // 
            // FavouriteButton
            // 
            this.FavouriteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FavouriteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FavouriteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavouriteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FavouriteButton.FlatAppearance.BorderSize = 0;
            this.FavouriteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FavouriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavouriteButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FavouriteButton.Image = ((System.Drawing.Image)(resources.GetObject("FavouriteButton.Image")));
            this.FavouriteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavouriteButton.Location = new System.Drawing.Point(-1, 507);
            this.FavouriteButton.Name = "FavouriteButton";
            this.FavouriteButton.Size = new System.Drawing.Size(231, 93);
            this.FavouriteButton.TabIndex = 5;
            this.FavouriteButton.Text = "FAVOURITE";
            this.FavouriteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FavouriteButton.UseVisualStyleBackColor = false;
            this.FavouriteButton.Click += new System.EventHandler(this.FavouriteButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Controls.Add(this.ExitButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1107, 43);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageActive = null;
            this.ExitButton.Location = new System.Drawing.Point(1062, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 36);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.Zoom = 10;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BOOKSHELF);
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 144);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 95);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BOOKSHELF
            // 
            this.BOOKSHELF.AutoSize = true;
            this.BOOKSHELF.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOOKSHELF.ForeColor = System.Drawing.Color.Transparent;
            this.BOOKSHELF.Location = new System.Drawing.Point(-2, 98);
            this.BOOKSHELF.Name = "BOOKSHELF";
            this.BOOKSHELF.Size = new System.Drawing.Size(115, 23);
            this.BOOKSHELF.TabIndex = 4;
            this.BOOKSHELF.Text = "BOOKSHELF";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.flowLayoutPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // homePage1
            // 
            this.homePage1.BackColor = System.Drawing.Color.Lavender;
            this.homePage1.Location = new System.Drawing.Point(241, 139);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(866, 556);
            this.homePage1.TabIndex = 4;
            // 
            // readingChallangeControl1
            // 
            this.readingChallangeControl1.BackColor = System.Drawing.Color.Lavender;
            this.readingChallangeControl1.Location = new System.Drawing.Point(241, 139);
            this.readingChallangeControl1.Name = "readingChallangeControl1";
            this.readingChallangeControl1.Size = new System.Drawing.Size(868, 560);
            this.readingChallangeControl1.TabIndex = 5;
            // 
            // addNewBookPage1
            // 
            this.addNewBookPage1.BackColor = System.Drawing.Color.Lavender;
            this.addNewBookPage1.Location = new System.Drawing.Point(241, 139);
            this.addNewBookPage1.Name = "addNewBookPage1";
            this.addNewBookPage1.Size = new System.Drawing.Size(863, 560);
            this.addNewBookPage1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1107, 700);
            this.Controls.Add(this.homePage1);
            this.Controls.Add(this.readingChallangeControl1);
            this.Controls.Add(this.addNewBookPage1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BOOKSHELF;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button WantToReadButton;
        private System.Windows.Forms.Button ReadingChallengeButton;
        private System.Windows.Forms.Button CurrentlyReadingButton;
        private System.Windows.Forms.Button FavouriteButton;
        private System.Windows.Forms.Button AddBookButton;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuImageButton ExitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button HOME;
        private System.Windows.Forms.Panel SidePanel;
        private AddNewBookPage addNewBookPage1;
        private HomePage homePage1;
        private ReadingChallangeControl readingChallangeControl1;
    }
}

