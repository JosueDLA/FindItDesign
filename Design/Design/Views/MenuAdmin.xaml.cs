using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Design.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuAdmin : ContentPage
	{
		public MenuAdmin ()
		{
            InitializeComponent();

            var map = new Map(
            MapSpan.FromCenterAndRadius(
                new Position(14.5611095, -90.7344437), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;

            //Custom Pin para entidad
            var position = new Position(14.5611095, -90.7344437);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Empresa S.A.",
                Address = "Direccion"
            };
            map.Pins.Add(pin);

            var slider = new Slider(1, 18, 1);
            slider.ValueChanged += (sender, e) => {
                var zoomLevel = e.NewValue; // between 1 and 18
                var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
                map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongdegrees, latlongdegrees));
            };

        }
    }
}