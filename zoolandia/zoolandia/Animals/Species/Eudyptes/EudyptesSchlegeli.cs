using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class EudyptesSchlegeli : Species
    {
        public EudyptesSchlegeli()
        {
            this.url = "https://en.wikipedia.org/wiki/Royal_penguin";
            this.genus = new Eudyptes("Antarctica");
            this.scientificName = "Eudyptes schlegeli";
            this.commonName = "Royal Penguin";
        }
    }
}
