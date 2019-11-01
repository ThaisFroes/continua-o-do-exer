using System;

namespace D28_Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite a altura do triângulo: ");
            int alturadoTriangulo = int.Parse(Console.ReadLine());

            for(int x = 0; x >= 0; x = x- 1){
                for (int y =0. y <= x; y ++){
                    System.Console.WriteLine($"*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
