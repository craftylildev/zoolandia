using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class EudyptesChrysocome : Species
    {
        public EudyptesChrysocome()
        {
            this.url = "https://en.wikipedia.org/wiki/Southern_rockhopper_penguin";
            this.genus = new Eudyptes("South America");
            this.scientificName = "Eudyptes chrysocome";
            this.commonName = "Southern Rockhopper Penguin";
        }
    }
}
