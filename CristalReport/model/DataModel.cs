using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CristalReport.model
{
    class DataModel:DbContext
    {
        public DbSet<Productos> productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// CONSTRUCTOR DE LA CLASE Y SE LE INDICA EL NOMBRE DE LA CADENA DE 
        /// CONCECCION
        /// </summary>
        public DataModel() : base("DataModel") { }
    }
}
