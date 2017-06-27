using MTC.AppDoCliente.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MTC.AppDoCliente
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (!IsAuthenticated)
                MainPage = new NavigationPage(new AuthenticationPage());
            else
                MainPage = new MainPage();
        }

        // TODO: Codificar a autenticação
        public bool IsAuthenticated
        {
            get { return false; }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
