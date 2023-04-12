using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfFootball.CustomDesign
{
    public class CustomMessageBox 
    {
      
        public static DialogResult Show(string message, string title, MessageBoxButtons buttons)
        {
            Form form = new Form();
            Label label = new Label();
            Button button1 = new Button();
            Button button2 = new Button();


            form.Text = title;
            label.Text = message;

            switch (buttons)
            {
                case MessageBoxButtons.OKCancel:
                    button1.Text = "U redu";
                    button2.Text = "Odustani";

                    form.AcceptButton = button1;
                    form.CancelButton = button2;
                    break;

                case MessageBoxButtons.YesNo:
                    button1.Text = "Da";
                    button2.Text = "Ne";
                    form.AcceptButton = button1;
                    form.CancelButton = button2;
                    break;

                default:
                    button1.Visible = false;
                    button2.Text = "OK";

                    form.AcceptButton = button2;
                    break;
            }

            button1.BackColor = Color.FromArgb(15, 76, 117);
            button2.BackColor = Color.FromArgb(15, 76, 117);


            button1.ForeColor = Color.WhiteSmoke;
            button2.ForeColor = Color.WhiteSmoke;


            button1.DialogResult = DialogResult.Yes;
            button2.DialogResult = DialogResult.No;
            //(buttons == MessageBoxButtons.YesNo) ? DialogResult.Yes : DialogResult.OK;

            form.AcceptButton = button1;
            form.CancelButton = button2;

            //Dodajte sljedeće linije ispod

            form.KeyPreview = true;
            form.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    button1.PerformClick();

                if (e.KeyCode == Keys.Escape)
                    button2.PerformClick();
            };


            label.SetBounds(9, 20, 372, 13);

            button1.SetBounds(10, 110, 85, 30);
            button2.SetBounds(100, 110, 85, 30);


            label.AutoSize = true;
            label.Font = new Font("Arial", 12);
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;


            form.ClientSize = new Size(200, 150);
            form.Controls.AddRange(new Control[] { label, button1, button2 });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BackColor = Color.FromArgb(27,38,44);
            label.ForeColor = Color.WhiteSmoke;

            DialogResult dialogResult = form.ShowDialog();
            form.Dispose();
            return dialogResult;
        }
    }
}
