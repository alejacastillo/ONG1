using ONG.BL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.BL
{
   public  class Contexto : DbContext 
    {
     
    public Contexto() : base(@"Data Source = (LocalDb)\MSSQLLocalDB;AttachDBFilename = " +
    Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ONGdb.mdf")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
        }
        public DbSet<Desaparecidos> Desaparecido { get; set; }
       
    }
    
}
