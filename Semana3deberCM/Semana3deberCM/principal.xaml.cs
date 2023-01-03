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
	public partial class principal : ContentPage
	{
		public principal (string usuario)
		{
			InitializeComponent ();
			lblusuario.Text = usuario;
		}

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            double seguimiento1 = Convert.ToDouble(txtseguimiento1.Text);
            double seguimiento2 = Convert.ToDouble(txtseguimiento2.Text);

            double examen1 = Convert.ToDouble(txtExamen1.Text);
            double examen2 = Convert.ToDouble(txtExamen2.Text);

            double nota1 = (seguimiento1 * 0.3) + (examen1 * 0.2);
            txtParcial1.Text = Convert.ToString(nota1);


            double nota2 = (seguimiento2 * 0.3) + (examen2 * 0.2);
            txtParcial2.Text = Convert.ToString(nota2);

            double notaf = nota1 + nota2;

            if (seguimiento1 >= 0 && seguimiento1 <= 10 && seguimiento2 >= 0 && seguimiento2 <= 10 && examen1 >= 0 && examen1 <= 10 && examen2 >= 0 && examen2 <= 10)
            {

                if (notaf > 0 && notaf < 5)
                {
                    lblEstado.Text = "Perdio el semestre";

                }
                else
                {
                    if (notaf >= 5 && notaf <= 6.9)
                    {
                        lblEstado.Text = "Complementario";

                    }
                    else
                    {
                        if (notaf >= 7 && notaf <= 10)
                        {
                            lblEstado.Text = "Aprobado";

                        }

                    }

                }

            }
            else
            {
                DisplayAlert("alerta", "el rango de notas es de 0 a 10", "cerrar");
            }
        }
    }
}