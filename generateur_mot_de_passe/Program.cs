// See https://aka.ms/new-console-template for more information

using System;

namespace generateur_de_mot_de_passe // Note: actual namespace depends on the project name.
{
    class Program
    {
        static int DemanderNombrePositifNonNul(string question)
        {

           
                int nombre = DemanderNombre(question);
                if (nombre > 0)
                {
                    return nombre;
                }
                Console.WriteLine($"Le nombre doit être supérieur à 0 ");
            return DemanderNombrePositifNonNul(question);
        }
        static int DemanderNombreEntre(string question, int min, int max)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);
                if ((nombre >= min) && (nombre <= max))
                {
                    return nombre;
                }
                Console.WriteLine($"Le nombre doit être compris entre {min} et {max} ");
             
            }
            
        }
        static int DemanderNombre(string question)
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
                }
            
            }
           
        }
        static void Main(string[] args)
        {
            int longueurMotDePasse = DemanderNombre("Quelle est la longueur du mot de passe?");
        }
    }
}


