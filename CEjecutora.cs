using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelería
{
    class CEjecutora
    {
        static void Main()
        {
            CHotel sanber = new CHotel("HOTEL SAN BERNARDO");
            CHotel pina = new CHotel("HOTEL PINAMAR");
            CHabitacion habi_1 = new CHabitacion(1,4,true,true);
            CHabitacion habi_2 = new CHabitacion(2, 3, true, true);
            sanber.AgregarHabitacion(habi_1);
            pina.AgregarHabitacion(habi_2);
            CCliente juancito = new CCliente("JUANCITO");
            CReserva rsv1 = new CReserva(001, juancito, habi_1);
            Console.WriteLine(rsv1.DarDatos());
            sanber.ImprimirTotalHabitaciones();
            rsv1.DarDatos();
            sanber.ImprimirHabitacionesLibres();
            Console.WriteLine( rsv1.DarDatos() ) ;








            Console.WriteLine("\n\n\t\t<enter>");
            Console.ReadKey();
        }
    }
}
