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
    class PantheraOnca : Species
    {
        public PantheraOnca()
        {
            this.url = "https://en.wikipedia.org/wiki/Jaguar";
            this.genus = new Panthera("Americas");
            this.scientificName = "Panthera onca";
            this.commonName = "Jaguar";
        }
    }
}
