using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class CynomysMexicanus : Species
    {
        public CynomysMexicanus()
        {
            this.url = "https://en.wikipedia.org/wiki/Mexican_prairie_dog";
            this.genus = new Cynomys("North America");
            this.scientificName = "Cynomys mexicanus";
            this.commonName = "Mexican Prairie Dog";
        }
    }
}
