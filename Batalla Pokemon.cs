using System

namespace Batalla_Pokemon
{
    class Batalla
    {
    //TODO: Añadir los colores a los tipos de ataques en consola
    //TODO: Hacer los pokemones como objetos que pertenezcan a una clase
    //TODO: Poner 4 ataques a cada pokemon
    //TODO: Añadir los estados alterados que sean random
    //TODO: Añadir mas pokemones usando in and out y el foreach
    //TODO: Hacer el juego lo mas parecido al original poniendo tipos, debilidades, etc
    //TODO: Tratar de poner sprites cuando sepamos
        public static void Main4(string[]args)
        {
            string pokemon_1 = "Pikachu";
            string pokemon_2 = "Squirtle";
            int vida_Pikachu = 100;
            int impactrueno = 40;
            int vida_Squirtle = 100;
            int chorro_agua = 25;
            int turno = 0;

        //? Para hacerlo con el bucle "for" es simplemente así: for(vida=100; vida>0; vida+= o vida-=0), aunque no queda muy elegante que digamos
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
                }    Console.WriteLine((pokemon_2) + " ha sido derrotado. " + (pokemon_1) + " gana.");
            }
        }
    }
}