using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        List<Animal> animalObjectList = new List<Animal>();
        private List<Animal> milkableTypes = new List<Animal>();
        public delegate void farmEmptyDelegate(object source,EventArgs eventArgs);

        public event farmEmptyDelegate EventHandler;



        //TEST 1
        public void Enter(Animal animal)
        {

            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            animalObjectList.Add(animal);
            Console.WriteLine(animal.GetType().Name + " has entered the Emydex farm");

            var type = typeof(FarmSystem.Test2.IMilkableAnimal);

            if (typeof(FarmSystem.Test2.IMilkableAnimal).IsAssignableFrom(animal.GetType()))
                milkableTypes.Add(animal);

        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach (var item in animalObjectList)
            {
                Animal animal = item;
                animal.Talk();
            }

        }

        //TEST 3
        public void MilkAnimals()
        {

            foreach (var item in milkableTypes)
            {
                IMilkableAnimal milkableAnimal = item as IMilkableAnimal;
                milkableAnimal.ProduceMilk();
            }

        }

        //TEST 4


       
        public void ReleaseAllAnimals()
        {
            foreach (var item in animalObjectList)
            {
                Console.WriteLine(item.GetType().Name + " has left the farm");
            }
            animalObjectList.Clear();
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            EventHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}


    
