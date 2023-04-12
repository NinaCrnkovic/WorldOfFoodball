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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingLists));
            this.lblGoals = new System.Windows.Forms.Label();
            this.lblCartons = new System.Windows.Forms.Label();
            this.lblVisitors = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrintGoals = new System.Windows.Forms.Button();
            this.pnlGoals = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintCartons = new System.Windows.Forms.Button();
            this.pnlVisitors = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrintVisitors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGoals
            // 
            resources.ApplyResources(this.lblGoals, "lblGoals");
            this.lblGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGoals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGoals.Name = "lblGoals";
            // 
            // lblCartons
            // 
            resources.ApplyResources(this.lblCartons, "lblCartons");
            this.lblCartons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblCartons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCartons.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCartons.Name = "lblCartons";
            // 
            // lblVisitors
            // 
            resources.ApplyResources(this.lblVisitors, "lblVisitors");
            this.lblVisitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVisitors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVisitors.Name = "lblVisitors";
            // 
            // pnlCards
            // 
            resources.ApplyResources(this.pnlCards, "pnlCards");
            this.pnlCards.AllowDrop = true;
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlCards.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCards.Name = "pnlCards";
            // 
            // btnPrintGoals
            // 
            resources.ApplyResources(this.btnPrintGoals, "btnPrintGoals");
            this.btnPrintGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnPrintGoals.FlatAppearance.BorderSize = 0;
            this.btnPrintGoals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintGoals.Name = "btnPrintGoals";
            this.btnPrintGoals.UseCompatibleTextRendering = true;
            this.btnPrintGoals.UseVisualStyleBackColor = false;
            // 
            // pnlGoals
            // 
            resources.ApplyResources(this.pnlGoals, "pnlGoals");
            this.pnlGoals.AllowDrop = true;
            this.pnlGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlGoals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGoals.Name = "pnlGoals";
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Name = "printPreviewDialog";
            // 
            // btnPrintCartons
            // 
            resources.ApplyResources(this.btnPrintCartons, "btnPrintCartons");
            this.btnPrintCartons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnPrintCartons.FlatAppearance.BorderSize = 0;
            this.btnPrintCartons.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintCartons.Name = "btnPrintCartons";
            this.btnPrintCartons.UseCompatibleTextRendering = true;
            this.btnPrintCartons.UseVisualStyleBackColor = false;
            // 
            // pnlVisitors
            // 
            resources.ApplyResources(this.pnlVisitors, "pnlVisitors");
            this.pnlVisitors.AllowDrop = true;
            this.pnlVisitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlVisitors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlVisitors.Name = "pnlVisitors";
            // 
            // btnPrintVisitors
            // 
            resources.ApplyResources(this.btnPrintVisitors, "btnPrintVisitors");
            this.btnPrintVisitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnPrintVisitors.FlatAppearance.BorderSize = 0;
            this.btnPrintVisitors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintVisitors.Name = "btnPrintVisitors";
            this.btnPrintVisitors.UseCompatibleTextRendering = true;
            this.btnPrintVisitors.UseVisualStyleBackColor = false;
            // 
            // RankingLists
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.Controls.Add(this.btnPrintVisitors);
            this.Controls.Add(this.pnlVisitors);
            this.Controls.Add(this.btnPrintCartons);
            this.Controls.Add(this.pnlGoals);
            this.Controls.Add(this.btnPrintGoals);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.lblVisitors);
            this.Controls.Add(this.lblCartons);
            this.Controls.Add(this.lblGoals);
            this.Name = "RankingLists";
            this.Load += new System.EventHandler(this.RankingLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblGoals;
        private Label lblCartons;
        private Label lblVisitors;
        private FlowLayoutPanel pnlCards;
        private Button btnPrintGoals;
        private FlowLayoutPanel pnlGoals;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintDialog printDialog;
        private PrintPreviewDialog printPreviewDialog;
        private Button btnPrintCartons;
        private FlowLayoutPanel pnlVisitors;
        private Button btnPrintVisitors;
    }
}
