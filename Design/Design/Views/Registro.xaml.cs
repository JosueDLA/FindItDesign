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
	public partial class Registro : ContentPage
	{
		public Registro ()
		{
			InitializeComponent();
            imgWallpaper.Source = ImageSource.FromFile("wallpaper2.jpg");
            imgWallpaper.Aspect = Aspect.AspectFill;

            imgLogo.Source = ImageSource.FromFile("findit_logo2.png");
            imgLogo.WidthRequest = 200;
            imgLogo.HeightRequest = 200;
            imgLogo.Margin = new Thickness(0, 20, 0, 5);
        }
	}
}