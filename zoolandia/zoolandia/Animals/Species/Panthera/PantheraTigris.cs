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
    class PantheraTigris : Species
    {
        public PantheraTigris()
        {
            this.url = "https://en.wikipedia.org/wiki/Tiger";
            this.genus = new Panthera("Asia");
            this.scientificName = "Panthera tigris";
            this.commonName = "Tiger";
        }
    }
}
