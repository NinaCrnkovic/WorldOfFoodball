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
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pbStar = new System.Windows.Forms.PictureBox();
            this.pbCapitan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapitan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(13, 7);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(131, 104);
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(161, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 28);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ime i prezime";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WorldOfFootball.Properties.Resources.tshirt;
            this.pictureBox2.Location = new System.Drawing.Point(161, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(203, 42);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(34, 28);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "12";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(161, 73);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(77, 28);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Pozicija";
            // 
            // pbStar
            // 
            this.pbStar.Image = global::WorldOfFootball.Properties.Resources.star;
            this.pbStar.Location = new System.Drawing.Point(431, 0);
            this.pbStar.Name = "pbStar";
            this.pbStar.Size = new System.Drawing.Size(45, 45);
            this.pbStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar.TabIndex = 6;
            this.pbStar.TabStop = false;
            // 
            // pbCapitan
            // 
            this.pbCapitan.Image = global::WorldOfFootball.Properties.Resources.captain_band;
            this.pbCapitan.Location = new System.Drawing.Point(410, 66);
            this.pbCapitan.Name = "pbCapitan";
            this.pbCapitan.Size = new System.Drawing.Size(66, 45);
            this.pbCapitan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapitan.TabIndex = 7;
            this.pbCapitan.TabStop = false;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.pbCapitan);
            this.Controls.Add(this.pbStar);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPicture);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "PlayerForm";
            this.Size = new System.Drawing.Size(479, 121);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapitan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbPicture;
        private Label lblName;
        private PictureBox pictureBox2;
        private Label lblNumber;
        private Label lblPosition;
        private PictureBox pbStar;
        private PictureBox pbCapitan;
    }
}
