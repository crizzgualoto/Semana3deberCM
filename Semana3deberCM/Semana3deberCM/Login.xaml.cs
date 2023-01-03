using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3deberCM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = "CristhianMoyolema2022";
            string contraseña = "uisrael2022";
            if(usuario==txtusuario.Text && contraseña==txtcontraseña.Text)
                {
                Navigation.PushAsync(new principal(usuario));
            }
            else {
                DisplayAlert("alerta","USUARIO / CONTRASEÑA SON INCORRECTOS","cerrar");
            }


        }
    }
}