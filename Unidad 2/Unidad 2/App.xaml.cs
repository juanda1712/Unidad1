﻿using System;
using Unidad_2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unidad_2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Controles();
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
