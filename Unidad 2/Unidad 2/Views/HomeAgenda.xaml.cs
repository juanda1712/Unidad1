using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad_2.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using Unidad_2.Views.PopUp;
using Unidad_2.Models;

namespace Unidad_2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeAgenda : ContentPage
    {
        public HomeAgenda()
        {
            InitializeComponent();
            BindingContext = new ContactosViewModel();

        }

   

        private void ListVAgenda_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopUpDetailContact(e.SelectedItem as ContactosModel)); 
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new NewContact(), true);
        }
    }
}