using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public enum FavoriteFood { Grass, Carrots, Meat, Milk, Bananas, Fish, Branches, Corn }
    public class Animal
    {
        private string animalName;
        private string species;
        private FavoriteFood favoriteFood;
        public Zoo CurrentZoo { get; set; }

        public string AnimalName
        {
            get { return animalName; }
            private set { this.animalName = value; }      //Animals can`t change name
        }
        public string Species
        {
            get { return species; }
            private set { this.species = value; }     //Animal can`t change species
        }
        public FavoriteFood FavoriteMeal
        {
            get { return favoriteFood; }
            set { this.favoriteFood = value; }          //Animal can change favorite food
        }




        public Animal(string species, string animalName, FavoriteFood favoriteFood/*, Zoo currentZoo*/)
        {
            this.AnimalName = animalName;
            this.Species = species;
            this.FavoriteMeal = favoriteFood;
            // this.CurrentZoo = currentZoo;
            //currentZoo.animalList.Add(animalName);

        }

        public void Eat()
        {
            Console.WriteLine($"{this.species} {this.animalName} eat {this.favoriteFood}");
        }


    }
}
