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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            imgWallpaper.Source = ImageSource.FromFile("wallpaper.jpg");
            imgWallpaper.Aspect = Aspect.AspectFill;

            imgLogo.Source = ImageSource.FromFile("findit_logo2.png");
            imgLogo.WidthRequest = 200;
            imgLogo.HeightRequest = 200;
            imgLogo.Margin = new Thickness(0, 20, 0, 20);

            imgFb.Source = ImageSource.FromFile("fb_logo.png");
            imgFb.WidthRequest = 50;
            imgFb.HeightRequest = 50;

            imgTw.Source = ImageSource.FromFile("twitter_logo.png");
            imgTw.WidthRequest = 50;
            imgTw.HeightRequest = 50;

            imgIg.Source = ImageSource.FromFile("ig_logo.png");
            imgIg.WidthRequest = 50;
            imgIg.HeightRequest = 50;
        }

        private async void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuCliente());
        }

        private async void LblRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}