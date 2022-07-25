using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal , IMilkableAnimal
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
            Console.WriteLine("Cow says Moo!");
        }

        public  void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public  void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}