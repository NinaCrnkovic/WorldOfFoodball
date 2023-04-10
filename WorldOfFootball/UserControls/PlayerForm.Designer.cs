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
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(141, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ime i prezime";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WorldOfFootball.Properties.Resources.tshirt;
            this.pictureBox2.Location = new System.Drawing.Point(141, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(178, 32);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(28, 21);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "12";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(141, 55);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 21);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Pozicija";
            // 
            // pbStar
            // 
            this.pbStar.Image = global::WorldOfFootball.Properties.Resources.star;
            this.pbStar.Location = new System.Drawing.Point(380, 0);
            this.pbStar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStar.Name = "pbStar";
            this.pbStar.Size = new System.Drawing.Size(39, 34);
            this.pbStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar.TabIndex = 6;
            this.pbStar.TabStop = false;
            // 
            // pbCapitan
            // 
            this.pbCapitan.Image = global::WorldOfFootball.Properties.Resources.captain_band;
            this.pbCapitan.Location = new System.Drawing.Point(359, 76);
            this.pbCapitan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCapitan.Name = "pbCapitan";
            this.pbCapitan.Size = new System.Drawing.Size(58, 34);
            this.pbCapitan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapitan.TabIndex = 7;
            this.pbCapitan.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.DarkGray;
            this.pbImage.Location = new System.Drawing.Point(14, 12);
            this.pbImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(115, 98);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Location = new System.Drawing.Point(141, 88);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(113, 22);
            this.btnPicture.TabIndex = 9;
            this.btnPicture.Text = "Dodaj sliku";
            this.btnPicture.UseVisualStyleBackColor = false;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlayerForm";
            this.Size = new System.Drawing.Size(419, 123);
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
