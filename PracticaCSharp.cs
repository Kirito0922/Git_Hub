using System.Globalization;
using System.Dynamic;
using System;

namespace PracticaCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {  
            //Cálculo del área de una circunferencia
            Console.WriteLine("Introduzca el radio del círculo");
            double radio = double.Parse(Console.ReadLine());
            const double PI = Math.PI;
            double areaCirculo = Math.Round(Math.Pow(radio, 2)*PI, 2);
            Console.WriteLine("El área del círculo es igual a: " + (areaCirculo) + " centímetros cuadrados.");
            
            //!Imprimir en consola todos los elementos de un array de 2 dimensiones mediante el uso de un bucle "for"
            int [,] multi_Dimensional_Array = new int [4,2];
            multi_Dimensional_Array [0,0] = 12;
            multi_Dimensional_Array [0,1] = 35;
            multi_Dimensional_Array [1,0] =  4;
            multi_Dimensional_Array [1,1] =  3;
            multi_Dimensional_Array [2,0] = 56;
            multi_Dimensional_Array [2,1] = 28;
            multi_Dimensional_Array [3,0] = 20;
            multi_Dimensional_Array [3,1] = 64;
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<2; j++)
                    Console.WriteLine(multi_Dimensional_Array[i,j]);
            }

            //El uso del condicional "if"
            if(3>2)
                Console.WriteLine("Esto es la pura verdad");
            else
                Console.WriteLine("Esto es tremenda mentira");

            //Uso simple de un bucle "for" para imprimir un mismo mensaje varias veces
            for(int k=0; k<=4; k++)
                Console.WriteLine("Hola chavales");

            //Uso simple de un bucle "while" para imprimir el mismo mensaje varias veces
            int contador = 0;
            while(contador<5)
            {
                Console.WriteLine("Hola mundo");
                contador++;
            }

            //Uso simple del método "length" 
            int [] lista = {1,2,3,4,5,6,7,8,9};
            for(int m=0; m<lista.Length; m++)
                Console.WriteLine(lista[m]+=5);
            
            //Uso simple del bucle "while" para imprimir los elementos de un arreglo
            int z = 0;
            while(z<lista.Length) 
            {
                Console.WriteLine(lista[z]-=5);
                z++;
            }

            //Conversión de un "string" a un "arreglo de string" para luego imprimir cada uno de sus elementos en consola mediante un bucle "for" utilizando el método "length"
            string mi_Lista = "Esta es mi lista de cosas para hacer hoy";
            string [] arreglo = mi_Lista.Split();
            for(int k=0; k<arreglo.Length; k++)
                Console.WriteLine(arreglo[k]);

            Boolean enigma = true;
            enigma = Boolean.Parse(Console.ReadLine());
            if(enigma)
            Console.WriteLine("La respuesta es correcta");
            else
            Console.WriteLine("Lo siento, estás equivocado"); 
        }
    }
}