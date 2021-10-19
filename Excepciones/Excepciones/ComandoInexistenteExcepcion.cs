using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class ComandoInexistenteExcepcion : Exception
    {
        public ComandoInexistenteExcepcion(): base()
        {
        }

        public ComandoInexistenteExcepcion(string? message) : base(message)
        {
        }

        public ComandoInexistenteExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
