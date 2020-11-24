using System;

namespace CP02TD02exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int nbElt = 10;
            int[] v = new int[nbElt];
            int max, nbFois;

            //saisie du vecteur V
            for (int i1 = 0; i1< nbElt; i1++)
            {
                Console.Write("v[" + i1 + "]=");
                v[i1] = int.Parse(Console.ReadLine());
            }

            //recherche du maximum et du nombre de fois où il apparaît.
            max = v[0];
            nbFois = 1;
            for(int i2=1; i2< nbElt; i2++)
            {//cas nouveau max
                if (max < v[i2])
                {
                    max = v[i2];
                    nbFois = 1;
                }
                else //cas apparition du max actuel
                    if (max == v[i2]) nbFois++;
            }
            //affichage des résultats
            Console.WriteLine("le maximum est " + max + " présent " + nbFois + " fois");
        }
    }
}
