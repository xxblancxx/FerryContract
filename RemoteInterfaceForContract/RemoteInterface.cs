using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteInterfaceForContract
{
    interface RemoteInterface
    {
        //List all Routes to choose from, when making a reservation
        // Make new Reservation based on chosen route, and transportation type.

        List<Route> ListAllRoutes();
        void MakeReservation();
    }
}
