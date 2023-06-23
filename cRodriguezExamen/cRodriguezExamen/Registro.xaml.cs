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
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario;
        }

        private void Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Pais.SelectedIndex == -1)
            {
                DisplayAlert("Alerta", "Seleccion invalida", "Cerrar");
            }
            else
            {
                DisplayAlert("Alerta", Pais.Items[Pais.SelectedIndex], "Cerrar");
            }
        }

        private void Ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Ciudad.SelectedIndex == -1)
            {
                DisplayAlert("Alerta", "Seleccion incorrecta", "Cerrar");
            }
            else
            {
                DisplayAlert("Alerta", Ciudad.Items[Ciudad.SelectedIndex], "Cerrar");
            }
        }

        private void btnPago_Clicked(object sender, EventArgs e)
        {

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {

        }
    }
}