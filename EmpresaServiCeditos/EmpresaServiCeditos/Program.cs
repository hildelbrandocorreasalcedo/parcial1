using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using BLL;

namespace EmpresaServiCeditos
{
    public class Program
    {
        public static CreditoService creditoService = new CreditoService();
        static string mensaje;

        static void Main(string[] args)
        {
            DesplegarMenuPrincipal();

        }

        public static void DesplegarMenuPrincipal()
        {
            int opcion = 5;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("*************servicreditos***************");
                Console.WriteLine();
                Console.WriteLine("MENU DE LA servicreditos: ");
                Console.WriteLine();
                Console.WriteLine("1. Registrar credito");
                Console.WriteLine("2. Eliminar credito");
                Console.WriteLine("3. Ver si la credito Exite");
                Console.WriteLine("4. Modificar valor de credito");
                Console.WriteLine("5. Salir de la aplicacion\n");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Digite su opcion: ");
                Console.WriteLine();
                opcion = ValidarLimitesNumericos("!!Error!!, debe digitar del 1 al 5 ", 0, 5);
                EjecutarOpcion(opcion);
            } while (opcion != 5);
        }
        public static void EjecutarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    RegistrarCredito();
                    break;
                case 2:
                    EliminarCredito();
                    break;
                case 3:
                    BuscarCredito();
                    break;
                case 4:
                    ModificarCredito();
                    break;
                case 5:
                    break;
            }
        }
        public static void RegistrarCredito()
        {
            string respuesta;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Creditos creditos = PedirDatos();
                creditos.CalcularCapitalFinal();
                
                mensaje = CreditoService.Guardar(creditos);
                Console.WriteLine($"{mensaje}");
                Console.WriteLine();
                Console.WriteLine("El valor de la Credito es: {0}", creditos.Creditos);
                Console.WriteLine("¿Desea registrar otro Credito? S/N");
                respuesta = ValidarLimitesAlfabeticos("!!Error!!, debe ingresar S o N", "S", "N");
                Console.WriteLine();
            } while (respuesta == "S");
        }
        public static Creditos PedirDatos()
        {
            

            Creditos credito;
            Console.WriteLine("*************servicreditos***************");
            Console.WriteLine();
            Console.WriteLine("Escoja la Credito  ");
            Console.WriteLine("TASA DE INTERES COMPUESTO (C) o TASA DE INTERES SIMPLE(S): ");
            string TipodeTasa = ValidarLimitesAlfabeticos("!!Error!!,Debe digitar C o S", "C", "S");
            Console.WriteLine();
            Console.WriteLine("Digite el valor de requerido de credito:");
            int Identificacion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite SU IDENTIFICACION:");
            decimal ValorCapital = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite el valor de la Tasa De Interes:");
            decimal TasaDeInteres = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite el Periodo Tiempo de cuantos años:");
            decimal PeriodoTiempo = int.Parse(Console.ReadLine());
            Console.WriteLine();

           
            Console.WriteLine();
            Console.WriteLine("el resultado valor a pagar :");
            decimal ValordeServicio = decimal.Parse(Console.ReadLine());

            if (TipodeTasa == "C")
            {
                Console.WriteLine();
                Console.WriteLine("su resultado es:");

                ValorPagar = new CreditoTasaCompuesta (Identificacion, ValorCapital, TasaDeInteres, PeriodoTiempo);
            }
            else
            {
               
                ValorPagar = new CreditoTasaSimple(Identificacion, ValorCapital, TasaDeInteres, PeriodoTiempo);
            }
            return ValorPagar;
        }
        

        public static void EliminarCredito()
        {

        }
        public static void BuscarCredito()
        {

        }
        public static void  ModificarCredito()
        {

        }
        public static int ValidarLimitesNumericos(string mensaje, int limiteInferior, int limiteSuperior)
        {
            int opcion;
            do
            {
                opcion = int.Parse(Console.ReadLine());
                if (opcion < limiteInferior || opcion > limiteSuperior)
                {
                    Console.WriteLine(mensaje);
                    Console.ReadKey();
                }
            } while (opcion < limiteInferior && opcion > limiteSuperior);
            return opcion;
        }
        public static string ValidarLimitesAlfabeticos(string mensaje, string Letra1, string Letra2)
        {
            string opcion;
            do
            {
                opcion = Console.ReadLine().ToUpper();
                if (opcion != Letra1 && opcion != Letra2)
                {
                    Console.WriteLine(mensaje + "\n");
                    Console.ReadKey();
                }
            } while (opcion == Letra1 && opcion == Letra2);
            return opcion;
        }
    }
}
