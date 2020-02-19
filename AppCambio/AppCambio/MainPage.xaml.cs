using System;
using System.ComponentModel;
using Xamarin.Forms;

using System.Globalization;

namespace AppCambio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /**
            Faz a conversão de Dolar para Real
        **/
        private void CalcularConversao(object sender, EventArgs e)
        {
            try
            {
                decimal reais = 0;

                decimal valorDolares = Convert.ToDecimal(valorDolar.Text);
                decimal valorEmReais = Convert.ToDecimal(qntEmReis.Text);

                reais = valorDolares * valorEmReais;
                
                //Metodo de conversão para valor em reais
                NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

                valorConvertido.Text = reais.ToString("C", nfi);

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ocorreu um erro!");
            }
        }
    }
}
