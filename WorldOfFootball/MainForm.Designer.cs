namespace WorldOfFootball
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.languageAndChampionship1 = new WorldOfFootball.UserControls.LanguageAndChampionship();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pnlHeader.Controls.Add(this.lbTeams);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1582, 125);
            this.pnlHeader.TabIndex = 3;
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 20;
            this.lbTeams.Location = new System.Drawing.Point(552, 12);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(240, 104);
            this.lbTeams.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::WorldOfFootball.Properties.Resources.logo_color;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlContainer.Controls.Add(this.languageAndChampionship1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 125);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1582, 828);
            this.pnlContainer.TabIndex = 4;
            // 
            // languageAndChampionship1
            // 
            this.languageAndChampionship1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.languageAndChampionship1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("languageAndChampionship1.BackgroundImage")));
            this.languageAndChampionship1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.languageAndChampionship1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageAndChampionship1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.languageAndChampionship1.Location = new System.Drawing.Point(0, 0);
            this.languageAndChampionship1.Name = "languageAndChampionship1";
            this.languageAndChampionship1.Size = new System.Drawing.Size(1582, 828);
            this.languageAndChampionship1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "World of Football";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox1;
        private ListBox lbTeams;
        private Panel pnlContainer;
        private UserControls.LanguageAndChampionship languageAndChampionship1;
    }
}