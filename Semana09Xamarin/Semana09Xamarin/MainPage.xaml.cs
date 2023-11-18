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

        async private void OnTapDemoClicked(object sender, EventArgs e)
        {
            // Navega a la página de demo de pulsación
            await Navigation.PushAsync(new TapDemo());
        }

        async private void OnSwipeDemoClicked(object sender, EventArgs e)
        {
            // Navega a la página de demo de deslizamiento
            await Navigation.PushAsync(new SwipeDemo());
        }

        async private void OnPinchDemoClicked(object sender, EventArgs e)
        {
            // Navega a la página de demo de pellizco
            await Navigation.PushAsync(new PinchDemo());
        }

        async private void OnPanDemoClicked(object sender, EventArgs e)
        {
            // Navega a la página de demo de paneo
            await Navigation.PushAsync(new PanDemo());
        }
    }
}
