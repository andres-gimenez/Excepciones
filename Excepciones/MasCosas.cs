using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class MasCosas
    {
        public decimal Suma(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Divide (decimal a, decimal b)
        {
            return a / b;
        }

        public decimal HazCuentas()
        {
            return Divide(2, 3);
        }

        public decimal HazCuentasRaras()
        {
            return Divide(2, 0);
        }

        public decimal VariasCuentas1()
        {
            try
            {
                return HazCuentasRaras();
            }
            catch(DivideByZeroException ex)
            {
                throw new CuentasExcepcion("No se pudieron hacer varias cuentas", ex);
            }
        }

        public decimal VariasCuentas2()
        {
            try
            {
                return HazCuentasRaras();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("No se puede dividir entre cero.");
                Console.WriteLine("------------------");

                throw; 
            }
        }

        public decimal VariasCuentas3()
        {
            try
            {
                return HazCuentasRaras();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("No se puede dividir entre cero.");
                Console.WriteLine("------------------");

                throw ex;
            }
        }
    }
}
