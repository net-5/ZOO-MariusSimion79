using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public enum FavoriteFood { Grass, Carrots, Meat, Milk, Bananas, Fish, Branches, Corn }
    public enum AnimalTypes { Elephant, Gorilla, Lion, Cat, Crocodile, Bear, Snake, Giraffe, Zebra}
    public class Animal
    {
        private string animalName;
        private AnimalTypes species;
        private FavoriteFood favoriteFood;
       

        public string AnimalName
        {
            get { return animalName; }
            private set { this.animalName = value; }      //Animals can`t change name
        }
        public AnimalTypes Species
        {
            get { return species; }
            private set { this.species = value; }     //Animal can`t change species
        }
        public FavoriteFood FavoriteMeal
        {
            get { return favoriteFood; }
            set { this.favoriteFood = value; }          //Animal can change favorite food
        }




        public Animal(string animalName,AnimalTypes species,  FavoriteFood favoriteFood)
        {
            this.AnimalName = animalName;
            this.Species = species;
            this.FavoriteMeal = favoriteFood;
            

        }

        public void Eat()
        {
            Console.WriteLine($"{this.species} {this.animalName} eat {this.favoriteFood}");
        }


    }
}
