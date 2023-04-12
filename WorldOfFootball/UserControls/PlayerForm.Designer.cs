namespace WorldOfFootball.UserControls
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pbStar = new System.Windows.Forms.PictureBox();
            this.pbCapitan = new System.Windows.Forms.PictureBox();
            this.pbImage = new WorldOfFootball.CustomDesign.OvalPictureBox();
            this.btnPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapitan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::WorldOfFootball.Properties.Resources.tshirt;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // lblNumber
            // 
            resources.ApplyResources(this.lblNumber, "lblNumber");
            this.lblNumber.Name = "lblNumber";
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.Name = "lblPosition";
            // 
            // pbStar
            // 
            resources.ApplyResources(this.pbStar, "pbStar");
            this.pbStar.Image = global::WorldOfFootball.Properties.Resources.star;
            this.pbStar.Name = "pbStar";
            this.pbStar.TabStop = false;
            // 
            // pbCapitan
            // 
            resources.ApplyResources(this.pbCapitan, "pbCapitan");
            this.pbCapitan.Image = global::WorldOfFootball.Properties.Resources.captain_band;
            this.pbCapitan.Name = "pbCapitan";
            this.pbCapitan.TabStop = false;
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.BackColor = System.Drawing.Color.DarkGray;
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // btnPicture
            // 
            resources.ApplyResources(this.btnPicture, "btnPicture");
            this.btnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.UseVisualStyleBackColor = false;
            // 
            // PlayerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pbCapitan);
            this.Controls.Add(this.pbStar);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapitan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblName;
        private PictureBox pictureBox2;
        private Label lblNumber;
        private Label lblPosition;
        private PictureBox pbStar;
        private PictureBox pbCapitan;
        private CustomDesign.OvalPictureBox pbImage;
        private Button btnPicture;
    }
}
