using MTC.AppDoCliente.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using MTC.AppDoCliente.Models;

namespace MTC.AppDoCliente.ViewModels
{
    public class MainMenuViewModel : BaseViewModel
    {
        public ObservableCollection<MainMenuItem> MenuItems { get; }
        public MainMenuViewModel()
        {
            MenuItems = new ObservableCollection<MainMenuItem>(new[]
            {
                    new MainMenuItem { Id = 0, Title = "Home", Icon = "home", TargetType = typeof(MainDetailPage) },
                    new MainMenuItem { Id = 1, Title = "Contato", Icon = "contact_us", TargetType = typeof(ContactUsPage) },
                    new MainMenuItem { Id = 2, Title = "Sobre", Icon = "about_us", TargetType = typeof(AboutUs) },
                    new MainMenuItem { Id = 3, Title = "Sair", Icon = "exit", TargetType = typeof(AuthenticationPage) },
                });
        }
    }
}
