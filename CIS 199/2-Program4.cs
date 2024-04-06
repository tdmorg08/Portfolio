//S2337
//CIS-199-50
//04/18/2023
//This program lists dogs and cats

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program_4.Cat;

namespace Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

                  
             //list of cats      
            Cat[] cats = { new Cat("Tom", "Siamese", "M", 4, "White", 500.00),
                           new Cat("Jerry", "Persian", "F", 3, "Black", 600.00),
                           new Cat("Luna", "Bengal", "F", 2, "Brown", 700.00),
                           new Cat("Mittens", "Maine Coon", "F", 5, "Gray", 400.00),
                           new Cat("Simba", "Sphynx", "M", 1, "Tan", 800.00) };
           
            //list of dogs
            Dog[] dogs = { new Dog("Phil", "German Sheperd", "M", 4, "Black", 525.00),
                           new Dog("Bob", " Boston Terrier", "F", 6, "Black", 300.00),
                           new Dog("Grey", "Shi-Tzu", "F", 2, "White", 750.00),
                           new Dog("Julie", "Gray Hound", "F", 9, "Gray", 210.00),
                           new Dog("Ben", "Golden doodle", "M", 3, "Gold", 900.00) };
            
            //display list of pets
            Console.WriteLine("List of Pets:");
            Console.WriteLine("-----------");
            DisplayCats(cats);
            DisplayDogs(dogs);

            Console.WriteLine("After 1st Change:");
            Console.WriteLine("-----------");
            // changing the 1st cat's fur color
            cats[0].CatFurColor = "Black";
            DisplayCats(cats);
            DisplayDogs(dogs);

            Console.WriteLine("After 2nd Change:");
            Console.WriteLine("-----------");
            // changing the 3rd dog's breed and price
            dogs[2].DogAge = 10;
            dogs[2].DogPrice = 800.00;
            DisplayCats(cats);
            DisplayDogs(dogs);


            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine(); 

        }

        //display info of array of dogs
        static void DisplayDogs(Dog[] dogs)
        {
            Console.WriteLine("Dogs:");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog);
            }
            Console.WriteLine();
        }
        //display info of array of cats
        static void DisplayCats(Cat[] cats)
        {
            Console.WriteLine("Cats:");
            foreach (Cat cat in cats)
            {
                Console.WriteLine(cat);
            }
            Console.WriteLine();
        }

    }
    //class for cat objects
    public class Cat
    {
        //storing cat properties
        private string _catName;
        private string _catBreed;
        private string _catGender;
        private int _catAge;
        private string _catFurColor;
        private double _catPrice;
        private bool _isAvailable;

        //constructor of cat class to create new objects
        // precondition: all parameters can not be null or empty strings.
        // postcondition: a new instance of a cat is created with the values.
        public Cat(string catName, string catBreed, string catGender, int catAge, string catFurColor, double catPrice)
        {
            //properties 
            CatName = catName;
            CatBreed = catBreed;
            CatGender = catGender;
            CatAge = catAge;
            CatFurColor = catFurColor;
            CatPrice = catPrice;
            IsAvailable();
        }

        public string CatName
        {
            get { return _catName; }
            set { _catName = value; }
        }

        public string CatBreed
        {
            get { return _catBreed; }
            set { _catBreed = value; }
        }

        public string CatGender
        {
            get { return _catGender; }
            set { _catGender = value; }
        }

        public int CatAge
        {
            get { return _catAge; }
            set { _catAge = (value >= 0 && value <= 20) ? value : 3; }
        }

        public string CatFurColor
        {
            get { return _catFurColor; }
            set { _catFurColor = value; }
        }

        public double CatPrice
        {
            get { return _catPrice; }
            set { _catPrice = value; }
        }

        public void IsAvailable()
        {
            _isAvailable = true;
        }

        public void IsAdopted()
        {
            _isAvailable = false;
        }

        public bool Availability()
        {
            return _isAvailable;
        }
        //overrides the ToString method to display the cat object properties 
        public override string ToString()
        {
            return $"Name: {CatName}{Environment.NewLine}" +
                   $"Breed: {CatBreed}{Environment.NewLine}" +
                   $"Gender: {CatGender}{Environment.NewLine}" +
                   $"Age: {CatAge}{Environment.NewLine}" +
                   $"Fur Color: {CatFurColor}{Environment.NewLine}" +
                   $"Price: {CatPrice}{Environment.NewLine}" +
                   $"Is Available: {Availability()}{Environment.NewLine}";
        }
    }
    //class for dog objects
    public class Dog
    {
        //storing dog properties
        private string _dogName;
        private string _dogBreed;
        private string _dogGender;
        private int _dogAge;
        private string _dogFurColor;
        private double _dogPrice;
        private bool _isAvailable;

        //constructor of dog class to create new objects
        // precondition: all parameters can not be null or empty strings.
        // postcondition: a new instance of a dog is created with the values.
        public Dog(string dogName, string dogBreed, string dogGender, int dogAge, string dogFurColor, double dogPrice)
        {
            //properties
            DogName = dogName;
            DogBreed = dogBreed;
            DogGender = dogGender;
            DogAge = dogAge;
            DogFurColor = dogFurColor;
            DogPrice = dogPrice;
            IsAvailable();

        }
        public string DogName
        {
            get { return _dogName; }
            set { _dogName = value; }
        }

        public string DogBreed
        {
            get { return _dogBreed; }
            set { _dogBreed = value; }
        }

        public string DogGender
        {
            get { return _dogGender; }
            set { _dogGender = value; }
        }

        public int DogAge
        {
            get { return _dogAge; }
            set { _dogAge = (value >= 0 && value <= 20) ? value : 3; }
        }
        public string DogFurColor
        {
            get { return _dogFurColor; }
            set { _dogFurColor = value; }
        }

        public double DogPrice
        {
            get { return _dogPrice; }
            set { _dogPrice = value; }
        }

        public void IsAvailable()
        {
            _isAvailable = true;
        }

        public void IsAdopted()
        {
            _isAvailable = false;
        }

        public bool Availability()
        {
            return _isAvailable;
        }
        //overrides the ToString metho to display the dog object properties
        public override string ToString()
        {
            return $"Name: {DogName}{Environment.NewLine}" +
                   $"Breed: {DogBreed}{Environment.NewLine}" +
                   $"Gender: {DogGender}{Environment.NewLine}" +
                   $"Age: {DogAge}{Environment.NewLine}" +
                   $"Fur Color: {DogFurColor}{Environment.NewLine}" +
                   $"Price: {DogPrice}{Environment.NewLine}" +
                   $"Is Available: {Availability()}{Environment.NewLine}";
        }

    }
}




