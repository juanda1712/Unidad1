using System;
using System.Collections.Generic;
using System.Text;
using Unidad_2.Models;
using Unidad_2.Views;

namespace Unidad_2.ViewModel
{
    internal class MasterDetailViewModel:BaseViewModel
    {

        #region Atributos
        public string icon;
        public string title;
        public object listViewSource;
        #endregion

        #region  Propiedades
        public string Icon
        {
            get { return icon; }
            set { SetValue(ref this.icon, value); }
        }

        public string Title
        {
            get { return title; }
            set { SetValue(ref this.title, value); }
        }
        public object ListViewSource
        {
            get { return this.listViewSource; }
            set { SetValue(ref this.listViewSource, value); }
        }
        #endregion




        public MasterDetailViewModel()
        {
            this.ListViewSource = new List<MenuLateralModel>(new[]
            {
                new MenuLateralModel{ Id = 0 , Title = "Service" , Icon= "icon.png" , TargetType= typeof(Service)  },
                 new MenuLateralModel{ Id = 0 , Title = "Contact" , Icon= "icon.png" , TargetType= typeof(NewContact)  }
            });


        }


    }


}
