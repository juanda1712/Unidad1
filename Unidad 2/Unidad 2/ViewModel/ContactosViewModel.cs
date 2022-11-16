using GalaSoft.MvvmLight.Command;
using Plugin.Messaging;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Input;
using Unidad_2.Models;
using Unidad_2.Views;
using Xamarin.Forms;

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

        public ICommand SmsCommand
        {
            get
            {
                return new RelayCommand(SmsContactMethod);
            }

        }

        #endregion

        #region Method
        public async void RegisterContactMethod()
        { }

        public async void SmsContactMethod()
        {
            var sms = CrossMessaging.Current.SmsMessenger;
            if(sms.CanSendSms)
            {
                sms.SendSms(numero, "Sms Xamarin App");
                await PopupNavigation.Instance.PopAsync(true);
            }
        
        }
        public async void UpdateContactMethod()
        {
            ContactosModel ObjCont = new ContactosModel();
            ObjCont.Nombre = nombre;
            ObjCont.ContactID = id;
            ObjCont.Telefono = numero;
            ObjCont.Imagen = imagen;



            await App.Db.SaveModelAsync<ContactosModel>(ObjCont, false);
            await Application.Current.MainPage.DisplayAlert("Ok", "Actualización Exitosa", "Ok");
            await Application.Current.MainPage.Navigation.PushAsync(new HomeAgenda());
            await PopupNavigation.Instance.PopAsync(true);
                




        }
        public async void DeleteContactMethod()
        {
            ContactosModel ObjCont = new ContactosModel();
            ObjCont.Nombre = nombre;
            ObjCont.ContactID = id;
            ObjCont.Telefono = numero;
            ObjCont.Imagen = imagen;



            await App.Db.DeleteModelAsync<ContactosModel>(ObjCont);
            await Application.Current.MainPage.DisplayAlert("Ok", "Eliminación Exitosa", "Ok");
            await Application.Current.MainPage.Navigation.PushAsync(new HomeAgenda());
            await PopupNavigation.Instance.PopAsync(true);

        }

        public async void LoadContactMethod()
        {
            ListViewSourceObj =  await App.Db.GetTableModel<ContactosModel>();
        }



        #endregion


        public ContactosViewModel()
        {
            LoadContactMethod();
        }

        public ContactosViewModel(ContactosModel item)
        {
            NombreTxt = item.Nombre;
            NumeroTxt = item.Telefono;
            IDTxt = item.ContactID;
            ImgTxt = item.Imagen;
           
        }


    }
}
