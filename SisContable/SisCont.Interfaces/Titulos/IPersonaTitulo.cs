using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SisCont.Models.Models;

namespace SisCont.Interfaces.Titulos
{
    public interface IPersonaTitulo
    {
        IList<Persona> ListameTodo(DateTime fecha);
        Persona TraerPersonaPorId(int? id);
        void Insertar(Persona persona);
        void Modificar(Persona persona);
        void Eliminar(int id);
    }
}
