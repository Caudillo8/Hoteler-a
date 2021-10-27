using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelería
{
    class CHabitacion
    {
        private byte nroHabitacion;
        private byte cantCamas;
        private bool vistaAlmar;
        private bool Disponibilidad;

        public CHabitacion(byte nro, byte cant, bool vista, bool dispo)
        {
            this.nroHabitacion = nro;
            this.cantCamas = cant;
            this.vistaAlmar = vista;
            this.Disponibilidad = dispo;

        }
        //public CHabitacion() { }
        public byte GetNroHabitacion() { return this.nroHabitacion; }
        public void SetNroHabitacion(byte nro) { this.nroHabitacion = nro; }
        public byte GetCamas() { return this.cantCamas; }
        public void SetCamas(byte cant) { this.cantCamas = cant; }
        public bool GetVista() { return this.vistaAlmar; }
        public void SetVista (bool mar){ this.vistaAlmar=mar; }
        public bool GetDispo() { return this.Disponibilidad; }
        public void SetDispo(bool disp) { this.Disponibilidad = disp; }
       
        public string DarDatos()
        {
            string datos;
            datos = ("NRO HABITACION:   "+this.GetNroHabitacion());
            datos += ("     CANTIDAD CAMAS:    " + this.GetCamas());
            datos += ("     VISTA AL MAR:    " + this.GetVista());
            datos += ("     DISPONIBILIDAD:    " + this.GetDispo());
            return datos;
        }




    }
}
