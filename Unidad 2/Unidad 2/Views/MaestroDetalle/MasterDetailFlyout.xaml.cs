using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Unidad_2.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unidad_2.Views.MaestroDetalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailFlyout : ContentPage
    {
        public ListView ListView;

        public MasterDetailFlyout()
        {
            InitializeComponent();

            BindingContext = new MasterDetailViewModel();
            ListView = MenuItemsListView;
        }

        //private class MasterDetailFlyoutViewModel : INotifyPropertyChanged
        //{
        //    public ObservableCollection<MasterDetailFlyoutMenuItem> MenuItems { get; set; }

        //    public MasterDetailFlyoutViewModel()
        //    {
        //        MenuItems = new ObservableCollection<MasterDetailFlyoutMenuItem>(new[]
        //        {
        //            new MasterDetailFlyoutMenuItem { Id = 0, Title = "Page 1" , TargetType = typeof(Eventos) },
        //            new MasterDetailFlyoutMenuItem { Id = 1, Title = "Page 2" },
        //            new MasterDetailFlyoutMenuItem { Id = 2, Title = "Page 3" },
        //            new MasterDetailFlyoutMenuItem { Id = 3, Title = "Page 4" },
        //            new MasterDetailFlyoutMenuItem { Id = 4, Title = "Page 5" },
        //        });
        //    }

        //    #region INotifyPropertyChanged Implementation
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        if (PropertyChanged == null)
        //            return;

        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //    #endregion
        //}
    }
}