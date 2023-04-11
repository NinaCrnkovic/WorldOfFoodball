namespace WorldOfFootball.UserControls
{
    partial class GoalorCarton
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
            this.opImg = new WorldOfFootball.CustomDesign.OvalPictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbGoalOrCard = new System.Windows.Forms.PictureBox();
            this.lblGoals = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoalOrCard)).BeginInit();
            this.SuspendLayout();
            // 
            // opImg
            // 
            this.opImg.BackColor = System.Drawing.Color.DarkGray;
            this.opImg.Image = global::WorldOfFootball.Properties.Resources.Maradona;
            this.opImg.Location = new System.Drawing.Point(3, 3);
            this.opImg.Name = "opImg";
            this.opImg.Size = new System.Drawing.Size(77, 70);
            this.opImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opImg.TabIndex = 0;
            this.opImg.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(101, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ime i prezime";
            // 
            // pbGoalOrCard
            // 
            this.pbGoalOrCard.Image = global::WorldOfFootball.Properties.Resources.yellow_card;
            this.pbGoalOrCard.Location = new System.Drawing.Point(101, 35);
            this.pbGoalOrCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbGoalOrCard.Name = "pbGoalOrCard";
            this.pbGoalOrCard.Size = new System.Drawing.Size(39, 34);
            this.pbGoalOrCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGoalOrCard.TabIndex = 7;
            this.pbGoalOrCard.TabStop = false;
            // 
            // lblGoals
            // 
            this.lblGoals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGoals.Location = new System.Drawing.Point(146, 35);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(38, 34);
            this.lblGoals.TabIndex = 8;
            this.lblGoals.Text = "12";
            this.lblGoals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndex
            // 
            this.lblIndex.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIndex.Location = new System.Drawing.Point(298, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(35, 33);
            this.lblIndex.TabIndex = 9;
            this.lblIndex.Text = "23";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoalorCarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.pbGoalOrCard);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.opImg);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "GoalorCarton";
            this.Size = new System.Drawing.Size(336, 75);
            ((System.ComponentModel.ISupportInitialize)(this.opImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoalOrCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDesign.OvalPictureBox opImg;
        private Label lblName;
        private PictureBox pbGoalOrCard;
        private Label lblGoals;
        private Label lblIndex;
    }
}
