using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class CynomysGunnisoni : Species
    {
        public CynomysGunnisoni()
        {
            this.url = "https://en.wikipedia.org/wiki/Gunnison%27s_prairie_dog";
            this.genus = new Cynomys("North America");
            this.scientificName = "Cynomys gunnisoni";
            this.commonName = "Gunnison's Prairie Dog";
        }
    }
}
