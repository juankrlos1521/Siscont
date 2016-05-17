using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SisCont.Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace SisCont.DataBase.Mapping
{
    class PersonaConfig:EntityTypeConfiguration<Persona>
    {
        public PersonaConfig()
        {
            ToTable("Cliente", "dbo");
            HasKey(o => o.Id);
        }
    }
}
