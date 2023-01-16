using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsClinica.Data
{
    internal class DBClinicaEFContext : DbContext
    {
        public DBClinicaEFContext() : base("KeyDB") { }


        //Propiedades DBSET
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
