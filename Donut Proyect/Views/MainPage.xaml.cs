using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Donut_Proyect.Views
{
    public partial class MainPage : ContentPage
    {
        public Command GoCalculoCommand { get; }

        public MainPage()
        {
            InitializeComponent();

            
            var browser = new WebView();
            browser.HorizontalOptions = LayoutOptions.FillAndExpand;
            browser.VerticalOptions = LayoutOptions.FillAndExpand;

            var source = new HtmlWebViewSource();
            var text = "<html>" +
                    "<body  style=\"text-align: justify; background: #ffe3b3;\" >" +
                    "<p> Esta aplicación está diseñada para que puedas ordenar tus donas de una forma más rápida y fácil, evitando así las largas filas en nuestra sucursal y poder así agilizar tu compra.</p> <p>Al ordenar tu dona, tienes diferentes opciones y estilos de ésta (Trigo, Centeno, Maíz, Germinado, Espelta), así como también rellenos: fresa, chocolate, vainilla, queso o merengue y diferentes cubiertas como : cereales, chispas, glaseado, nuez, chocolate, etc. </p> <p>Cuando termines de crear tu dona, la app te dará el total de tu compra, aplicando descuentos dependiendo de éste, si tu total a pagar es mayor a los $120 se te hará un descuento del 30% y si es mayor a $270 tu descuento será del 40%"
+ "</p> <p>¿Estás listo para ordenar?</p>" +
                    "</body>" +
                    "</html>";
            source.Html = text;
            browser.Source = source;
            
            webViewLayout.Children.Add(browser);
        }

    }
}