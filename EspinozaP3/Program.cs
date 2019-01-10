using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspinozaP3
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            string[] nombres = new string[MAX];
            int[] y = new int[MAX];

            int[,] matriz = new int[5, 5];

            Console.WriteLine("\nINGRESE LOS NOMBRES");
            leerNombresSueldos(nombres, y);
            imprimirNombres(nombres, y);

            Console.WriteLine("\nNOMBRESS ORDENADOS");
            ordenarNombresSueldo(nombres, y);
            imprimirNombres(nombres, y);
            ordenarNombresSueldos(nombres, y);
            Console.WriteLine("\n El sueldo Maximo es:{0} y es de : {1}", y[0], nombres[0]);
            Console.WriteLine("\n El sueldo Maximo es:{0} y es de : {1}", y[MAX-1], nombres[MAX-1]);




            Console.ReadKey();
        }

        public static void leerNombresSueldos(string[] x, int[] y)
        {
            Console.WriteLine("Ingrese sus nombres y sus sueldos");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nIngresa los nombres {0}", i + 1);
                x[i] = Console.ReadLine();
                Console.WriteLine("\nIngresa los sueldos {0}", i + 1);
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public static void ordenarNombresSueldo(string[] x, int[] y)
        {
            string aux = "";
            int au = 0;
            for (int i = 0; i < x.Length; i++)
                for (int j = i + 1; j < (x.Length); j++)
                    if (x[i].CompareTo(x[j]) < 0)
                    {
                        aux = x[i];
                        au = y[i];
                        x[i] = x[j];
                        y[i] = y[j];
                        x[j] = aux;
                        y[j] = au;
                    }
        }
        public static void ordenarNombresSueldos(string[] x, int[] y)
        {
            string aux = "";
            int au = 0;
            for (int i = 0; i < y.Length; i++)
                for (int j = i + 1; j < (y.Length); j++)
                    if (y[i].CompareTo(y[j]) < 0)
                    {
                        aux = x[i];
                        au = y[i];
                        x[i] = x[j];
                        y[i] = y[j];
                        x[j] = aux;
                        y[j] = au;
                    }
        }


        public static void imprimirNombres(string[] x, int [] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("\n El Nombre es {0} y su sueldo indicado es {1}; ", x[i],  y[i] );
            }
        }
        
        public static void ordenarSueldo(int [] y)
        {

        }


       




    }
}
