using MTC.AppDoCliente.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTC.AppDoCliente.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPage : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public MainMenuPage()
        {
            InitializeComponent();
            BindingContext = new MainMenuViewModel();

            LabelIdentificacao.Text = "Olá, \nChico Buarque!";
        }
    }
}
