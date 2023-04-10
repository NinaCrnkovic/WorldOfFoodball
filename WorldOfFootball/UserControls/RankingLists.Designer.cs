namespace WorldOfFootball.UserControls
{
    partial class RankingLists
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
            this.lblAllPlayers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgRankings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRankings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllPlayers
            // 
            this.lblAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblAllPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAllPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllPlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAllPlayers.Location = new System.Drawing.Point(49, 20);
            this.lblAllPlayers.Name = "lblAllPlayers";
            this.lblAllPlayers.Size = new System.Drawing.Size(394, 26);
            this.lblAllPlayers.TabIndex = 8;
            this.lblAllPlayers.Text = "Broj golova";
            this.lblAllPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(498, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Broj žutih kartona";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(947, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Broj posjetitelja";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgRankings
            // 
            this.dgRankings.AllowUserToAddRows = false;
            this.dgRankings.AllowUserToDeleteRows = false;
            this.dgRankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRankings.Location = new System.Drawing.Point(58, 79);
            this.dgRankings.Name = "dgRankings";
            this.dgRankings.ReadOnly = true;
            this.dgRankings.RowTemplate.Height = 25;
            this.dgRankings.Size = new System.Drawing.Size(1283, 505);
            this.dgRankings.TabIndex = 11;
            // 
            // RankingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgRankings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllPlayers);
            this.Name = "RankingLists";
            this.Size = new System.Drawing.Size(1384, 621);
            this.Load += new System.EventHandler(this.RankingLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRankings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAllPlayers;
        private Label label1;
        private Label label2;
        private DataGridView dgRankings;
    }
}
