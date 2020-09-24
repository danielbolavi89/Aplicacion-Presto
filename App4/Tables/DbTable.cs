using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Tables
{
    class DbTable
    {
        public Guid UserID { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Contraseña { get; set; }
        public string ConfirmarContraseña { get; set; }
    }
}
