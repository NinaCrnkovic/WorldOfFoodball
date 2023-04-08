namespace WorldOfFootball.UserControls
{
    partial class FavoriteTeam
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
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextFavTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(554, 135);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(475, 28);
            this.cbTeams.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(554, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite omiljenu reprezentaciju";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextFavTeam
            // 
            this.btnNextFavTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnNextFavTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnNextFavTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnNextFavTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFavTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextFavTeam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNextFavTeam.Location = new System.Drawing.Point(554, 169);
            this.btnNextFavTeam.Name = "btnNextFavTeam";
            this.btnNextFavTeam.Size = new System.Drawing.Size(475, 48);
            this.btnNextFavTeam.TabIndex = 5;
            this.btnNextFavTeam.Text = "Next";
            this.btnNextFavTeam.UseVisualStyleBackColor = false;
            // 
            // FavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnNextFavTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTeams);
            this.Name = "FavoriteTeam";
            this.Size = new System.Drawing.Size(1582, 828);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbTeams;
        private Label label1;
        private Button btnNextFavTeam;
    }
}
