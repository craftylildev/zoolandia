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
    class PantheraPardus : Species
    {
        public PantheraPardus()
        {
            this.url = "https://en.wikipedia.org/wiki/Leopard";
            this.genus = new Panthera("Africa");
            this.scientificName = "Panthera pardus";
            this.commonName = "Leopard";
        }
    }
}
