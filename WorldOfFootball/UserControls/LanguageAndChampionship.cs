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
        private string _language;
        public LanguageAndChampionship(string language)
        {
            if (language == null)
            {
                _language = "en";
            }
            else
            {
                _language = language;
            }
            InitializeComponent();
            btnNextLangAndChamp.Click += btnNextLangAndChamp_Click;

        }
        #region Events

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

                DialogResult result = CallAreYouShureMessage(language, championship);

                // Slanje podataka u event args
                if (result == DialogResult.Yes)
                {
                    LangAndChamp?.Invoke(this, new LanguageAndChampionshipEventArgs { Language = language, Championship = championship });
                }

            }
            else
            {
                CallDidNotChooseMessage();
            }
        }
        #endregion
        #region MessageBox callings
        private void CallDidNotChooseMessage()
        {
            string message = "";
            string warning = "";

            if (_language == "en")
            {
                message = Properties.Resources.messageChooseLangAndChampEn;
                warning = Properties.Resources.messageWarningEn;

            }
            else if (_language == "hr")
            {
                message = Properties.Resources.messageChooseLangAndChampHr;
                warning = Properties.Resources.messageWarningHr;
            }
            // Bacanje greške ako nijedan radio button nije odabran
            CustomMessageBox.Show(message, warning, MessageBoxButtons.OK, _language);
        }

        
        private DialogResult CallAreYouShureMessage(string language, string championship)
        {
            string message = "";
            string warning = "";
            string lan;
            string champ;


            if (_language == "en")
            {
                lan = language == "hr" ? "croatian" : "english";
                champ = championship == "Mens" ? "mens" : "womens";
                message = String.Format(Properties.Resources.messageLangAndChampEn, lan, champ);
                warning = Properties.Resources.messageWarningEn;
           
            }
            else if (_language == "hr")
            {
                lan = language == "hr" ? "hrvatski" : "engleski";
                champ = championship == "Mens" ? "muško" : "žensko";
                message = String.Format(Properties.Resources.messageLangAndChampHr, lan, champ);
                warning = Properties.Resources.messageWarningHr;
           
            }
     

            var result = CustomMessageBox.Show(message, warning, MessageBoxButtons.OKCancel, _language);
            return result;
        }
        #endregion
    }
}
