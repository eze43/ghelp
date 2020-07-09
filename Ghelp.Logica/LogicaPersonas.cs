using Ghelp.Datos;
using Ghelp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghelp.Logica
{
    public class LogicaPersonas
    {
        private RepositorioPersona _repositorioPersonas;

        public LogicaPersonas()
        {
            _repositorioPersonas = new RepositorioPersona();

        }


        public Persona ObtienePersona(int id)
        {
            return _repositorioPersonas.ObtienePersona(id);
        }
    }
}
