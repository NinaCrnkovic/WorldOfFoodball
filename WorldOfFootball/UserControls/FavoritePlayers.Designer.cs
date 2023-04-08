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
            this.pnlFavoritePlayers = new System.Windows.Forms.Panel();
            this.pnlAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNextFavTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlFavoritePlayers
            // 
            this.pnlFavoritePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlFavoritePlayers.Location = new System.Drawing.Point(1055, 63);
            this.pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            this.pnlFavoritePlayers.Size = new System.Drawing.Size(359, 301);
            this.pnlFavoritePlayers.TabIndex = 1;
            // 
            // pnlAllPlayers
            // 
            this.pnlAllPlayers.AutoScroll = true;
            this.pnlAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlAllPlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAllPlayers.Location = new System.Drawing.Point(92, 63);
            this.pnlAllPlayers.Name = "pnlAllPlayers";
            this.pnlAllPlayers.Size = new System.Drawing.Size(382, 720);
            this.pnlAllPlayers.TabIndex = 3;
            // 
            // btnNextFavTeam
            // 
            this.btnNextFavTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnNextFavTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnNextFavTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnNextFavTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFavTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextFavTeam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNextFavTeam.Location = new System.Drawing.Point(1055, 396);
            this.btnNextFavTeam.Name = "btnNextFavTeam";
            this.btnNextFavTeam.Size = new System.Drawing.Size(359, 48);
            this.btnNextFavTeam.TabIndex = 6;
            this.btnNextFavTeam.Text = "Next";
            this.btnNextFavTeam.UseVisualStyleBackColor = false;
            // 
            // FavoritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnNextFavTeam);
            this.Controls.Add(this.pnlAllPlayers);
            this.Controls.Add(this.pnlFavoritePlayers);
            this.Name = "FavoritePlayers";
            this.Size = new System.Drawing.Size(1582, 828);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlFavoritePlayers;
        private FlowLayoutPanel pnlAllPlayers;
        private Button btnNextFavTeam;
    }
}
