﻿using System;

namespace D8_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= Desenho do Triângulo ========");
            System.Console.WriteLine();
            System.Console.Write("Digite a altura do seu triângulo: ");
            int h = int.Parse(Console.ReadLine());
            for (int i=0;i<=h;i++){
                for (int j=i; j<h; j++){
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
        }
    }
}
