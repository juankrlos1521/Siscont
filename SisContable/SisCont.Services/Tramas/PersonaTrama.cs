using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SisCont.DataBase.ActaModels;
using SisCont.Models.Models;
using SisCont.Interfaces.Titulos;
using System.Data.Entity;

namespace SisCont.Services.Tramas
{
    public class PersonaTrama:IPersonaTitulo
    {
        private readonly SisContContext entidadPersona;

        public PersonaTrama(SisContContext PersonaEntidadIngresa)
        {
            this.entidadPersona = PersonaEntidadIngresa;
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Persona persona)
        {
            throw new NotImplementedException();
        }

        public IList<Persona> ListameTodo(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Persona TraerPersonaPorId(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
