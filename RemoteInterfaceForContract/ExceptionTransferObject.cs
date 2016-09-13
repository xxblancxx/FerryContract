using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoteInterfaceForContract
{
    [Serializable]
    public class ExceptionTransferObject : Exception
    {
        public ExceptionTransferObject(string message) : base(message)
        {
            // Can use all exception classes
        }
    }
}