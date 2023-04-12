using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfFootball.CustomDesign;
using WorldOfFootball.EventsAndArgs;

namespace WorldOfFootball.UserControls
{
    public partial class LanguageAndChampionship : UserControl
    {
        public LanguageAndChampionship()
        {
            InitializeComponent();
            btnNextLangAndChamp.Click += btnNextLangAndChamp_Click;

        }
        public event EventHandler<LanguageAndChampionshipEventArgs> LangAndChamp;
        private void btnNextLangAndChamp_Click(object sender, EventArgs e)
        {
            // Provjera da li je odabran jezik i prvenstvo
            if (gbLanguage.Controls.OfType<RadioButton>().Any(rb => rb.Checked) &&
                gbChampionship.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
            {
                
                // Pronalazak odabranog jezika
                RadioButton selectedLanguage = gbLanguage.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
                string language = selectedLanguage.Tag.ToString();

                // Pronalazak odabranog prvenstva
                RadioButton selectedChampionship = gbChampionship.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
                string championship = selectedChampionship.Tag.ToString();

                var result = CustomMessageBox.Show( $"Da li ste sigurni da želite postaviti  {(language == "hr" ? "Hrvatski" : "Engleski")} jezik i {(championship == "Mens" ? "muško" : "žensko")} prvenstvo?", "Upozorenje", MessageBoxButtons.OKCancel);
           
                // Slanje podataka u event args
                if (result == DialogResult.Yes)
                {
                    LangAndChamp?.Invoke(this, new LanguageAndChampionshipEventArgs { Language = language, Championship = championship });
                }
                
            }
            else
            {
                // Bacanje greške ako nijedan radio button nije odabran
                CustomMessageBox.Show("Niste izabrali jezik i prvenstvo", "Upozorenje", MessageBoxButtons.OK);
            }
        }
    }
}
