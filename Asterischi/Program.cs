using System;

namespace Asterischi
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int righe;
            
            while(true)
            {
                Console.WriteLine("Inserisci un numero ('no' per uscire): ");

                s = Console.ReadLine();
                
                if(s.ToLower() == "no") 
                    break;

                righe = Convert.ToInt32(s);

                for(int r = 1; r <= righe; r++)
                {
                    for(int ast = 0; ast <= r; ast++)
                    {
                        Console.Write("* ");
                    }
                
                   Console.Write("\n");
                }

            }

            Console.WriteLine("The end!");
        }
    }
}
