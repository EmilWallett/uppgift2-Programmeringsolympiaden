using System;
using System.Collections.Generic; 


namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {     

            Console.WriteLine("hur många ord vill du ha?");
            int antalord = int.Parse(Console.ReadLine());
            string[] ord2 = new string[antalord];

            for(int i = 0; i < antalord; i++) {
                Console.WriteLine("skriv ord" + (i + 1));
                string ord = Console.ReadLine();
                
            
                for(int j = ord.Length - 1; j >= 0; j--) {
                    

                    ord2[i] += Char.ToString(ord[j]);
            }

            }

            

            for (int i = antalord - 1; i >= 0; i--)
            {
                Console.Write(ord2[i].Trim( new Char[] { 'a', 'e', 'i', 'o', 'u', 'y' } ) + " "); 
            }
        }
    }
}
