using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Infraestructura.MDbModel
{
    public interface IBarSettings
    {
        string Server { get; set; }

        string Database { get; set; }

        string Collection { get; set; }
    }
}
