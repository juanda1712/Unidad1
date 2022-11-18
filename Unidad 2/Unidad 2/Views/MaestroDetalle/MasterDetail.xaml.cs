using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad_2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unidad_2.Views.MaestroDetalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail : FlyoutPage
    {
        public MasterDetail()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuLateralModel;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            FlyoutPage.ListView.SelectedItem = null;
        }
    }
}