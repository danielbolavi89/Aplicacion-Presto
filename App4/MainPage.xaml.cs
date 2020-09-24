using App4.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();         
        }

        private async void EventCerrarSesion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
     
    }
}
