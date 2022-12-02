using System;

namespace Main
{
    public class intento_de_los_7_arrays
    {
        static void Main(string[] args)
        {

            int opcion, X = 0, aux = 0;
            float prom, Z;
            int[] numeros = new int[10];
            int[] arrayAux = new int[10];



            //llena el arreglo se numeros
            numeros = llenarNumeros();

            //limpia la terminal
            Console.Clear();

            //inicia el bucle para repetir xd
            do
            {



                //muestras las opciones que se pueden realizar
                opciones();
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();




                //empieza a ejecutar el codigo del las opciones
                switch (opcion)
                {






                    //cambia de orden el arreglo de numeros
                    case 1:

                        numeros = regresarInv(numeros);

                        mostrarArray(numeros);

                        segir();
                        break;





                    //verifica que su orden sea dd menor a mayor
                    case 2:
                        X = 0;
                        for (int i = 1; i < 10; i++)
                        {
                            aux = numeros[i - 1];

                            if (aux > numeros[i])
                            {
                                X++;
                            }

                        }

                        if (X > 0)
                        {
                            Console.WriteLine("\nla lista de numeros no esta ordenado de menor a mayor");
                        }
                        else
                        {
                            Console.WriteLine("\nla lista de numeros si esta ordenada de menor a mayor");
                        }
                        //	mostrarArray(numeros);
                        segir();
                        break;




                    //verifica que su orden suea exactamente de orden creciente
                    case 3:
                        X = 0;
                        for (int i = 1; i < 10; i++)
                        {
                            aux = numeros[i - 1];

                            if (aux > numeros[i])
                            {
                                X++;
                            }

                        }

                        if (X > 0)
                        {
                            Console.WriteLine("\nla lista de numeros no esta extrictamente ordenado de forma creciente");
                        }
                        else
                        {
                            Console.WriteLine("\nla lista de numeros si esta extrictamente ordenada de forma creciente");
                        }
                        //mostrarArray(numeros);
                        segir();
                        break;




                    //verificar si hay numeris repetidos en el array numeros
                    case 4:
                        X = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            aux = numeros[i];
                            for (int j = 0; j < 10; j++)
                            {

                                if (aux == numeros[j] && j != i)
                                {
                                    X++;
                                }
                            }
                        }

                        if (X != 0)
                        {
                            Console.WriteLine("\nexisten numeros repetidos en la lista de numeros");
                        }
                        else
                        {
                            Console.WriteLine("\nno existen numeros repetidos en la lista de numeros");
                        }

                        //	mostrarArray(numeros);
                        segir();
                        break;




                    //ordenar se forma asendente el array numeros
                    case 5:

                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 1; j < 10; j++)
                            {
                                aux = numeros[j - 1];
                                if (aux > numeros[j])
                                {
                                    aux = numeros[j];
                                    numeros[j] = numeros[j - 1];
                                    numeros[j - 1] = aux;
                                }
                            }
                        }


                        mostrarArray(numeros);
                        segir();
                        break;




                    //solisitar un numero para verificar si esta en el array numeros
                    case 6:
                        Console.Write("ingrese el numero a comparar: \n- > ");
                        aux = int.Parse(Console.ReadLine());
                        X = 0;
                        for (int i = 0; i < 10; i++)
                        {

                            if (aux == numeros[i])
                            {
                                X++;
                            }
                        }

                        if (X > 0)
                        {
                            Console.WriteLine("\nel numero ingresado si se encuantra en la lista de numeros");
                        }
                        else
                        {
                            Console.WriteLine("\nel numero ingresado no se encuantra en la lista de numeros");
                        }

                        //mostrarArray(numeros);
                        segir();
                        break;




                    //sacar el promedio de el array numeros
                    case 7:
                        Z = 0;
                        for (int i = 0; i < 10; i++)
                        {

                            Z = Z + numeros[i];

                        }
                        prom = Z / 10;

                        Console.WriteLine("\nEl promedio de la lista de numeros es: " + prom);

                        //mostrarArray(numeros);
                        segir();
                        break;




                    //volver a rellenar el array numeros
                    case 8:

                        numeros = llenarNumeros();
                        segir();
                        break;




                    //mandar un mensaje de despedida antes de finalizar el codigo 
                    case 9:
                        Console.WriteLine("adios, vuelva pronto");

                        break;


                    //indicar que la opcion ingresada da no existe
                    default:
                        Console.WriteLine("la opcion escogida no es valida \n presione cualquier tecla para continuar");

                        break;

                }
                Console.ReadKey();
            } while (opcion != 9);



        }


        /*
        ->nada 
        <-void
        funcion que muestra un menu de opciones quw podemls realizar 
        durante la clmpilacion del proyecto
        */
        public static void opciones()
        {
            Console.Clear();
            Console.WriteLine("ingrese la opcion a realizar \n");

            Console.WriteLine("1.- Intercambiar el orden del vecto");

            Console.WriteLine("\n2.- Verificar que la lista este ordenada del menor al mayor");

            Console.WriteLine("\n3.- Averiguar si la lista esta ordenada extrictamente creciente ");

            Console.WriteLine("\n4.- verificar si hay numeros repetidos");

            Console.WriteLine("\n5.- Ordenar de menor a mayor los elementos");

            Console.WriteLine("\n6.- Ingresar un numero para verificar si este existe en la lista");

            Console.WriteLine("\n7.- Hallar el promedio de la lista de numeros");

            Console.WriteLine("\n8.- Volver a llenar la lista del numeros");

            Console.Write("\n9.- salir \n- > ");
        }

        /*
        ->int array
        <- void
        funcion que muestra el array numeros
        */
        public static void mostrarArray(int[] array)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + array[i]);
            }

        }

        /*
        ->nada 
        <-int array
        solicita los 10 numeros para llenar un array
        */
        public static int[] llenarNumeros()
        {
            int[] numero = new int[10];
            Console.WriteLine("Ingrese en forma de lista 10 numeros: \n");

            for (int i = 1; i < 11; i++)
            {

                Console.Write("Ingrese el " + i + " numero: ");
                numero[i - 1] = int.Parse(Console.ReadLine());

            }

            return numero;
        }

        /*
        ->nada
        <-void 
        funcion sencilla que muestra un mensaje indicando precione cualquier tecla para continuar 
        */
        public static void segir()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar");
        }

        /*
        ->int array
        <-int array 
        funcion que recive un array y invierte el sentido de este, por ultimo este esretornado
        */


        public static int[] regresarInv(int[] array)
        {
            int[] auxArray = new int[10];
            int Y = 0;
            for (int i = 9; i > -1; i--)
            {
                auxArray[Y] = array[i];
                Y++;
            }
            return auxArray;


        }

    }
}
