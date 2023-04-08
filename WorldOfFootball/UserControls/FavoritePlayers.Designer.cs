namespace WorldOfFootball.UserControls
{
    partial class FavoritePlayers
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
            this.pnlAllPlayers = new System.Windows.Forms.Panel();
            this.pnlFavoritePlayers = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pnlAllPlayers
            // 
            this.pnlAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlAllPlayers.Location = new System.Drawing.Point(171, 86);
            this.pnlAllPlayers.Name = "pnlAllPlayers";
            this.pnlAllPlayers.Size = new System.Drawing.Size(359, 651);
            this.pnlAllPlayers.TabIndex = 0;
            // 
            // pnlFavoritePlayers
            // 
            this.pnlFavoritePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlFavoritePlayers.Location = new System.Drawing.Point(1042, 86);
            this.pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            this.pnlFavoritePlayers.Size = new System.Drawing.Size(359, 651);
            this.pnlFavoritePlayers.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(705, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 484);
            this.listBox1.TabIndex = 2;
            // 
            // FavoritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pnlFavoritePlayers);
            this.Controls.Add(this.pnlAllPlayers);
            this.Name = "FavoritePlayers";
            this.Size = new System.Drawing.Size(1582, 828);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlAllPlayers;
        private Panel pnlFavoritePlayers;
        private ListBox listBox1;
    }
}
