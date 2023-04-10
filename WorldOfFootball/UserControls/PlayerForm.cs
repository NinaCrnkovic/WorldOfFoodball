using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfFootball.CustomDesign;

namespace WorldOfFootball.UserControls
{
    public partial class PlayerForm : UserControl
    {
       
        public bool IsSelected { get; set; }
        public PlayerForm()
        {
        
        InitializeComponent();
        btnPicture.MouseClick += ChangeImage_Click;

        }

    

        private void ChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp|Sve datoteke|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = new Bitmap(openFileDialog.FileName);

                
            }
        }







    }
}
