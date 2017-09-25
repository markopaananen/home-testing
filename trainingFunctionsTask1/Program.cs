using System;

namespace trainingFunctionsTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, lasketaan kolmion tai suorakaiteen ala\n");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Suorakaiteen vai kolmion ala (S/K))\n");
            string userInput = Console.ReadLine();
            int uAla = 0;

            Console.Write("Anna kanta:\n");
            string userKanta = Console.ReadLine();
            //int valueKanta = int.TryParse(userKanta, out int uKanta);
             int.TryParse(userKanta, out int uKanta);

            Console.WriteLine("Anna korkeus\n");
            string userKorkeus = Console.ReadLine();
            //int valueKorkeus = int.TryParse(userKorkeus, out int uKorkeus);
            int.TryParse(userKorkeus, out int uKorkeus);

            Console.WriteLine ("Pinta-ala :{0}", calcArea(userInput, uKanta, uKorkeus, uAla));
            
            //Console.WriteLine("Vastaus alan suuruuteen on : {0} ", calcArea((userInput, uKanta, uKorkeus));
            Console.WriteLine("Press any key to continue,,,");
            Console.ReadKey();



            int calcArea(string UI, int Kanta, int Korkeus, int tulostaAla)
            {
                //int tulostaAla = 0;
                if (UI == "S")
                {
                    tulostaAla  = Kanta * Korkeus;  
                }
                else
                {
                    tulostaAla = (Kanta * Korkeus) / 2;

                }
                return tulostaAla;
            }
        }
    }
}
