using System.ComponentModel;
using Xamarin.Forms;

namespace Donut_Proyect.Views
{
    public partial class ContactoPage : ContentPage
    {
        public ContactoPage()
        {
            InitializeComponent();
            var browser = new WebView();
            browser.HorizontalOptions = LayoutOptions.FillAndExpand;
            browser.VerticalOptions = LayoutOptions.FillAndExpand;

            var source = new HtmlWebViewSource();
            var text = @"<body style=""background: #ffe3b3;""><center><iframe src = ""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3765.062556608674!2d-98.24026738509502!3d19.32309158694662!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x85cfd923538396cf%3A0x3a5b5bc1cb786921!2sBlvd.%20Leonarda%20G%C3%B3mez%20Blanco%2010%2C%2090160%20Acxotla%20del%20R%C3%ADo%2C%20Tlax.!5e0!3m2!1ses-419!2smx!4v1619391216225!5m2!1ses-419!2smx"" ""width=400""  height=""300"" style=""border:0;"" allowfullscreen=""false"" loading=""lazy""></iframe></center>";
            source.Html = text;
            browser.Source = source;
            webViewLayout.Children.Add(browser);
        }
        
    }
}