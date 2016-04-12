using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    interface IAquatic
    {
        void swim();
        double swimSpeed { get; set; }
    }
}