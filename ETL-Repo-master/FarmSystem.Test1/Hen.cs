using System;

namespace FarmSystem.Test1
{
    public class Hen : Animal
    {
        string _id;
        int _noOfLegs;
        public override string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        


        public override int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public override void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}