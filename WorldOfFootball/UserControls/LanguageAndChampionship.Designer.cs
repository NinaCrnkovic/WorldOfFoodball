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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageAndChampionship));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbCroatian = new System.Windows.Forms.RadioButton();
            this.gbChampionship = new System.Windows.Forms.GroupBox();
            this.rbMens = new System.Windows.Forms.RadioButton();
            this.rbWomens = new System.Windows.Forms.RadioButton();
            this.btnNextLangAndChamp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbChampionship.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.rbEnglish);
            this.groupBox1.Controls.Add(this.rbCroatian);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rbEnglish
            // 
            resources.ApplyResources(this.rbEnglish, "rbEnglish");
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.TabStop = true;
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbCroatian
            // 
            resources.ApplyResources(this.rbCroatian, "rbCroatian");
            this.rbCroatian.Name = "rbCroatian";
            this.rbCroatian.TabStop = true;
            this.rbCroatian.UseVisualStyleBackColor = true;
            // 
            // gbChampionship
            // 
            resources.ApplyResources(this.gbChampionship, "gbChampionship");
            this.gbChampionship.Controls.Add(this.rbMens);
            this.gbChampionship.Controls.Add(this.rbWomens);
            this.gbChampionship.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbChampionship.Name = "gbChampionship";
            this.gbChampionship.TabStop = false;
            // 
            // rbMens
            // 
            resources.ApplyResources(this.rbMens, "rbMens");
            this.rbMens.Name = "rbMens";
            this.rbMens.TabStop = true;
            this.rbMens.UseVisualStyleBackColor = true;
            // 
            // rbWomens
            // 
            resources.ApplyResources(this.rbWomens, "rbWomens");
            this.rbWomens.Name = "rbWomens";
            this.rbWomens.TabStop = true;
            this.rbWomens.UseVisualStyleBackColor = true;
            // 
            // btnNextLangAndChamp
            // 
            resources.ApplyResources(this.btnNextLangAndChamp, "btnNextLangAndChamp");
            this.btnNextLangAndChamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnNextLangAndChamp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnNextLangAndChamp.Name = "btnNextLangAndChamp";
            this.btnNextLangAndChamp.UseVisualStyleBackColor = false;
            // 
            // LanguageAndChampionship
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.BackgroundImage = global::WorldOfFootball.Properties.Resources.background1;
            this.Controls.Add(this.btnNextLangAndChamp);
            this.Controls.Add(this.gbChampionship);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "LanguageAndChampionship";
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
        private Button btnNextLangAndChamp;
    }
}
