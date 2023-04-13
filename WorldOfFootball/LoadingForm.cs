using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfFootball
{
    public partial class LoadingForm : Form
    {
       
        public LoadingForm()
        {

            InitializeComponent();
            this.DoubleBuffered = true;
            this.ControlBox = false;
            this.BringToFront();
            ImageAnimator.Animate(pbLoading.Image, OnFrameChanged);

        }
        public void StartLoader()
        {
            this.Visible = true;
            this.BringToFront();
            
        }

        public async void StopLoader()
        {
            await Task.Delay(0);
            this.Visible = false;
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            // Osigurajte da se PictureBox ažurira s novim okvirom animacije
            pbLoading.Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Zaustavite animaciju kada se forma zatvori
            ImageAnimator.StopAnimate(pbLoading.Image, OnFrameChanged);
        }

    }

}
