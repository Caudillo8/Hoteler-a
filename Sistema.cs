using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelería
{
    class Sistema
    {
        private CCliente cliente;
        private CHotel hotel;
        private CReserva rsv;

        public Sistema(CReserva rsv)
        {
            this.rsv = new CReserva();
        }

    }
}
