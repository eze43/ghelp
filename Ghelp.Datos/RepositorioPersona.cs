using Ghelp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghelp.Datos
{
    public class RepositorioPersona
    {
        public static List<Persona> Data = new List<Persona>
        {
            new Persona {Id=1, Nombre="prueba" }
        };
        public Persona ObtienePersona(int id)
        {
            return Data.FirstOrDefault(persona => persona.Id == id);
        }
    }
}
