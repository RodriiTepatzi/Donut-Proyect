﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Donut_Proyect.Services;
using Donut_Proyect.Views;

namespace Donut_Proyect
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
