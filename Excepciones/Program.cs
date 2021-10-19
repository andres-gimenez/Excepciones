using System;

namespace Excepciones
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Informacion();

            var comando = Console.ReadLine();

            switch(comando)
            {
                case "Uno":
                    Console.WriteLine("1");
                    break;
                case "Dos":
                    Console.WriteLine("2");
                    break;
                case "Tres":
                    throw new NotImplementedException("El comando 3 no esta implementado.");
                case "Cuatro":
                    throw new NotSupportedException("El comando 4 no esta soportado.");
                case "Suma":
                    var masCosasSuma = new MasCosas();
                    Console.WriteLine(masCosasSuma.Suma(2, 3));
                    break;
                case "Divide":
                    var masCosasDivide = new MasCosas();
                    Console.WriteLine(masCosasDivide.Divide(2, 0));
                    break;
                case "CuentasBien":
                    var cuentasBien = new MasCosas();
                    Console.WriteLine(cuentasBien.HazCuentas());
                    break;
                case "CuentasMal":
                    var cuentasMal = new MasCosas();
                    Console.WriteLine(cuentasMal.HazCuentasRaras());
                    break;
                case "VariasCuentas1":
                    var variasCuentas1 = new MasCosas();
                    Console.WriteLine(variasCuentas1.VariasCuentas1());
                    break;
                case "VariasCuentas2":
                    var variasCuentas2 = new MasCosas();
                    Console.WriteLine(variasCuentas2.VariasCuentas2());
                    break;
                case "VariasCuentas3":
                    var variasCuentas3 = new MasCosas();
                    Console.WriteLine(variasCuentas3.VariasCuentas3());
                    break;
                case "VariasCuentas4":
                    var variasCuentas4 = new MasCosas();
                    Console.WriteLine(variasCuentas4.VariasCuentas4());
                    break;
                default:
                    throw new ComandoInexistenteExcepcion($"El comando {comando} no existe");
            }

            Console.WriteLine("Hello World!");

            return 0;
        }

        private static void Informacion()
        {
            Console.WriteLine("Opciones:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Uno: Imprime un uno.");
            Console.WriteLine("Dos: Imprime un dos.");

            Console.WriteLine("Tres: No implementado.");
            Console.WriteLine("Divide: No soportado.");

            Console.WriteLine("Suma: Hace una suma.");
            Console.WriteLine("Divide: Hace un division.");

            Console.WriteLine("CuentasBien: Cuenta bien.");
            Console.WriteLine("CuentasMal: Cuenta mal.");

            Console.WriteLine("VariasCuentas: Varias cuentas.");
        }
    }
}
