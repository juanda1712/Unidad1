using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad_2.Models;
using Unidad_2.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unidad_2.Views.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpDetailContact
    {
        public PopUpDetailContact()
        {
            InitializeComponent();
        }


        public PopUpDetailContact(ContactosModel Item)
        {
            InitializeComponent();
            BindingContext = new ContactosViewModel(Item);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}