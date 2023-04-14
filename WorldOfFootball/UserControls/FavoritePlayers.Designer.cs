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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritePlayers));
            this.pnlAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNextFavTeam = new System.Windows.Forms.Button();
            this.pnlFavoritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAllPlayers = new System.Windows.Forms.Label();
            this.lblFavoritePlayers = new System.Windows.Forms.Label();
            this.pbRight = new WorldOfFootball.CustomDesign.OvalPictureBox();
            this.pbLeft = new WorldOfFootball.CustomDesign.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAllPlayers
            // 
            resources.ApplyResources(this.pnlAllPlayers, "pnlAllPlayers");
            this.pnlAllPlayers.AllowDrop = true;
            this.pnlAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlAllPlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAllPlayers.Name = "pnlAllPlayers";
            this.pnlAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlAllPlayers_DragDrop);
            this.pnlAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlAllPlayers_DragEnter);
            // 
            // btnNextFavTeam
            // 
            resources.ApplyResources(this.btnNextFavTeam, "btnNextFavTeam");
            this.btnNextFavTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnNextFavTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnNextFavTeam.FlatAppearance.BorderSize = 0;
            this.btnNextFavTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnNextFavTeam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNextFavTeam.Name = "btnNextFavTeam";
            this.btnNextFavTeam.UseVisualStyleBackColor = false;
            // 
            // pnlFavoritePlayers
            // 
            resources.ApplyResources(this.pnlFavoritePlayers, "pnlFavoritePlayers");
            this.pnlFavoritePlayers.AllowDrop = true;
            this.pnlFavoritePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlFavoritePlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            this.pnlFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlFavoritePlayers_DragDrop);
            this.pnlFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlFavoritePlayers_DragEnter);
            // 
            // lblAllPlayers
            // 
            resources.ApplyResources(this.lblAllPlayers, "lblAllPlayers");
            this.lblAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblAllPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAllPlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAllPlayers.Name = "lblAllPlayers";
            // 
            // lblFavoritePlayers
            // 
            resources.ApplyResources(this.lblFavoritePlayers, "lblFavoritePlayers");
            this.lblFavoritePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblFavoritePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFavoritePlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFavoritePlayers.Name = "lblFavoritePlayers";
            // 
            // pbRight
            // 
            resources.ApplyResources(this.pbRight, "pbRight");
            this.pbRight.BackColor = System.Drawing.Color.DarkGray;
            this.pbRight.Image = global::WorldOfFootball.Properties.Resources.RightArrow;
            this.pbRight.Name = "pbRight";
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.PbMoveToFavoritePlayers_Click);
            // 
            // pbLeft
            // 
            resources.ApplyResources(this.pbLeft, "pbLeft");
            this.pbLeft.BackColor = System.Drawing.Color.DarkGray;
            this.pbLeft.Image = global::WorldOfFootball.Properties.Resources.LeftArrow;
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.PbMoveToAllPlayers_Click);
            // 
            // FavoritePlayers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.lblFavoritePlayers);
            this.Controls.Add(this.lblAllPlayers);
            this.Controls.Add(this.pnlFavoritePlayers);
            this.Controls.Add(this.btnNextFavTeam);
            this.Controls.Add(this.pnlAllPlayers);
            this.Name = "FavoritePlayers";
            this.Load += new System.EventHandler(this.FavoritePlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel pnlAllPlayers;
        private Button btnNextFavTeam;
        private FlowLayoutPanel pnlFavoritePlayers;
        private Label lblAllPlayers;
        private Label lblFavoritePlayers;
        private CustomDesign.OvalPictureBox pbRight;
        private CustomDesign.OvalPictureBox pbLeft;
    }
}
