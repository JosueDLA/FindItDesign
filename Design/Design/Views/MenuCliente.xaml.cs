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
	public partial class MenuCliente : TabbedPage
	{
        public MenuCliente()
        {
            InitializeComponent();

            var entidadTipo = new NavigationPage(new MenuAdmin());
            entidadTipo.Icon = "home.png";
            //entidadTipo.Title = "Entidades";

            var entidadOferta = new NavigationPage(new EntidadDetalle());
            entidadOferta.Icon = "whatshot.png";
            //entidadOferta.Title = "Ofertas";

            var entidadBuscar = new NavigationPage(new EntidadesOferta());
            entidadBuscar.Icon = "search.png";
            //entidadBuscar.Title = "Buscar";

            var administrador = new NavigationPage(new EntidadesOferta());
            administrador.Icon = "build.png";
            //administrador.Title = "Admin";

            Children.Add(entidadTipo);
            Children.Add(entidadOferta);
            Children.Add(entidadBuscar);
            Children.Add(administrador);
        }
	}
}