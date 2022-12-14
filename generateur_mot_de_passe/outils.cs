using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formationC

{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {


            int nombre = DemanderNombre(question);
            if (nombre > 0)
            {
                return nombre;
            }
            Console.WriteLine($"Le nombre doit être supérieur à 0 ");
            Console.WriteLine();
            return DemanderNombrePositifNonNul(question);
        }
        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPerso= null)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);
                if ((nombre >= min) && (nombre <= max))
                {
                    return nombre;
                }
                if (messageErreurPerso == null)
                {
                    Console.WriteLine($"Le nombre doit être compris entre {min} et {max} ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(messageErreurPerso);
                }
            }

        }
        public static int DemanderNombre(string question)
        {

            while (true)
            {
                Console.WriteLine(question);
                string reponse = Console.ReadLine();
                try
                {
                    int responseNum = int.Parse(reponse);
                    return responseNum;
                }
                catch
                {
                    Console.WriteLine("Veuillez choisir un nombre au format valide");
                    Console.WriteLine( );
                }

            }

        }
    }
}
