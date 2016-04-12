using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class CynomysLudovicianus : Species
    {
        public CynomysLudovicianus()
        {
            this.url = "https://en.wikipedia.org/wiki/Black-tailed_prairie_dog";
            this.genus = new Cynomys("North America");
            this.scientificName = "Cynomys ludovicianus";
            this.commonName = "Black Tailed Prairie Dog";
        }
    }
}
