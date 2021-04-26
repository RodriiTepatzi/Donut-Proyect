using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Donut_Proyect.Models;

namespace Donut_Proyect.Views
{
    public partial class GaleriaPage : ContentPage
    {
        public List<Carrusel> CarruselDataSource { get; set; }

        public GaleriaPage()
        {
            InitializeComponent();

            CarruselDataSource = new List<Carrusel>()
            {
                new Carrusel(){ source_img = "dona_1.jpg"},
                new Carrusel(){ source_img = "dona_2.jpg"},
                new Carrusel(){ source_img = "dona_3.jpg"},
                new Carrusel(){ source_img = "dona_4.jpg"},
                new Carrusel(){ source_img = "dona_5.jpg"},
                new Carrusel(){ source_img = "dona_6.jpg"},
                new Carrusel(){ source_img = "dona_7.jpg"},
                new Carrusel(){ source_img = "dona_8.jpg"},
                new Carrusel(){ source_img = "dona_9.jpg"},
                new Carrusel(){ source_img = "dona_10.jpg"}

            };
            BindingContext = this;
        }
    }
}