using System;

namespace nombre_magique
{
    class Program
    {
        // DemanderNombre
        // afficher : Rentrez un nombre
        // tester si ce nombre est valide (convertion -> try/catch) -> ERREUR : ce nombre n'est pas valide
        // reboucler tant que le nombre n'est pas valide
        // considérer que 0 est invalide
        // retourner la valeur (int)

        static int DemanderNombre(int min, int max)
        {
            int nombreUtilisateur = max + 1;

            while ((nombreUtilisateur < min) || (nombreUtilisateur > max))
            {
                Console.Write("Rentrez un nombre entre " + min + " et " + max + " : ");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if ((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine("ERREUR : le nombre doit être entre " + min + " et " + max);
                    }

                    // tester si nombreUtilisateur entre min et max
                    // ERREUR
                    // nombreUtilisateur = 0 <- forcer à reboucler
                }
                catch
                {
                    Console.WriteLine("ERREUR : rentrez un nombre valide");
                }
            }

            return nombreUtilisateur;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX+1);


            int nombre = NOMBRE_MAGIQUE+1;

            int nbVies = 4;

            while (nbVies > 0)  // tant qu'on a encore des vies
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + nbVies);
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                // comparer nombre à NOMBRE_MAGIQUE
                // 1 - le nombre magique est plus petit
                // 2 - le nombre magique est plus grand
                // 3 - Bravo, vous avez trouvé le nombre magique
                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("le nombre magique est plus grand");
                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                }
                else
                {
                    // j'ai trouvé le nombre magique
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
                    break;
                }
                nbVies--;
            }

            if (nbVies == 0) 
            { 
                Console.WriteLine("Vous avez perdu, le nombre magique était : " + NOMBRE_MAGIQUE);
            }
            
            

            // Random

            /*Random rand = new Random();
            for (int i = 0; i< 10; i++)
            {
                int valeurAleatoire = rand.Next(1, 10000);
                Console.WriteLine("Nombre aléatoire : " + valeurAleatoire);
            }*/
            
        }
    }
}
