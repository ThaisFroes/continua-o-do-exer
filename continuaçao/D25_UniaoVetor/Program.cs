using System.Text;
using System;

namespace D25_UniaoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] v1 = new int[10];
            int [] v2 = new int[10];
            int [] v3 = new int[10];

            StringBuilder uniao = new StringBuilder("União:")

            System.Console.WriteLine("Digite 10 números da sua preferência:");
            System.Console.Write(" Primeira Sequência: \n");
            for(int i = 0; i < 10; i++){
                v1[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Digite mais 10 números da sua preferência:");
            System.Console.Write("Segunda sequência: \n");
            for(int i = 0; i < 10; i++){
                v2[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("União");
            for(int i = 0; i < uniao.Length; i++){
                uniao[i] =Convert.ToInt32(v1[i].ToString() + v2[i].ToString());
                System.Console.WriteLine(uniao[i]);
            }

            System.Console.WriteLine("A união das duas sequências é:" + uniao);

            
        }
    }
}
