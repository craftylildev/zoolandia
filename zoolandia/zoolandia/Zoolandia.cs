using System;
using System.Collections.Generic;
using Zoolandia.Animals;


namespace Zoolandia
{
    class Zoolandia
    {
        static void Main(string[] args)
        {
            /*LION TEST*/
            Lion charlie = new Lion
            {
                name = "Charlie"
            };
                    
            charlie.species = new PantheraLeo();

            Console.WriteLine("{0} the {1} in the genus {2}. To find out more visit {3}.",
                charlie.name,
                charlie.species.commonName,
                charlie.species.genus.scientificName,
                charlie.species.url);


            /*ROYAL PENGUIN TEST*/
            RoyalPenguin rita = new RoyalPenguin
            {
                name = "Rita"
            };

            rita.species = new EudyptesSchlegeli();

            Console.WriteLine("{0} the {1} in the genus {2}. To find out more visit {3}.",
                rita.name,
                rita.species.commonName,
                rita.species.genus.scientificName,
                rita.species.url);


            /*WHITE TAILED PRAIRIE DOG TEST*/
            WhiteTailedPrairieDog walter = new WhiteTailedPrairieDog
            {
                name = "Walter"
            };

            walter.species = new CynomysLeucurus();

            Console.WriteLine("{0} the {1} in the genus {2}. To find out more visit {3}.",
                walter.name,
                walter.species.commonName,
                walter.species.genus.scientificName,
                walter.species.url);



            /* HABITAT */
            Habitat savanna = new Habitat();

            savanna.inhabitants = new List<Animal>();

            savanna.inhabitants.Add(charlie);
            savanna.inhabitants.Add(rita);
            savanna.inhabitants.Add(walter);

            foreach (Animal a in savanna.inhabitants)
            {
                Console.WriteLine("{0} is a {1}.", a.name, a.species.commonName);
            }


            Habitat aquarium = new Habitat();

            Habitat prairie = new Habitat();



            Console.ReadLine();
        }
    }

}
