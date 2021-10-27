using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelería
{
    class CReserva
    {
        private byte nroRSV;
        private CCliente cliente;
        private CHabitacion habitacion;

        public CReserva(byte nro, CCliente cli, CHabitacion hab)
        {
            this.nroRSV = nro;
            this.cliente = cli;
            this.habitacion = hab;
            this.habitacion.SetDispo(false) ;//la ocupo al momento de crear la rsv
        }
        public CReserva(){}

        public void SetNro (byte n) { this.nroRSV = n; }
        public byte GetNroRSV() { return this.nroRSV; }
        public CCliente GetCliente() { return this.cliente; }
        public void SetCliente(CCliente c) { this.cliente = c; }
        public void SetHabitacion(CHabitacion hab) { this.habitacion = hab; }
        public CHabitacion GetHabitacion() { return this.habitacion; }
        public string DarDatos()
        {
            string datos;
            datos = ("nro rsv:   " + this.GetNroRSV());
            datos += ("     CLIENTE:   " + this.GetCliente().GetNombre());
            datos += ("     HABITACION:   " + this.GetHabitacion().DarDatos());
            return datos;
        }
    }
}
