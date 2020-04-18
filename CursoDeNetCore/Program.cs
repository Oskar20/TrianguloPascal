using System;

namespace CursoDeNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo =  new int[1];
            //mostramos un mensaje y capturamos el dato ingresado desde la consola
            Console.WriteLine("Ingrese el número de pisos");
            pisos = Convert.ToInt16(Console.ReadLine());
            /* declaramos el primer ciclo for que va a recorrer dependiendo
             * el dato ingresado que esta almacenado en la variable pisos */
            for (int i = 0; i <= pisos; i++)
            {
                /* colocamos un arreglo y colocamos la variable i del ciclo for que será 
                 * el tamaño que tendrá el arreglo cada vez que el ciclo for se ejecute */
                int[] pascal = new int[i];
                for (int j = pisos; j < i; j--)
                {
                    Console.Write(" ");
                }
                //ciclo for que genera la suma de las cifras
                for (int k = 0; k < i; k++)
                {
                    //condición que evaluá la variable del ciclo for

                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;

                    }
                    else
                    {
                        //sumamos los números que están en cada posición 
                        //del arreglo para formar el triangulo
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write("[" + pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");
            }
            Console.ReadLine();

        }
    }
}
