using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Unidad_2.ViewModel
{
    internal class LoginViewModel : BaseViewModel
    {
        #region Atributos
        public string user;
        public string password;
        #endregion

        #region  Propiedades
        public string UserTxt
        {
            get { return user; }
            set { SetValue(ref this.user, value); }
        }

        public string PasswordTxt
        {
            get { return password; }
            set { SetValue(ref this.password, value); }
        }

        #endregion

        #region  Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(LoginMethod);
            }

        }

        #endregion

        #region Methods
        public async void LoginMethod()
        {
            if(UserTxt.ToString() == "admin"  && PasswordTxt.ToString() == "1234")
            {
               await Application.Current.MainPage.DisplayAlert("Welcome", "Bienvenido", "Aceptar");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Usuario incorrecto", "Aceptar");
            }

        }
        #endregion

    }
}
