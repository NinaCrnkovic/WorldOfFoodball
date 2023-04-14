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
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbCroatian = new System.Windows.Forms.RadioButton();
            this.gbChampionship = new System.Windows.Forms.GroupBox();
            this.rbMens = new System.Windows.Forms.RadioButton();
            this.rbWomens = new System.Windows.Forms.RadioButton();
            this.btnNextLangAndChamp = new System.Windows.Forms.Button();
            this.gbLanguage.SuspendLayout();
            this.gbChampionship.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLanguage
            // 
            resources.ApplyResources(this.gbLanguage, "gbLanguage");
            this.gbLanguage.Controls.Add(this.rbEnglish);
            this.gbLanguage.Controls.Add(this.rbCroatian);
            this.gbLanguage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.TabStop = false;
            // 
            // rbEnglish
            // 
            resources.ApplyResources(this.rbEnglish, "rbEnglish");
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Tag = "en";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbCroatian
            // 
            resources.ApplyResources(this.rbCroatian, "rbCroatian");
            this.rbCroatian.Name = "rbCroatian";
            this.rbCroatian.Tag = "hr";
            this.rbCroatian.UseVisualStyleBackColor = false;
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
            this.rbMens.Tag = "Mens";
            this.rbMens.UseVisualStyleBackColor = true;
            // 
            // rbWomens
            // 
            resources.ApplyResources(this.rbWomens, "rbWomens");
            this.rbWomens.Name = "rbWomens";
            this.rbWomens.Tag = "Womens";
            this.rbWomens.UseVisualStyleBackColor = true;
            // 
            // btnNextLangAndChamp
            // 
            resources.ApplyResources(this.btnNextLangAndChamp, "btnNextLangAndChamp");
            this.btnNextLangAndChamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnNextLangAndChamp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnNextLangAndChamp.FlatAppearance.BorderSize = 0;
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
            this.Controls.Add(this.gbLanguage);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "LanguageAndChampionship";
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.gbChampionship.ResumeLayout(false);
            this.gbChampionship.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbLanguage;
        private RadioButton rbEnglish;
        private GroupBox gbChampionship;
        private RadioButton rbMens;
        private RadioButton rbWomens;
        private Button btnNextLangAndChamp;
        private RadioButton rbCroatian;
    }
}
