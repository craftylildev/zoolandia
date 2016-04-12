using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class EudyptesMoseleyi : Species
    {
        public EudyptesMoseleyi()
        {
            this.url = "https://en.wikipedia.org/wiki/Northern_rockhopper_penguin";
            this.genus = new Eudyptes("Atlantic Ocean island");
            this.scientificName = "Eudyptes moseleyi";
            this.commonName = "Northern Rockhopper Penguin";
        }
    }
}
