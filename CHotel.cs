using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelería
{
    class CHotel
    {
        private string nombreHotel;
        private List<CHabitacion> listadoHabitaciones;
        
        public CHotel(string nom)
        {
            this.nombreHotel = nom;
            this.listadoHabitaciones = new List<CHabitacion>();

        }
        public string GetNombre() { return this.nombreHotel; }
        public void SetNombre(string nom) { this.nombreHotel = nom; }
        public void AgregarHabitacion(CHabitacion hab) { this.listadoHabitaciones.Add(hab); }
        public void ImprimirTotalHabitaciones()
        {
            Console.WriteLine( "NOMBRE HOTEL:   "+this.GetNombre() );
            foreach(CHabitacion hab in this.listadoHabitaciones)
            {
                Console.WriteLine(hab.DarDatos());
            }
        }
        public void ImprimirHabitacionesLibres()
        {
            byte i = 0;
            Console.WriteLine("NOMBRE HOTEL:   " + this.GetNombre());
            foreach (CHabitacion hab in this.listadoHabitaciones)
            {
                if (hab.GetDispo())
                {
                    Console.WriteLine(hab.DarDatos());
                    i++;
                }
            }
            if (i==0) Console.WriteLine("SIN VACANTES");
        }

    }
}
