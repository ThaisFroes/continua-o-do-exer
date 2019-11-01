using System;

namespace D19_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            System.Console.WriteLine("Digite a quantidade de números que prefirir."); 
            n = int.Parse(Console.ReadLine());

            int[] dados = new int[n];

            for(int cont = 0; cont < n; cont++){
                System.Console.Write($" Começa a digitar cacete ");
                dados[cont] = int.Parse(Console.ReadLine());
            }
            foreach(int num in dados){
                System.Console.WriteLine($"{num}");
            }
        }
    }
}
