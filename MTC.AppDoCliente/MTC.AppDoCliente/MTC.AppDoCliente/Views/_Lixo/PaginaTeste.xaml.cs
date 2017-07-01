using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTC.AppDoCliente.Views.PaginaTeste
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaTeste : MasterDetailPage
    {
        PaginaTesteMaster master = null;

        public PaginaTeste()
        {
            InitializeComponent();

            master = new PaginaTesteMaster();
            Detail = new MainPage();

            master.ListView.ItemSelected += ListView_ItemSelected;

            Master = master;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as PaginaTesteMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            //Detail = new NavigationPage(page);
            Detail = page;
            master.ListView.SelectedItem = null;
            IsPresented = false;

        }
    }

}
