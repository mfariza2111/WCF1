﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FirstWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FirstWCF.svc or FirstWCF.svc.cs at the Solution Explorer and start debugging.
    public class FirstWCF : IFirstWCF
    {
        public string Message()
        {
            return "Hellow World";
        }
    }
}
