using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    /*
      Species of Panthera
     */
    class PantheraLeo : Species
    {
        public PantheraLeo()
        {
            this.url = "https://en.wikipedia.org/wiki/Lion";
            this.genus = new Panthera("Africa");
            this.scientificName = "Panthera leo";
            this.commonName = "Lion";
        }
    }
}
