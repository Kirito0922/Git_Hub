using System;

namespace Guia_Estudio
{
    class Guia
    {
        public static void Main3(string[]args)
        {
        //* Algoritmo que procese los salarios de los trabajadores de una empresa. Para ello será necesario introducir primero el número de trabajadores. Se deberá mostrar el salario más pequeño, el salario más alto y el salario promedio de la empresa.

            Console.WriteLine("Introduzca el número de trabajadores que tiene la empresa");
            int trabajadores = int.Parse(Console.ReadLine());
            double [] salarios_trabajadores = new double [trabajadores];
            double suma_salarios = 0;
            Console.WriteLine("Introduzca el salario de cada trabajador");

            for(int i=0; i<trabajadores; i++)
            {
                salarios_trabajadores[i] = double.Parse(Console.ReadLine());
                suma_salarios = suma_salarios + salarios_trabajadores[i];
            }

            double salario_promedio = suma_salarios/trabajadores;
            salario_promedio = Math.Round(salario_promedio, 2);
            Array.Sort(salarios_trabajadores);

            Console.WriteLine("El salario más pequeño de la empresa es de " + (salarios_trabajadores[0]) + " pesos.");
            Console.WriteLine("El salario más alto de la empresa es " + (salarios_trabajadores[trabajadores-1]) + " pesos.");            
            Console.WriteLine("El salario promedio de la empresa es de " + (salario_promedio) + " pesos.");

        //* Algoritmo que determine el ganador de unas elecciones, el total de votos y el por ciento que representan los votos del ganador y del perdedor del total de votos. El algoritmo se detendrá cuando lea una boleta vacía

            string candidato_1 = "Biden";
            string candidato_2 = "Trump";
            int Biden = 0;
            int Trump = 0;
            Console.WriteLine("Introduzca el número de candidato al que desea votar");
            Console.WriteLine("Candidato " + (candidato_1) + "      Candidato " + (candidato_2));
            string boleta;

            do
            {
                boleta = Console.ReadLine();
                if(boleta.Contains("1"))
                {
                    Console.WriteLine("      X");
                    Biden++;
                }
                else if(boleta.Contains("2"))
                {
                    Console.WriteLine("                            X");
                    Trump++;
                }

            }while(boleta!="");
            
            int total_votos = Biden + Trump;
            double porcentaje_Biden = Biden*100/total_votos;
            double porcentaje_Trump = Trump*100/total_votos;

            Console.WriteLine("Han finalizado las elecciones presidenciales de medio término. Se han cuantificado un total de " + (total_votos) + " voto(s)");


            if(Biden>Trump) Console.WriteLine("La victoria es para el candidato Biden, quien ha acumulado " + (Biden) + " voto(s), lo cual representa el " + (porcentaje_Biden) + "% del total de votos.");
            else if(Trump>Biden) Console.WriteLine("La victoria es para el candidato Trump, quien ha acumulado " + (Trump) + " voto(s), lo cual representa el " + (porcentaje_Trump) + "% del total de votos.");

            if(Biden<Trump) Console.WriteLine("El candidato " + (candidato_1) + " ha sido derrotado y ha acumulado " + (Biden) + " voto(s), lo cual representa el " + (porcentaje_Biden) + "% del total de votos.");
            else if(Trump<Biden) Console.WriteLine("El candidato " + (candidato_2) + " ha sido derrotado y ha acumulado " + (Trump) + " voto(s), lo cual representa el " + (porcentaje_Trump) + "% del total de votos.");

            if(Biden==Trump) Console.WriteLine("Se ha producido un empate. Ambos candidatos han acumulado el 50% de los votos, siendo esto un total de " + (total_votos/2) + " votos para cada candidato. Se deberá producir un desempate mediante otra votación. Los esperamos una vez más en las mesas electorales la semana próxima. Más detalles en el sitio web de la Casa Blanca");

            Console.WriteLine("Esperamos su discurso, Presidente!");
        }
    }
}