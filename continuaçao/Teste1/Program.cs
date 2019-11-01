using System;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] R = new int[10];
    int[] S = new int[10];
    int[] RESULTADO = new int[10];
    bool existe = false;
    int pos = 0;
    
    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine("insira o valor referente a R{0}", i+1);
        R[i] = int.Parse(Console.ReadLine());
    }
    
    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine("insira o valor referente a S{0}", i+1);
        S[i]=int.Parse(Console.ReadLine());
    }
    
    for(int i = 0; i < 10; i++)
    {
        existe=false;
        for(int j = 0; j < 10; j++)
        {
            if(R[i]==S[j])
            {
                for(int k = 0; k < 10; k ++)
                {
                    if(R[i]==RESULTADO[k])
                    {
                        existe=true;
                        break;
                    }
                }
                if(!existe)
                {
                    RESULTADO[pos]=R[i];
                    pos++;
                }
                break;
            }
        }
    }
    
    Console.WriteLine("\n---------- Resultado ----------\n");
    
    for(int i = 0; i< 10; i++)
    {
        Console.Write("{0,3}", RESULTADO[i]);
    }
        }
    }
}
