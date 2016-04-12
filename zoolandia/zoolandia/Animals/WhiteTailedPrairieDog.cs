using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class WhiteTailedPrairieDog : Animal, ISubterranean
    {
        public double tunnelSpeed
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void dig()
        {
            throw new NotImplementedException();
        }
    }
}
