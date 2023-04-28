using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EccobanckAdmin.View;
using EccobanckAdmin.View.Config;

namespace EccobanckAdmin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Mainmenu();
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
