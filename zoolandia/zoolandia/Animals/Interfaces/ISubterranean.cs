using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoolandia.Animals
{
    interface ISubterranean
    {
        void dig();
        double tunnelSpeed { get; set; }
    }
}