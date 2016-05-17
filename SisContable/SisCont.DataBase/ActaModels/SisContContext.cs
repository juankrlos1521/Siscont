using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using SisCont.Models.Models;
using SisCont.DataBase.Mapping;

namespace SisCont.DataBase.ActaModels
{
    public class SisContContext: DbContext
    {
        public virtual IDbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add<Persona>(new PersonaConfig());

        }
    }
}
