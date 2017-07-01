using MTC.AppDoCliente.Models;
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
    public partial class MainPage : MasterDetailPage
    {
        MainMenuPage master = null;

        public MainPage()
        {
            InitializeComponent();

            master = new MainMenuPage();
            Detail = new MainDetailPage();

            master.ListView.ItemSelected += ListView_ItemSelected;

            Master = master;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            
            switch(item.Id)
            {
                case 0:
                    Detail = page;
                    break;
                case 1:
                case 2:
                    Detail = new NavigationPage(page);
                    break;
                case 3:
                    // TODO: LogOff
                    ((App)Application.Current).MainPage = new NavigationPage(new AuthenticationPage());
                    break;
            }
            master.ListView.SelectedItem = null;
            IsPresented = false;

        }
    }
}