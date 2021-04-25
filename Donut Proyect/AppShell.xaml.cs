using System;
using System.Collections.Generic;
using Donut_Proyect.ViewModels;
using Donut_Proyect.Views;
using Xamarin.Forms;

namespace Donut_Proyect
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(CalculoPage), typeof(CalculoPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }
    }
}
