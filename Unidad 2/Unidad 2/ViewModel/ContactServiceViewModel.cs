using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using Org.Apache.Http.Message;
using Plugin.LocalNotification;
using Unidad_2.Models;
using Xamarin.Forms;

namespace Unidad_2.ViewModel
{
    internal class ContactServiceViewModel : BaseViewModel
    {
        #region Att
        public string nombre;
        public string telefono;
        public string descripcion;
        public int idContacto;
        public int idTipo;
     

        #endregion

        #region Prop
        public string NombreTxt
        {
            get { return this.nombre; }
            set { SetValue(ref this.nombre, value); }
        }

        public string NumeroTxt
        {
            get { return this.telefono; }
            set { SetValue(ref this.telefono, value); }
        }


        #endregion


        #region Command
        public ICommand GetData
        {

            get 
            {
                return new RelayCommand(GetDataMethod);
            }
        }
        public ICommand PostData
        {

            get
            {
                return new RelayCommand(PostDataMethod);
            }
        }


        #endregion

        #region Method


        public async void GetDataMethod() 
        {

            var client = new HttpClient();
            string url = "http://www.contapp.somee.com/api/Contacto/Detalle?id=6";

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage RespServ = await client.SendAsync(request);

            HttpContent content = RespServ.Content;
            string data =  await content.ReadAsStringAsync();

            if( data != null)
            {
                var objContact = JsonConvert.DeserializeObject<ContactServiceModel>(data);

                NombreTxt = objContact.response.nombre;
                NumeroTxt = objContact.response.telefono;
            }
            else 
            { }


        
        }

        public async void PostDataMethod()
        {
            var client = new HttpClient();
            string url = "http://www.contapp.somee.com/api/Contacto/Guardar";

            Contacto objContact = new Contacto {
                idContacto = 0,
                nombre = "MIRIAM",
                descripcion = "HOLA SOY UN POST",
                telefono = "65526",
                idTipo = 1
            
            };

            var Body = JsonConvert.SerializeObject(objContact);
            var byteContent = new ByteArrayContent(Encoding.UTF8.GetBytes(Body));
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
           
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = byteContent;

            HttpResponseMessage RespServ = await client.SendAsync(request);

            HttpContent content = RespServ.Content;
            string data = await content.ReadAsStringAsync();

            string status = RespServ.StatusCode.ToString();
            await Application.Current.MainPage.DisplayAlert("Ok", "Almacenamiento Exitoso", "Aceptar");
            var notif = new NotificationRequest();
            notif.Description = "Contacto Almacenado";
            notif.Title = "APP Movil";
            notif.BadgeNumber = 2;
            notif.NotificationId = 123;

            await LocalNotificationCenter.Current.Show(notif);


        }
        #endregion


    }
}
