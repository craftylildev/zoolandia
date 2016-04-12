using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class CynomysLeucurus : Species
    {
        public CynomysLeucurus()
        {
            this.url = "https://en.wikipedia.org/wiki/White-tailed_prairie_dog";
            this.genus = new Cynomys("North America");
            this.scientificName = "Cynomys leucurus";
            this.commonName = "White Tailed Prairie Dog";
        }

    }
}
