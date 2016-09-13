using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoteInterfaceForContract
{
    [Serializable]
    public class Route
    {
        public string Destination { get; set; }
        public TimeSpan TravelTime { get; set; }

        public Route(string destination, TimeSpan travelTime)
        {
            Destination = destination;
            TravelTime = travelTime;
        }
    }
}