using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public abstract class Animal
    {

        public abstract  string Id { get; set; }
        public abstract int NoOfLegs { get; set; }
        public abstract void Talk();
        public abstract void Run();
    }
}
