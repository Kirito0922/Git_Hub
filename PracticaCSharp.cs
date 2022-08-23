using System.IO.Compression;
using System.Globalization;
using System.Dynamic;
using System;

namespace PracticaCSharp
{
    //TODO: añadir los colores a los tipos de ataques en consola
    //TODO: hacer los pokemones como objetos que pertenezcan a una clase
    //TODO: poner 4 ataques a cada pokemon
    //TODO: añadir los estados alterados que sean random
    //TODO: añadir mas pokemones usando in and out y el foreach
    //TODO: hacer el juego lo mas parecido al original poniendo tipos, debilidades, etc
    //TODO: tratar de poner sprites cuando sepamos

    class Program
    {
        public static void Main(string[] args)
        {  
            //! Batalla Pokemon
            string pokemon_1 = "Pikachu";
            string pokemon_2 = "Squirtle";
            int vida_Pikachu = 100;
            int impactrueno = 40;
            int vida_Squirtle = 100;
            int chorro_agua = 25;
            int turno = 0;

            while(vida_Pikachu>0 && vida_Squirtle>0)
            { 
                if(turno%2==0)
                {
                    Console.WriteLine("Es el turno " + (turno) + ". Le toca jugar a " + (pokemon_1) + ".");
                    vida_Squirtle = vida_Squirtle - impactrueno;
                    if(vida_Squirtle<0) vida_Squirtle = 0;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Pikachu ha usado impactrueno. " + (pokemon_2) + " tiene " + (vida_Squirtle) + " puntos de vida.");
                }
                else if(turno%2==1)
                {
                    Console.WriteLine("Es el turno " + (turno) + ". Le toca jugar a " + (pokemon_2) + ".");
                    vida_Pikachu = vida_Pikachu - chorro_agua;
                    if(vida_Pikachu<0) vida_Pikachu = 0;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Squirtle ha usado chorro agua. " + (pokemon_1) + " tiene " + (vida_Pikachu) + " puntos de vida.");
                }
                turno++;
            }

            if(vida_Pikachu==0 || vida_Squirtle==0)
            {
                if(vida_Pikachu==0)
                {
                    vida_Pikachu = vida_Pikachu - vida_Pikachu;
                    Console.WriteLine((pokemon_1) + " ha sido derrotado. " + (pokemon_2) + " gana.");
                }
                else if(vida_Squirtle==0)
                {
                    vida_Squirtle = vida_Squirtle - vida_Squirtle;
                    Console.WriteLine((pokemon_2) + " ha sido derrotado. " + (pokemon_1) + " gana.");
                }    
            }            
        }
    
    }
}