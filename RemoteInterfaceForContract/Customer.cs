using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoteInterfaceForContract
{
    [Serializable]
    public class Customer
    {
        public string Transportation { get; set; }
        public List<Reservation> Reservations { get; set; }

        // Name, Email, Phone number etc. would be attributes here. 
        // But not relevant for our current use case.

        public Customer(string transportation, List<Reservation> reservations)
        {
            Transportation = transportation;
            Reservations = reservations;
        }
    }
}