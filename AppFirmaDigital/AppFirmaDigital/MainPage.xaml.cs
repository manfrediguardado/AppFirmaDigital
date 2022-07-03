using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SignaturePad.Forms;
using System.IO;

namespace AppFirmaDigital
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Stream image = await PadView.GetImageStreamAsync(SignatureImageFormat.Jpeg);
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            PadView.Clear();

        }
    }
}
