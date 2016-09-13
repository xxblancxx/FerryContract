using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoteInterfaceForContract
{
    [Serializable]
    public class Ferry
    {
        public int Size { get; set; } // 1, 2 or 3 .. 
        public bool ContainsHeavyMachinery { get; set; }
        public bool IsBackup { get; set; } // Whether its a substitution from neighbour municipality
        public List<Route> AssignedRoutes { get; set; }
        public Ferry(int size, bool containsHeavyMachinery, bool isBackup, List<Route> assignedRoutes)
        {
            Size = size;
            ContainsHeavyMachinery = containsHeavyMachinery;
            IsBackup = isBackup;
            AssignedRoutes = assignedRoutes;
        }

    }
}