using System;

class Program
{
    static void Main()
    {
        int[,] matrizA = {

            //MATRIZ ORIGINAL
            {6, 24, 1, 13},
            {13, 16, 10, 20},
            {20, 17, 15, 24},
            {1, 23, 11, 5}

            //MATRIZ INVERSA
           /* {20, 13, 18, 2},
            {1, 25, 12, 1},
            {13, 11, 7, 3},
            {20, 9, 9, 25}*/

        };

        //MENSAJE A CODIFICAR
        int[,] matrizB = {
            {19, 23, 18, 23, 17, 19, 0,  23, 6,  13, 23, 6,  4,  11, 11},
            {17, 19, 19, 19, 4,  17, 1,  19, 14, 23, 19, 0,  13, 23, 0},
            {4,  17, 4,  8,  18, 0,  0,  17, 23, 20, 17, 11, 23, 8,  23},
            {18, 8,  18, 6,  23, 6,  13, 8,  4,  13, 8,  23, 4,  19, 23} 

        //MENSAJE A DESCODIFICAR
            /*{6, 13, 22, 4, 21, 2, 11, 13, 5, 13, 13, 8, 21, 15, 24, },
            {9, 23, 2, 23, 15, 15, 16, 23, 14, 9, 23, 24, 24, 9, 1, },
            {17, 8, 5, 7, 8, 7, 17, 8, 19, 15, 8, 5, 14, 17, 25}, 
            {24, 11, 17, 6, 6, 24, 10, 11, 3, 21, 11, 8, 4, 21, 15,}*/


        };

        int filasA = matrizA.GetLength(0);
        int columnasA = matrizA.GetLength(1);
        int filasB = matrizB.GetLength(0);
        int columnasB = matrizB.GetLength(1);
        if (columnasA != filasB)
        {
            Console.WriteLine("No se pueden multiplicar las matrices. Las dimensiones no son válidas.");
            return;
        }

        int[,] matrizResultado = new int[filasA, columnasB];


        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                int suma = 0;
                for (int k = 0; k < columnasA; k++)
                {
                    suma += matrizA[i, k] * matrizB[k, j];
                }
                matrizResultado[i, j] = suma;
            }
        }


        Console.WriteLine("Matriz Resultante:");
        ImprimirMatriz(matrizResultado);

        Console.WriteLine("Matriz Mod 26:");

        ImprimirMOD(matrizResultado);
    }

    // Imprimir la matriz
    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void ImprimirMOD(int[,] matriz)
    {
int filas = matriz.GetLength(0);
int columnas = matriz.GetLength(1);

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(matriz[i, j] % 26 + " ");
    }
    Console.WriteLine();
}

char[] letra = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    Console.WriteLine();
    Console.WriteLine("MENSAJE CIFRADO");
    Console.WriteLine();

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        int filacomna = (matriz[i, j] % 26);
        



        for (int k = 0; k < letra.Length; k++)
        {
            if (filacomna == k)
            {
                Console.Write(letra[k] + " ");
                break;
            }
        }
    }
    Console.WriteLine();
}
    
    }
}