using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoteInterfaceForContract
{
    [Serializable]
    public class Reservation
    {
        public Route ReservedRoute { get; set; }
        public int Customer { get; set; }
        public Reservation(Route reservedRoute, int customer)
        {
            ReservedRoute = reservedRoute;
            Customer = customer;
        }
    }
}