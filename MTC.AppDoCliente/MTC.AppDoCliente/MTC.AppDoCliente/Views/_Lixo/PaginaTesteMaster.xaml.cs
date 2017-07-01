using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTC.AppDoCliente.Views.PaginaTeste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaTesteMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public PaginaTesteMaster()
        {
            InitializeComponent();
            BindingContext = new PaginaTesteMasterViewModel();
        }



        public class PaginaTesteMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PaginaTesteMenuItem> MenuItems { get; }
            public PaginaTesteMasterViewModel()
            {
                MenuItems = new ObservableCollection<PaginaTesteMenuItem>(new[]
                {
                    new PaginaTesteMenuItem { Id = 0, Title = "Home", TargetType = typeof(MainPage) },
                    new PaginaTesteMenuItem { Id = 1, Title = "Contato" },
                    new PaginaTesteMenuItem { Id = 2, Title = "Sobre" },
                    new PaginaTesteMenuItem { Id = 3, Title = "Sair" },
                });
            }
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
