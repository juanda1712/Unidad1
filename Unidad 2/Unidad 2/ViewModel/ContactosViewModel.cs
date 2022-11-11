using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Input;
using Unidad_2.Models;

namespace Unidad_2.ViewModel
{
    public class ContactosViewModel:BaseViewModel
    {

        #region Att
        public string nombre;
        public string numero;
        public string imagen;
        public int id;
        public object ListViewSource;

        #endregion

        #region Prop
        public string NombreTxt
        {
            get { return this.nombre; }
            set { SetValue(ref this.nombre, value); }
        }

        public string NumeroTxt
        {
            get { return this.numero; }
            set { SetValue(ref this.numero, value); }
        }


        public int IDTxt
        {
            get { return this.id; }
            set { SetValue(ref this.id, value); }
        }


        public string ImgTxt
        {
            get { return this.imagen; }
            set { SetValue(ref this.imagen, value); }
        }


        public object ListViewSourceObj
        {
            get { return this.ListViewSource; }
            set { SetValue(ref this.ListViewSource, value); }
        }



        #endregion


        #region Command
        public ICommand UpdateCommand
        {
            get
            {
                return new RelayCommand(UpdateContactMethod);
            }

        }

        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterContactMethod);
            }

        }

        public ICommand DeleteCommand
        {
            get
            {
                return new RelayCommand(DeleteContactMethod);
            }

        }

        #endregion

        #region Method
        public async void RegisterContactMethod()
        { }
        public async void UpdateContactMethod()
        { }
        public async void DeleteContactMethod()
        { }

        public async void LoadContactMethod()
        {
            ListViewSourceObj =  await App.Db.GetTableModel<ContactosModel>();
        }



        #endregion


        public ContactosViewModel()
        {
            LoadContactMethod();
        }
    
    }
}
