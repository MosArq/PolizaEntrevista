﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Infraestructura.MDbModel
{
    public class BarSettings : IBarSettings
    {
        public string Server { get; set; }

        public string Database { get; set; }

        public string Collection { get; set; }

    }
}
