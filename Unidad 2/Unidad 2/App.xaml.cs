using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Unidad_2.DataBase;
using Unidad_2.Models;
using Unidad_2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unidad_2
{
    public partial class App : Application
    {
        static DataBaseQuery database;


        public static DataBaseQuery Db
        {
            get 
            {
                if(database == null)
                {
                    database = new DataBaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBAPP.db"));
                }
                return database;

            }

        }

        public App()
        {
            InitializeComponent();

            MainPage = new CustomNav(new Login());
        }

        protected override void OnStart()
        {


            //UserModel user = new UserModel();
            //user.Nombre = "Juan";
            //user.UserName = "jdl";
            //user.Password = "1234";

            //var resul = App.Db.SaveUserModelAsync(user);


            List<UserModel> Listusers = new List<UserModel>();

            Listusers = App.Db.GetUserModel().Result;

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
