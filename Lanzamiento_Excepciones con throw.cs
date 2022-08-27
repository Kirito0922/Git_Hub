using System.IO.Compression;
using System.Globalization;
using System.Dynamic;
using System;

namespace Lanzamiento_Excepciones
{
    class Lanzamiento 
    {
    //! Lanzamiento de Excepciones con throw. Mediante "throw" forzamos a que el programa lance una excepción para que, aquellos programadores que estén trabjando en nuestro proyecto y deseen utilizar nuestro método, se vean obligados a utilizar un bloque "try...catch()" para capturar las excepciones que lance nuestro método.
        public static void Main2(string[] args)
        {
            int numero_Mes = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(NombreDelMes(numero_Mes));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("El número de mes introducido es incorrecto. Por favor, introduzca un número válido.");
            }

            Console.WriteLine("Aquí continuaría la ejecución del programa");
        }
        public static string NombreDelMes(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}