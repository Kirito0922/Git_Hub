using System;

namespace PracticaCSharp2
{
    class Programa
    {
        public static void Principal(string[] args)
        {
            long habitantes = 10;
            int habitantesCampo;
            habitantesCampo = (int) habitantes;
            Console.WriteLine("La cantidad de habitantes en zona de campo es de " + (habitantesCampo) + " habitantes");
        }
    }
}