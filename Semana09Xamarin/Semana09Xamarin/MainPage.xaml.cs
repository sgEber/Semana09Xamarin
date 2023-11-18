using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana09Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTapDemoClicked(object sender, EventArgs e)
        {
            // Navega a la página de demo de pulsación
        }

        private void OnSwipeDemoClicked(object sender, EventArgs e)
        {
            // Navega a la página de demo de deslizamiento
        }

        private void OnPinchDemoClicked(object sender, EventArgs e)
        {
            // Navega a la página de demo de pellizco
        }

        private void OnPanDemoClicked(object sender, EventArgs e)
        {
            // Navega a la página de demo de paneo
        }
    }
}
