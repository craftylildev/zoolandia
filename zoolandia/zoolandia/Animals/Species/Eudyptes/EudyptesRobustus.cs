using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class EudyptesRobustus : Species
    {
        public EudyptesRobustus()
        {
            this.url = "https://en.wikipedia.org/wiki/Snares_penguin";
            this.genus = new Eudyptes("Australia");
            this.scientificName = "Eudyptes robustus";
            this.commonName = "Snares Penguin";
        }
    }
}
