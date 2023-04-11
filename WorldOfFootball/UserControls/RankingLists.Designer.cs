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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lblAllPlayers.Size = new System.Drawing.Size(362, 26);
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
            this.label1.Location = new System.Drawing.Point(514, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 26);
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
            this.label2.Location = new System.Drawing.Point(979, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 26);
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
            this.pnlCards.Location = new System.Drawing.Point(514, 48);
            this.pnlCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(362, 496);
            this.pnlCards.TabIndex = 12;
            // 
            // btnPrintGoals
            // 
            this.btnPrintGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnPrintGoals.FlatAppearance.BorderSize = 0;
            this.btnPrintGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintGoals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintGoals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintGoals.Location = new System.Drawing.Point(49, 549);
            this.btnPrintGoals.Name = "btnPrintGoals";
            this.btnPrintGoals.Size = new System.Drawing.Size(362, 23);
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
            this.pnlGoals.Location = new System.Drawing.Point(49, 48);
            this.pnlGoals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGoals.Name = "pnlGoals";
            this.pnlGoals.Size = new System.Drawing.Size(362, 496);
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
            this.btnPrintCartons.Location = new System.Drawing.Point(514, 549);
            this.btnPrintCartons.Name = "btnPrintCartons";
            this.btnPrintCartons.Size = new System.Drawing.Size(362, 23);
            this.btnPrintCartons.TabIndex = 14;
            this.btnPrintCartons.Text = "Print";
            this.btnPrintCartons.UseCompatibleTextRendering = true;
            this.btnPrintCartons.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(979, 48);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(362, 496);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(979, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Print";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RankingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnPrintCartons);
            this.Controls.Add(this.pnlGoals);
            this.Controls.Add(this.btnPrintGoals);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllPlayers);
            this.Name = "RankingLists";
            this.Size = new System.Drawing.Size(1384, 621);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
    }
}
