using System;
using System.Collections.Generic;
using System.Text;


namespace ZOO
{
    public class Zoo
    {
        public string zooName;
        public  List<Animal> animalList = new List<Animal>();

        

        public Zoo(string zooName)
        {
            this.zooName = zooName;
        }

        public void FeedAnimal()
        {
            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Species} {animal.AnimalName} is now eating {animal.FavoriteMeal}.");
            }
        }



        public void BringAnimal(Animal animal,Zoo zooName)
        {
            animal.CurrentZoo = zooName;
            animalList.Add(animal);
        }

        public void TransferAnimal(Animal animal, Zoo destinationZoo)
        {
            
            animal.CurrentZoo = destinationZoo;
            destinationZoo.animalList.Add(animal);
            Console.WriteLine($"{animal.Species} {animal.AnimalName} has been transferred to {destinationZoo.zooName}.");
        }

        public void ZooInfo()
        {
            Console.WriteLine($"The {zooName} has {animalList.Count} animals, as follows: ");
            foreach (var animal in animalList)
            {
                Console.WriteLine($"    - {animal.Species} {animal.AnimalName}, who love to eat {animal.FavoriteMeal}.");
            }
        }




    }
}
