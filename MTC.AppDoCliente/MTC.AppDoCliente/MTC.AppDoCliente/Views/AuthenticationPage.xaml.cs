using MTC.AppDoCliente.Services;
using MTC.AppDoCliente.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTC.AppDoCliente.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthenticationPage : ContentPage
    {
        public AuthenticationPage()
        {
            InitializeComponent();
            
            BindingContext = new AuthenticationViewModel();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                UserDialogs.Instance.Alert("Informe um usuário e senha válidos.");

                return;
            }*/

            //var loading = UserDialogs.Instance.Loading("Aguarde...");

            await FunilariaService.Autenticar(txtUsuario.Text, txtSenha.Text, 
                async () =>
                {
                    ((App)Application.Current).MainPage = new MainPage();
                    //Navigation.InsertPageBefore(mainPage1, this);
                    
                    await Navigation.PopAsync();

                    //loading.Hide();
                },
                (mensagem) =>
                {
                    //loading.Hide();

                    //UserDialogs.Instance.Alert(mensagem);
                });
        }
    }
}
