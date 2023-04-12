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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteTeam));
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextFavTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Name = "cbTeams";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
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
            // FavoriteTeam
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.Controls.Add(this.btnNextFavTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTeams);
            this.Name = "FavoriteTeam";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbTeams;
        private Label label1;
        private Button btnNextFavTeam;
    }
}
