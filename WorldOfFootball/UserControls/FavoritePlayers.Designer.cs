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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.pnlAllPlayers.Location = new System.Drawing.Point(92, 63);
            this.pnlAllPlayers.Name = "pnlAllPlayers";
            this.pnlAllPlayers.Size = new System.Drawing.Size(515, 720);
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
            this.btnNextFavTeam.Location = new System.Drawing.Point(960, 452);
            this.btnNextFavTeam.Name = "btnNextFavTeam";
            this.btnNextFavTeam.Size = new System.Drawing.Size(488, 48);
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
            this.pnlFavoritePlayers.Location = new System.Drawing.Point(960, 63);
            this.pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            this.pnlFavoritePlayers.Size = new System.Drawing.Size(488, 383);
            this.pnlFavoritePlayers.TabIndex = 4;
            this.pnlFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlFavoritePlayers_DragDrop);
            this.pnlFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlFavoritePlayers_DragEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Svi igrači";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(960, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Omiljeni igrači";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.Color.DarkGray;
            this.pbRight.Image = global::WorldOfFootball.Properties.Resources.RightArrow;
            this.pbRight.Location = new System.Drawing.Point(729, 280);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(125, 108);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRight.TabIndex = 12;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.PbRight_Click);
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.Color.DarkGray;
            this.pbLeft.Image = global::WorldOfFootball.Properties.Resources.LeftArrow;
            this.pbLeft.Location = new System.Drawing.Point(729, 115);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(125, 108);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeft.TabIndex = 13;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.PbLeft_Click);
            // 
            // FavoritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFavoritePlayers);
            this.Controls.Add(this.btnNextFavTeam);
            this.Controls.Add(this.pnlAllPlayers);
            this.Name = "FavoritePlayers";
            this.Size = new System.Drawing.Size(1582, 828);
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel pnlAllPlayers;
        private Button btnNextFavTeam;
        private FlowLayoutPanel pnlFavoritePlayers;
        private Label label1;
        private Label label2;
        private CustomDesign.OvalPictureBox pbRight;
        private CustomDesign.OvalPictureBox pbLeft;
    }
}
