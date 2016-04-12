using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Cynomys : Genus
    {
        private string _continent;

        public string continent
        {
            get
            {
                return _continent;
            }
            set
            {
                if (value != "")
                {
                    _continent = value;
                }
            }
        }

        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Prairie_dog";
            this.trait = "is cute";
            this.commonName = "Prairie Dog";
            this.scientificName = "Cynomys";
        }

        public Cynomys()
        {
            this.init();
        }

        public Cynomys(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}