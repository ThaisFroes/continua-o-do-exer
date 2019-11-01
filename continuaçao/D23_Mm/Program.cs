using System;

namespace D23_Mm
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int maior = 0;
            int menor = 0;

            for(int cont =0; cont <10; cont++){
                System.Console.WriteLine("Digite 10 números da sua preferência: ");
                if ((cont % 2) !=0)
                {
                    cont = vetor [maior];
                    vetor[maior] = vetor [maior -1];
                    
                }
            }

            foreach(int num in vetor)
            {
                if(num)
            }
            System.Console.WriteLine($"O menor número é "{menor}" e o maior número é " {maior}.);
            
        }
    }
}
