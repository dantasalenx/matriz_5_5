using System;

namespace matriz5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero a ser verificado: ");
            int numero = Int32.Parse(Console.ReadLine());
            int[,] matriz = new int[2, 2];
            int contador = 0;

            for (int linha = 0; linha < 2; linha++)
            {  
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine("Informe um numero: ");
                    matriz[linha, coluna] = Int32.Parse(Console.ReadLine());
                    if (numero == matriz[linha, coluna]) contador ++;
                }
            }
            /*for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    if (numero == matriz[linha, coluna]) contador++;
                }
            }*/
            Console.WriteLine("O numero {0} repetiu {1} vezes", numero, contador);
        }
    }
}