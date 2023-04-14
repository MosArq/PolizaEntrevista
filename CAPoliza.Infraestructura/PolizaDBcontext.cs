using CAPoliza.Dominios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Infraestructura
{
    public class PolizaDBcontext : DbContext
    {
        public PolizaDBcontext(DbContextOptions<PolizaDBcontext> options) : base(options) 
        {


        }

        public DbSet<Poliza> Polizas { get; set; }

    }
}
