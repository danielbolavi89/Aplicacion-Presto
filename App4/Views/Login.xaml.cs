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
    public partial class Login : ContentPage
    {
        public Login()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }

        private async void EventButtonRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
        private void EventButtonLogin(object sender, EventArgs e)
        {

            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<DbTable>().Where(consult => consult.Nombres.Equals(EntryUser.Text) && consult.Contraseña.Equals(EntryPassword.Text)).FirstOrDefault();
            
            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {

                    var result = await this.DisplayAlert("Error", "Credenciales incorrectas", "Ok", "Cancelar");

                    if (result)
                    {
                        await Navigation.PushAsync(new Login());
                    }
                    else
                    {
                        await Navigation.PushAsync(new Login());
                    }

                });
            }
        }
    }
}