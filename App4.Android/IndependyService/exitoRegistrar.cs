using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App4.DependencyMessage;
using App4.Droid.IndependyService;
using Xamarin.Forms;

[assembly: Dependency(typeof(exitoRegistrar))]
namespace App4.Droid.IndependyService
{
    class exitoRegistrar : Imessage
    {
        public string GetMessage()
        {
            return "Usuario creado exitosamente";
        }
    }
}