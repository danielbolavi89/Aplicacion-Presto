using App4.DependencyMessage;
using App4.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private  void EventConfrimRegister(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<DbTable>();

            var item = new DbTable()
            {
                Nombres = EntryNombres.Text,
                Cedula = EntryCedula.Text,
                Celular = EntryCelular.Text,
                Contraseña = EntryContraseña.Text,
                ConfirmarContraseña = EntryNuevaContraseña.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var service = DependencyService.Get<Imessage>();
                var mensaje = service.GetMessage();

                
                await this.DisplayAlert("Exitoso", mensaje, "Ok");

                await Navigation.PushAsync(new Login());

            });
        }
    }
}