using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class CuentasExcepcion : Exception
    {
        public CuentasExcepcion(): base()
        {
        }

        public CuentasExcepcion(string? message) : base(message)
        {
        }

        public CuentasExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
