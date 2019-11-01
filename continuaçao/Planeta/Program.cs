using System;

namespace Planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Pplaneta, pterra, planeta;

            System.Console.WriteLine("Digite um peso qualquer: ");
            pterra=Console.ReadLine();

            Console.WriteLine("Digite o número do Planeta que você escolheu: \n0.37 1-Mercúrio \n0.88 2-Vênus \n0.38 3-Marte \n2.64 4-Júpiter \n1.15 5-Saturno \n1.17 6-Urano");

            Pplaneta = (pterra/10);

            switch(planeta){
                case "1":
                planeta = planeta * 0.37;
                System.Console.WriteLine("Em Mercúrio esse peso é "+ Pplaneta);
                break;

                case "2":
                planeta = planeta * 0.88;
                System.Console.WriteLine("Em Vênus esse peso é "+ Pplaneta*0.88);
                break;

                case "3":
                planeta = planeta * 0.38;
                System.Console.WriteLine("Em Marte esse peso é "+ Pplaneta*0.38);
                break;

                case "4":
                planeta = planeta * 2.64;
                System.Console.WriteLine("Em Júpiter esse peso é "+ Pplaneta*2.54);
                break;

                case "5":
                planeta = planeta * 1.15;
                System.Console.WriteLine("Em Saturno esse peso é "+ Pplaneta*1.15);
                break;

                case "6":
                planeta = planeta * 1.17;
                System.Console.WriteLine("Em Urano esse peso é "+ Pplaneta*1.17);
                break;

                default:
                Console.WriteLine("Operação Invalida!");
                break;
            }
        }
    }
}
