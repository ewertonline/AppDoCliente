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
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Children.Add(
                new NavigationPage(new VehicleHistoryPage())
                {
                    Title = "Histórico",
                    Icon = Device.OnPlatform("tab_feed.png", null, null)
                });
            this.Children.Add(
                new NavigationPage(new ImageGalleryPage())
                {
                    Title = "Imagens",
                    Icon = Device.OnPlatform("tab_about.png", null, null)
                });
            this.Children.Add(
                new NavigationPage(new CustomerDataPage())
                {
                    Title = "Cliente",
                    Icon = Device.OnPlatform("tab_about.png", null, null)
                }
            );
        }
    }
}