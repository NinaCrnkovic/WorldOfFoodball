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
            this.pnlAllPlayers.AllowDrop = true;
            this.pnlAllPlayers.AutoScroll = true;
            this.pnlAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlAllPlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAllPlayers.Location = new System.Drawing.Point(80, 47);
            this.pnlAllPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAllPlayers.Name = "pnlAllPlayers";
            this.pnlAllPlayers.Size = new System.Drawing.Size(451, 540);
            this.pnlAllPlayers.TabIndex = 3;
            this.pnlAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlAllPlayers_DragDrop);
            this.pnlAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlAllPlayers_DragEnter);
            // 
            // btnNextFavTeam
            // 
            this.btnNextFavTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnNextFavTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnNextFavTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnNextFavTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFavTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextFavTeam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNextFavTeam.Location = new System.Drawing.Point(840, 439);
            this.btnNextFavTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextFavTeam.Name = "btnNextFavTeam";
            this.btnNextFavTeam.Size = new System.Drawing.Size(427, 36);
            this.btnNextFavTeam.TabIndex = 6;
            this.btnNextFavTeam.Text = "Next";
            this.btnNextFavTeam.UseVisualStyleBackColor = false;
            // 
            // pnlFavoritePlayers
            // 
            this.pnlFavoritePlayers.AllowDrop = true;
            this.pnlFavoritePlayers.AutoScroll = true;
            this.pnlFavoritePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlFavoritePlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFavoritePlayers.Location = new System.Drawing.Point(840, 47);
            this.pnlFavoritePlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            this.pnlFavoritePlayers.Size = new System.Drawing.Size(425, 383);
            this.pnlFavoritePlayers.TabIndex = 4;
            this.pnlFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlFavoritePlayers_DragDrop);
            this.pnlFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlFavoritePlayers_DragEnter);
            // 
            // lblAllPlayers
            // 
            this.lblAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblAllPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAllPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllPlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAllPlayers.Location = new System.Drawing.Point(80, 13);
            this.lblAllPlayers.Name = "lblAllPlayers";
            this.lblAllPlayers.Size = new System.Drawing.Size(451, 26);
            this.lblAllPlayers.TabIndex = 7;
            this.lblAllPlayers.Text = "Svi igrači";
            this.lblAllPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFavoritePlayers
            // 
            this.lblFavoritePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblFavoritePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFavoritePlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFavoritePlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFavoritePlayers.Location = new System.Drawing.Point(840, 13);
            this.lblFavoritePlayers.Name = "lblFavoritePlayers";
            this.lblFavoritePlayers.Size = new System.Drawing.Size(427, 26);
            this.lblFavoritePlayers.TabIndex = 8;
            this.lblFavoritePlayers.Text = "Omiljeni igrači";
            this.lblFavoritePlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.Color.DarkGray;
            this.pbRight.Image = global::WorldOfFootball.Properties.Resources.RightArrow;
            this.pbRight.Location = new System.Drawing.Point(638, 198);
            this.pbRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(109, 93);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRight.TabIndex = 12;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.PbRight_Click);
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.Color.DarkGray;
            this.pbLeft.Image = global::WorldOfFootball.Properties.Resources.LeftArrow;
            this.pbLeft.Location = new System.Drawing.Point(638, 86);
            this.pbLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(109, 92);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeft.TabIndex = 13;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.PbLeft_Click);
            // 
            // FavoritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.lblFavoritePlayers);
            this.Controls.Add(this.lblAllPlayers);
            this.Controls.Add(this.pnlFavoritePlayers);
            this.Controls.Add(this.btnNextFavTeam);
            this.Controls.Add(this.pnlAllPlayers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FavoritePlayers";
            this.Size = new System.Drawing.Size(1384, 621);
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
