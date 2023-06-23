using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cRodriguezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string clave = "uisrael2023";
            if(txtUser.Text == usuario && txtInClave.Text== clave) { Navigation.PushAsync(new Registro()); }
            else
            {
                DisplayAlert("Alerta", "Usuario no registrado", "Cerrar");
            }
        }
    }
}