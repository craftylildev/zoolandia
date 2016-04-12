using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    class EudyptesChrysolophus : Species
    {
        public EudyptesChrysolophus()
        {
            this.url = "https://en.wikipedia.org/wiki/Macaroni_penguin";
            this.genus = new Eudyptes("Antarctica");
            this.scientificName = "Eudyptes chrysolophus";
            this.commonName = "Macaroni Penguin";
        }
    }
}

