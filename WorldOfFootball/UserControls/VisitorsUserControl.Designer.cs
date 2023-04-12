namespace WorldOfFootball.UserControls
{
    partial class VisitorsUserControl
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
            this.lblTeams = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblVisitors = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeams
            // 
            this.lblTeams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeams.Location = new System.Drawing.Point(0, 0);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(210, 23);
            this.lblTeams.TabIndex = 0;
            this.lblTeams.Text = "Croatia : Croatia";
            this.lblTeams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorldOfFootball.Properties.Resources.location_mark;
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WorldOfFootball.Properties.Resources.people;
            this.pictureBox2.Location = new System.Drawing.Point(227, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(53, 53);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(168, 20);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVisitors
            // 
            this.lblVisitors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVisitors.Location = new System.Drawing.Point(277, 33);
            this.lblVisitors.Name = "lblVisitors";
            this.lblVisitors.Size = new System.Drawing.Size(59, 39);
            this.lblVisitors.TabIndex = 4;
            this.lblVisitors.Text = "12589";
            this.lblVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndex
            // 
            this.lblIndex.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIndex.Location = new System.Drawing.Point(301, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(35, 33);
            this.lblIndex.TabIndex = 10;
            this.lblIndex.Text = "23";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVenue
            // 
            this.lblVenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVenue.Location = new System.Drawing.Point(53, 32);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(168, 20);
            this.lblVenue.TabIndex = 11;
            this.lblVenue.Text = "Location";
            this.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Visitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblVisitors);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTeams);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Visitors";
            this.Size = new System.Drawing.Size(336, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTeams;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblLocation;
        private Label lblVisitors;
        private Label lblIndex;
        private Label lblVenue;
    }
}
