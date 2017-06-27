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
    public partial class CustomerDataPage : ContentPage
    {
        public CustomerDataPage()
        {
            InitializeComponent();
            BindingContext = new CustomerDataViewModel();
        }
    }
}
