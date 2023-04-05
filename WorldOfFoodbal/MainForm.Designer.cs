namespace WorldOfFoodbal
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(235, 56);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(372, 28);
            this.cbTeams.TabIndex = 0;
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 20;
            this.lbTeams.Location = new System.Drawing.Point(116, 105);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(264, 224);
            this.lbTeams.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.cbTeams);
            this.Name = "MainForm";
            this.Text = "World of Foodball";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbTeams;
        private ListBox lbTeams;
    }
}