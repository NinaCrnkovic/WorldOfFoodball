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
            this.lblAllPlayers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrintGoals = new System.Windows.Forms.Button();
            this.pnlGoals = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.btnPrintCartons = new System.Windows.Forms.Button();
            this.pnlVisitors = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrintVisitors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAllPlayers
            // 
            this.lblAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.lblAllPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAllPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllPlayers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAllPlayers.Location = new System.Drawing.Point(56, 27);
            this.lblAllPlayers.Name = "lblAllPlayers";
            this.lblAllPlayers.Size = new System.Drawing.Size(414, 35);
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
            this.label1.Location = new System.Drawing.Point(587, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 35);
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
            this.label2.Location = new System.Drawing.Point(1119, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Broj posjetitelja";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCards
            // 
            this.pnlCards.AllowDrop = true;
            this.pnlCards.AutoScroll = true;
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlCards.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCards.Location = new System.Drawing.Point(587, 64);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(414, 661);
            this.pnlCards.TabIndex = 12;
            // 
            // btnPrintGoals
            // 
            this.btnPrintGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnPrintGoals.FlatAppearance.BorderSize = 0;
            this.btnPrintGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintGoals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintGoals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintGoals.Location = new System.Drawing.Point(56, 732);
            this.btnPrintGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintGoals.Name = "btnPrintGoals";
            this.btnPrintGoals.Size = new System.Drawing.Size(414, 31);
            this.btnPrintGoals.TabIndex = 0;
            this.btnPrintGoals.Text = "Print";
            this.btnPrintGoals.UseCompatibleTextRendering = true;
            this.btnPrintGoals.UseVisualStyleBackColor = false;
            // 
            // pnlGoals
            // 
            this.pnlGoals.AllowDrop = true;
            this.pnlGoals.AutoScroll = true;
            this.pnlGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlGoals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGoals.Location = new System.Drawing.Point(56, 64);
            this.pnlGoals.Name = "pnlGoals";
            this.pnlGoals.Size = new System.Drawing.Size(414, 661);
            this.pnlGoals.TabIndex = 13;
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
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // btnPrintCartons
            // 
            this.btnPrintCartons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnPrintCartons.FlatAppearance.BorderSize = 0;
            this.btnPrintCartons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCartons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintCartons.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintCartons.Location = new System.Drawing.Point(587, 732);
            this.btnPrintCartons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintCartons.Name = "btnPrintCartons";
            this.btnPrintCartons.Size = new System.Drawing.Size(414, 31);
            this.btnPrintCartons.TabIndex = 14;
            this.btnPrintCartons.Text = "Print";
            this.btnPrintCartons.UseCompatibleTextRendering = true;
            this.btnPrintCartons.UseVisualStyleBackColor = false;
            // 
            // pnlVisitors
            // 
            this.pnlVisitors.AllowDrop = true;
            this.pnlVisitors.AutoScroll = true;
            this.pnlVisitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pnlVisitors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlVisitors.Location = new System.Drawing.Point(1119, 64);
            this.pnlVisitors.Name = "pnlVisitors";
            this.pnlVisitors.Size = new System.Drawing.Size(414, 661);
            this.pnlVisitors.TabIndex = 15;
            // 
            // btnPrintVisitors
            // 
            this.btnPrintVisitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnPrintVisitors.FlatAppearance.BorderSize = 0;
            this.btnPrintVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintVisitors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintVisitors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintVisitors.Location = new System.Drawing.Point(1119, 732);
            this.btnPrintVisitors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintVisitors.Name = "btnPrintVisitors";
            this.btnPrintVisitors.Size = new System.Drawing.Size(414, 31);
            this.btnPrintVisitors.TabIndex = 16;
            this.btnPrintVisitors.Text = "Print";
            this.btnPrintVisitors.UseCompatibleTextRendering = true;
            this.btnPrintVisitors.UseVisualStyleBackColor = false;
            // 
            // RankingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnPrintVisitors);
            this.Controls.Add(this.pnlVisitors);
            this.Controls.Add(this.btnPrintCartons);
            this.Controls.Add(this.pnlGoals);
            this.Controls.Add(this.btnPrintGoals);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllPlayers);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RankingLists";
            this.Size = new System.Drawing.Size(1582, 828);
            this.Load += new System.EventHandler(this.RankingLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAllPlayers;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel pnlCards;
        private Button btnPrintGoals;
        private FlowLayoutPanel pnlGoals;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintDialog printDialog;
        private PrintPreviewDialog printPreviewDialog;
        private PageSetupDialog pageSetupDialog;
        private Button btnPrintCartons;
        private FlowLayoutPanel pnlVisitors;
        private Button btnPrintVisitors;
    }
}
