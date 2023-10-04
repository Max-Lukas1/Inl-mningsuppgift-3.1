using System;
namespace inlämningsuppgift3_1
{
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string x = Console.ReadLine();
            switch(x)
            {
                case "16":
                    Console.WriteLine("Du får vara med");
                break;
                case "17":
                    Console.WriteLine("Du får vara med");
                    break;
                case "18":
                    Console.WriteLine("Du får vara med");
                    break;
                 default: 
                    Console.WriteLine("tyvärr får du inte vara med");
                    break;
               
            }

        }
    }
}
