using System;

namespace EsempioFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intodurre un numero intero:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n}! = {Fattoriale(n)}");
        }

        static int Fattoriale(int n)
        {
            if(n == 0)
                return 1;
            return n*Fattoriale(n-1);
        }
    }
}
