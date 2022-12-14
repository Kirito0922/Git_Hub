using System;

namespace PracticaCSharp2
{
    class Program2
    {
        public static void Main1(string[] args)
        {
        //! La extraña funcionalidad del operador incremento
            int num = 0;
            int num1 = num++;
            int num2 = num++ + num1++;
            Console.WriteLine(num1);
            Console.WriteLine(num);
            Console.WriteLine(num2);
        //! Lo anterior no es igual a lo siguiente
            int numero = 0;
            int numero1 = ++numero;
            int numero2 = ++numero + ++numero1;
            Console.WriteLine(numero1);
            Console.WriteLine(numero);
            Console.WriteLine(numero2);

        // Cálculo del área de una circunferencia
            Console.WriteLine("Introduzca el radio del círculo");
            double radio = double.Parse(Console.ReadLine());
            const double PI = Math.PI;
            double areaCirculo = Math.Round(Math.Pow(radio, 2)*PI, 2);
            Console.WriteLine("El área del círculo es igual a: " + (areaCirculo) + " centímetros cuadrados.");

        //* Imprimir en consola todos los elementos de un array de 2 dimensiones mediante el uso de un bucles "for" anidados
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

        //* Otro método para imprimir los elementos de un array multidimensional utilizando el método "GetLength"
            int [,] multi_Dimensional_Array2 = new int [2, 4];
            multi_Dimensional_Array2 [0,0] =  36;
            multi_Dimensional_Array2 [0,1] = 124;  
            multi_Dimensional_Array2 [0,2] =  58; 
            multi_Dimensional_Array2 [0,3] =   9;  
            multi_Dimensional_Array2 [1,0] =  13;  
            multi_Dimensional_Array2 [1,1] =  65; 
            multi_Dimensional_Array2 [1,2] =  21; 
            multi_Dimensional_Array2 [1,3] =  98; 

            for(int i=0; i<multi_Dimensional_Array2.GetLength(0); i++)
            {
                for(int j=0; j<multi_Dimensional_Array2.GetLength(1); j++)
                    Console.WriteLine(multi_Dimensional_Array2[i,j]);
            }

        //* Imprimir la suma de los elementos de varios arrays mediante bucles "for" anidados
            int [,] matriz = new int [2,1];
            int [,] matriz1 = new int [2,1];
            int [,] matriz2 = new int [2,1];

            matriz  [0,0] =  2;
            matriz  [1,0] = 32;
            matriz1 [0,0] =  4;
            matriz1 [1,0] = 54;
            matriz2 [0,0] =  3;
            matriz2 [1,0] = 25;

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<1; j++)
                {
                    Console.WriteLine(matriz[i,j] + matriz1[i,j] + matriz2[i,j]);
                }
            }

        // El uso del condicional "if"
            if(3>2)
                Console.WriteLine("Esto es la pura verdad");
            else
                Console.WriteLine("Esto es tremenda mentira");

        // Sencillo uso de la estructura "else if". En este caso, si en lugar de "else if" usáramos varios "if", el programa no cumpliría su cometido e imprimiría varios mensajes a la misma vez. Aún así si los operadores lógicos y de comparación estuvieran colocados correctamente, no sería obligatorio el uso del "else if", pero al usar "if" el programa tendría que evaluar todas las condiciones; con el uso de "else if" el programa se ahorraría tiempo y recursos.
            Console.WriteLine("Introduzca su edad");
            int edad = int.Parse(Console.ReadLine());
            
            if(edad<18) Console.WriteLine("Aún eres un niño");
            else if(edad<30) Console.WriteLine("Eres joven");
            else if(edad<60) Console.WriteLine("Eres un adulto");
            else if(edad>60) Console.WriteLine("Debes cuidarte");

        // Uso simple de un bucle "for" para imprimir un mismo mensaje varias veces
            for(int k=0; k<=4; k++)
                Console.WriteLine("Hola chavales");

        // Uso simple de un bucle "while" para imprimir el mismo mensaje varias veces
            int contador = 0;
            while(contador<5)
            {
                Console.WriteLine("Hola mundo");
                contador++;
            }

        // Uso simple del método "length" 
            int [] lista = {1,2,3,4,5,6,7,8,9};
            for(int m=0; m<lista.Length; m++)
                Console.WriteLine(lista[m]+=5);
            
        // Uso simple del bucle "while" para imprimir los elementos de un arreglo
            int z = 0;
            while(z<lista.Length) 
            {
                Console.WriteLine(lista[z]-=5);
                z++;
            }
            
        // Uso del bucle "do while". Genera un número aleatorio y que el usuario adivine cuál es
        // Manejo de excepciones o errores de una forma poco elegante, hasta entrar en POO
            Console.WriteLine("Se generará un número aleatorio entre 0 y 100. Usted debe adivinar de cuál se trata");
            Random numero3 = new Random();
            int numero_Aleatorio = numero3.Next(0, 100);
            Console.WriteLine("Introduce el número");
            int numero_Usuario;
            int intentos = 0;

            do{
                intentos++;
                try
                {
                    numero_Usuario = int.Parse(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    numero_Usuario = 0;
                    Console.WriteLine("Usted debe introducir un valor numérico. Se tomará el número 0 como valor por defecto");
                    Console.WriteLine(numero_Usuario);
                }
                catch(OverflowException ex)
                {
                    numero_Usuario = 100;
                    Console.WriteLine("El número que usted ha introducido es mucho mayor que 100. Debe introducir un número que se encuentre entre 0 y 100. Se tomará el número 100 como valor por defecto");
                    Console.WriteLine(numero_Usuario);
                }

                if(numero_Usuario>100)
                {
                    numero_Usuario = 100;
                    Console.WriteLine("El número que usted ha introducido es mayor que 100. Debe introducir un número que se encuentre entre 0 y 100. Se tomará el número 100 como valor por defecto");
                    Console.WriteLine(numero_Usuario);
                }
                
                if(numero_Usuario<numero_Aleatorio) Console.WriteLine("El número generado es mayor");
                else if(numero_Usuario>numero_Aleatorio) Console.WriteLine("El número generado es menor"); 
            } while(numero_Usuario!=numero_Aleatorio);
            
            Console.WriteLine("Felicidades! El número era " + (numero_Aleatorio) + ". Te ha tomado " + (intentos) + " intentos");

        // Conversión de un "string" a un "arreglo de string" para luego imprimir cada uno de sus elementos en consola mediante un bucle "for" utilizando el método "length"
            string mi_Lista = "Esta es mi lista de cosas para hacer hoy";
            string [] arreglo = mi_Lista.Split();
            for(int k=0; k<arreglo.Length; k++)
                Console.WriteLine(arreglo[k]);

        // Conversión de un string en una variable tipo "boolean"
            Boolean enigma = Boolean.Parse(Console.ReadLine());
            if(enigma)
            Console.WriteLine("La respuesta es correcta");
            else
            Console.WriteLine("Lo siento, estás equivocado"); 

        // Conversión explícita de variables (se hace entre tipos de datos no compatibles, o entre datos compatibles, de mayor alcance a menor alcance)
            long habitantes = 1234567890123456789;
            int habitantesCiudad = (int) habitantes;
            Console.WriteLine("La cantidad promedio de habitantes por ciudad en Colombia es de " + (habitantesCiudad));

        //? En este caso hay una pérdida de información o de precisión
            double distanciaMedia = 2813.46565213;
            int distancia = (int) distanciaMedia;
            Console.WriteLine("La distancia entre Cuba y España es de  " + (distancia) + " kilómetros");

        // Conversión implícita de variables (sucede entre tipos de datos compatibles de distinto alcance, de menor alcance a mayor alcance)
            int ciudadanosAustralia = 5164282;
            long ciudadanosContinente = ciudadanosAustralia;
            Console.WriteLine("El continente australiano tiene un total de " + (ciudadanosContinente) + " habitantes");

        // Necesitamos un programa que evalúe la edad de una persona y, de ser mayor de edad, saber si puede conducir vehículos preguntándole si tiene, o no, carnet de conducción. De no ser mayor de edad, directamente no puede conducir vehículos.
            Console.WriteLine("Escriba su edad a continuación, por favor");
            byte edad1 = byte.Parse(Console.ReadLine());

            if(edad1>=18)
            {
                Console.WriteLine("Qué bueno! ¿Tiene carnet de conducción?");
                string carnet = Console.ReadLine();   
            
                if(carnet.Contains("si"))
                    Console.WriteLine("Estupendo, usted ya puede conducir vehículos");
                else if(carnet.Contains("no"))
                    Console.WriteLine("Lo sentimos mucho, pero primero debe sacar su licencia de conducción. Acuda a nuestras oficinas por favor!");
            }
                else
                    Console.WriteLine("Usted no es mayor de edad, por lo tanto no puede conducir vehículos");

        // Necesitamos un programa que evalúe si los 3 parciales de una asignatura están aprobados. De ser así, hallar el promedio de las notas para conocer la evaluación final de la asignatura. Si uno de los 3 parciales está suspenso, la asignatura estará suspensa.
            Console.WriteLine("Introduce la nota del primer parcial");
            int parcial1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota del segundo parcial");
            int parcial2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota del tercero parcial");
            int parcial3 = int.Parse(Console.ReadLine());

            if(parcial1>2 && parcial2>2 && parcial3>2)
                Console.WriteLine("El promedio de los 3 parciales es igual a: " + (parcial1+parcial2+parcial3)/3 + ". Esta es la nota final de la asignatura. Felices vacaciones!!!");
            else
                Console.WriteLine("Has suspendido uno de los 3 parciales, no tienes derecho a que se te realice el promedio de las notas; por lo tanto quedas suspenso en la asignatura. Nos vemos en Septiembre! Que disfrutes de tus vacaciones!");

        // Uso de la estructura condicional "switch"
            Console.WriteLine("Elige el juego que más te gusta:");
            Console.WriteLine("1- Brawl Stars");
            Console.WriteLine("2- Defense of the Ancient");
            Console.WriteLine("3- Super Smash Bros.");
            Console.WriteLine("4- Super Mario Bros.");
            Console.WriteLine("5- Kirby");

            string game = Console.ReadLine();

            switch(game)
            {
                case "Brawl Stars":
                    Console.WriteLine("El mejor juego para móviles");
                    break;
                case "Defense of the Ancient":
                    Console.WriteLine("El mejor MOBA del mercado");
                    break;
                case "Super Smash Bros.":
                    Console.WriteLine("El mejor juego de peleas");
                    break;
                case "Super Mario Bros.":
                    Console.WriteLine("El juego más famoso de la historia de los videojuegos");
                    break;
                case "Kirby":
                    Console.WriteLine("La bolita rosada preferida de todos");
                    break;
                default:
                    Console.WriteLine("Vaya puta mierda de juego, macho!");
                    break;
            }

        // Dados ciertos ruidos de animales, crea un programa que diga a quien pertenece cada sonido
            Console.WriteLine("¿Qué ruidos escuchas en la oscuridad");
            string noises = Console.ReadLine();
            string [] noises_Array = noises.Split (' ');

            for(int i=0; i<noises_Array.Length; i++)
            {
                if(noises_Array[i]=="Grr")
                    Console.Write("Lion ");   
                else if(noises_Array[i]=="Rawr")
                    Console.Write("Tiger ");
                else if(noises_Array[i]=="Ssss")
                    Console.Write("Snake ");
                else if(noises_Array[i]=="Chirp")
                    Console.Write("Bird ");
            }
        }
    }
}