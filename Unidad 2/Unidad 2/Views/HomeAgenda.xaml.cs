using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad_2.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new NewContact(), true);
        }
    }
}