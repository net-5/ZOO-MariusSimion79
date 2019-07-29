using System;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zoo creation
            Zoo zoo1 = new Zoo("Vien Zoo");
            Zoo zoo2 = new Zoo("New York Zoo");

            //Zoo Renaming
            zoo2.zooName = "N.Y. Zoo";

            //Animal creation
            Animal animal1 = new Animal("Dumbo", AnimalTypes.Elephant, FavoriteFood.Grass);
            zoo1.BringAnimal(animal1, zoo1);
            Animal animal2 = new Animal("King Kong", AnimalTypes.Gorilla, FavoriteFood.Bananas);
            zoo1.BringAnimal(animal2, zoo1);
            Animal animal3 = new Animal("Leo", AnimalTypes.Lion, FavoriteFood.Meat);
            zoo1.BringAnimal(animal3, zoo1);
            Animal animal4 = new Animal("Tom", AnimalTypes.Cat, FavoriteFood.Milk);
            zoo1.BringAnimal(animal4, zoo1);
            Animal animal5 = new Animal("Dundee", AnimalTypes.Crocodile, FavoriteFood.Meat);
            zoo1.BringAnimal(animal5, zoo1);
            Animal animal6 = new Animal("Chewbacca", AnimalTypes.Gorilla, FavoriteFood.Meat);
            zoo1.BringAnimal(animal6, zoo1);
            Animal animal7 = new Animal("Vegan Leo", AnimalTypes.Lion, FavoriteFood.Grass);
            zoo1.BringAnimal(animal7, zoo1);
            Animal animal8 = new Animal("Baloo", AnimalTypes.Bear, FavoriteFood.Fish);
            zoo2.BringAnimal(animal8, zoo2);
            Animal animal9 = new Animal("Kaa", AnimalTypes.Snake, FavoriteFood.Meat);
            zoo2.BringAnimal(animal9, zoo2);
            Animal animal10 = new Animal("Melman", AnimalTypes.Giraffe, FavoriteFood.Branches);
            zoo2.BringAnimal(animal10, zoo2);
            Animal animal11 = new Animal("Alex", AnimalTypes.Zebra, FavoriteFood.Grass);
            zoo2.BringAnimal(animal11, zoo2);

            Console.WriteLine("Next, let`s feed the animal with his favorite food.");
            animal1.Eat();
            animal2.Eat();
            animal3.Eat();
            animal4.Eat();
            animal5.Eat();
            animal6.Eat();
            animal7.Eat();
            animal8.Eat();
            animal9.Eat();
            animal10.Eat();
            animal11.Eat();

            //animal1.AnimalName = "blabla";      //  Animal can`t change name.
            //animal1.Species = "blabla";         // Animal can`t change name.

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            // zoo1.FeedAnimal();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            zoo1.ZooInfo();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            zoo2.ZooInfo();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            // Transfer animals between Zoo`s
            zoo1.TransferAnimal(animal1, zoo2, zoo1);
            zoo2.TransferAnimal(animal11, zoo1, zoo2);

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            zoo1.ZooInfo();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            zoo2.ZooInfo();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

        }
    }
}
