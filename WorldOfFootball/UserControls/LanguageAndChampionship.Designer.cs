namespace WorldOfFootball.UserControls
{
    partial class LanguageAndChampionship
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbCroatian = new System.Windows.Forms.RadioButton();
            this.gbChampionship = new System.Windows.Forms.GroupBox();
            this.rbMens = new System.Windows.Forms.RadioButton();
            this.rbWomens = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbChampionship.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEnglish);
            this.groupBox1.Controls.Add(this.rbCroatian);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(507, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberite jezik";
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(353, 57);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(111, 32);
            this.rbEnglish.TabIndex = 1;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "Engleski";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbCroatian
            // 
            this.rbCroatian.AutoSize = true;
            this.rbCroatian.Location = new System.Drawing.Point(96, 57);
            this.rbCroatian.Name = "rbCroatian";
            this.rbCroatian.Size = new System.Drawing.Size(113, 32);
            this.rbCroatian.TabIndex = 0;
            this.rbCroatian.TabStop = true;
            this.rbCroatian.Text = "Hrvatski";
            this.rbCroatian.UseVisualStyleBackColor = true;
            // 
            // gbChampionship
            // 
            this.gbChampionship.Controls.Add(this.rbMens);
            this.gbChampionship.Controls.Add(this.rbWomens);
            this.gbChampionship.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbChampionship.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbChampionship.Location = new System.Drawing.Point(507, 268);
            this.gbChampionship.Name = "gbChampionship";
            this.gbChampionship.Size = new System.Drawing.Size(569, 125);
            this.gbChampionship.TabIndex = 2;
            this.gbChampionship.TabStop = false;
            this.gbChampionship.Text = "Izaberite prvenstvo";
            // 
            // rbMens
            // 
            this.rbMens.AutoSize = true;
            this.rbMens.Location = new System.Drawing.Point(353, 57);
            this.rbMens.Name = "rbMens";
            this.rbMens.Size = new System.Drawing.Size(96, 32);
            this.rbMens.TabIndex = 1;
            this.rbMens.TabStop = true;
            this.rbMens.Text = "Muško";
            this.rbMens.UseVisualStyleBackColor = true;
            // 
            // rbWomens
            // 
            this.rbWomens.AutoSize = true;
            this.rbWomens.Location = new System.Drawing.Point(96, 57);
            this.rbWomens.Name = "rbWomens";
            this.rbWomens.Size = new System.Drawing.Size(100, 32);
            this.rbWomens.TabIndex = 0;
            this.rbWomens.TabStop = true;
            this.rbWomens.Text = "Žensko";
            this.rbWomens.UseVisualStyleBackColor = true;
            // 
            // LanguageAndChampionship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbChampionship);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "LanguageAndChampionship";
            this.Size = new System.Drawing.Size(1582, 828);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbChampionship.ResumeLayout(false);
            this.gbChampionship.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbEnglish;
        private RadioButton rbCroatian;
        private GroupBox gbChampionship;
        private RadioButton rbMens;
        private RadioButton rbWomens;
    }
}
