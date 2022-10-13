// See https://aka.ms/new-console-template for more information

using formationC;
using System;

namespace generateur_de_mot_de_passe // Note: actual namespace depends on the project name.
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Quelle est la longueur du mot de passe?");

            Console.WriteLine();

            int choixAlphabet = outils.DemanderNombreEntre("Vous voulez un mot de passe avec: \n" +
                "1/ uniquement des minuscules \n" +
                "2/ des minuscules et des majuscules \n" +
                "3/ des lettres et des chiffres \n" +
                "4/ des lettres, des chiffres et des caractères spéciaux \n" +
                "Votre choix: ", 1, 4);
            Console.WriteLine();
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "123456789";
            string caracteres = "éèà&";
            string alphabet;
            string mdp = "";

            Random rand = new Random();

            if (choixAlphabet == 1)
            {
                alphabet = minuscules;
            }
            else if (choixAlphabet == 2)
            {
                alphabet = minuscules + majuscules;
            }
            else if (choixAlphabet == 3)
            {
                alphabet = minuscules + chiffres + majuscules;
            }
            else
            {
                alphabet = minuscules + majuscules + chiffres + caracteres;
            }

            int l = alphabet.Length;


            for ( int NB_MDP= 5; NB_MDP >0; NB_MDP--)
            {
                mdp = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, l);
                    mdp += alphabet[index];
                    
                }

                Console.WriteLine($"mot de passe: {mdp}");
               
            }
        }
    }
}


