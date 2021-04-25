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
            GoCalculoCommand = new Command(OnCalculoClicked);
        }

        private async void OnCalculoClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(CalculoPage)}");
        }

        private void onTiposChanged(object sender, CheckedChangedEventArgs e)
        {
            
        }
    }
}