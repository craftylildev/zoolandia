using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class CynomysParvidens : Species
    {
        public CynomysParvidens()
        {
            this.url = "https://en.wikipedia.org/wiki/Utah_prairie_dog";
            this.genus = new Cynomys("North America");
            this.scientificName = "Cynomys parvidens";
            this.commonName = "Utah Prairie Dog";
        }
    }
}
