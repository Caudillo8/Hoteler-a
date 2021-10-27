using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelería
{
    class CCliente
    {
        private string Nombre;

        public CCliente(string nom) { this.Nombre = nom; }

        public string nombreCliente//USO COMO PROPIEDAD
        {
            set { this.Nombre = value; }
            get { return this.Nombre; }
        }
        public string GetNombre() { return this.nombreCliente; }
        public void SetNombre(string nom) { this.nombreCliente = nom; }

    }
}
