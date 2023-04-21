using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Program
    {

        static void Main(string[] args)
        {
            //declaracion de las dos matrices
            int[,] array1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 },{ 7,8,9} };
            int[,] array2 = new int[3, 3] { {1,1,1 }, {5,6,1 }, {7,8,1 } };
            // declarar matriz de resultados
            int[,] array3 = new int[3, 3];
            byte fila, columna;
            //suma de las matrices
        
            array3[0, 0] = array1[0,0] + array2[0, 0];
            array3[0, 1] = array1[0, 1] + array2[0, 1];
            array3[0, 2] = array1[0, 2] + array2[0, 2]; 
            array3[1, 0] = array1[1, 0] + array2[1, 0];
            array3[1, 1] = array1[1, 1] + array2[1, 1];
            array3[1, 2] = array1[1, 2] + array2[1, 2];
            array3[2, 0] = array1[2, 0] + array2[2, 0];
            array3[2, 1] = array1[2, 1] + array2[2, 1];
            array3[2, 2] = array1[2, 2] + array2[2, 2];
            System.Console.WriteLine("La suma de las matrices es");
            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {
                    System.Console.Write("[" + array3[fila, columna] + "]");
                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();


            System.Console.WriteLine("Ingrese el numero para obtener el factorial");
            int num =Convert.ToInt32(System.Console.ReadLine());
           int  factorial = 1;
            for (int i = 1; i<= num; i++)
            {
                factorial = factorial * i;
            }
            System.Console.WriteLine("El factorial de " + num + " es " + factorial);
            System.Console.ReadLine();
        }
    }
}
