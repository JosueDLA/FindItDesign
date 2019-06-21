using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Design.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntidadCrear : ContentPage
	{
		public EntidadCrear ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            TimeSpan tiempo = TimeSpan.FromTicks(10000); ;
            var position = await locator.GetPositionAsync(tiempo);

            lblLatitud.Text = position.Latitude.ToString();
            lblLongitud.Text = position.Longitude.ToString();
        }
    }
}