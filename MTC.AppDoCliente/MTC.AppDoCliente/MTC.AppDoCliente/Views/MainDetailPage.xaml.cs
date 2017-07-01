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
    public partial class MainDetailPage : TabbedPage
    {
        public MainDetailPage()
        {
            InitializeComponent();

            this.Children.Add(
                new NavigationPage(new ImageGalleryPage())
                {
                    Title = "Imagens",
                    Icon = "gallery.png"
                });
            this.Children.Add(
                new NavigationPage(new VehicleHistoryPage())
                {
                    Title = "Histórico",
                    Icon = "history.png"
                });
            this.Children.Add(
                new NavigationPage(new CustomerDataPage())
                {
                    Title = "Cliente",
                    Icon = "account.png"
                }
            );
        }
    }
}