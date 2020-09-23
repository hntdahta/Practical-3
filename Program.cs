using System;
using System.Collections;
using System.Collections.Generic;
namespace Practical_3
{
    class Program
    {
        int dem = 0;
        Dictionary<int, string> listAnimal = new Dictionary<int, string>();
        public void addCat()
        {
            Cat a = new Cat();
            a.ID = dem;
            Console.WriteLine("Cat's name: ");
            a.Name = Console.ReadLine();
            Console.WriteLine("Cat's age: ");
            a.Age = int.Parse(Console.ReadLine());
            listAnimal.Add(dem, a);
            dem++;
        }
        public void addFish()
        {
            Fish a = new Fish();
            a.ID = dem;
            Console.WriteLine("Fish's name: ");
            a.Name = Console.ReadLine();
            Console.WriteLine("Fish's age: ");
            a.Age = int.Parse(Console.ReadLine());
            listAnimal.Add(dem, a);
        }
        public void addCrocodile()
        {
            Crocodile a = new Crocodile();
            a.ID = dem;
            Console.WriteLine("Crocodile's name: ");
            a.Name = Console.ReadLine();
            Console.WriteLine("Crocodile's age: ");
            a.Age = int.Parse(Console.ReadLine());
            listAnimal.Add(dem, a);
        }
        public void ViewTerrestrialAnimals()
        {

            Cat c = new Cat();

            for (int i = 0; i < listAnimal.Count; i++)

                if (listAnimal[i].GetType().Equals(c.GetType()))
                {

                    listAnimal[i].ToString();
                    c.Move();
                }
        }
        public void ViewMarineAnimals()
        {

            Fish f = new Fish();

            for (int i = 0; i < listAnimal.Count; i++)

                if (listAnimal[i].GetType().Equals(f.GetType()))
                {
                    listAnimal[i].ToString();
                    f.Move();
                }
        }
        public void ViewAllAnimals()
        {

            foreach (var item in listAnimal)

                Console.WriteLine(item);
        }
        public void DeleteAnimals()
        {
            int n;

            Console.Write("Please select a key: ");


            int.TryParse(Console.ReadLine(), out n);

            foreach (var item in listAnimal)

                if (item.Key.Equals(n))
                {

                    listAnimal.Remove(n);
                    break;
                }

            Console.WriteLine(listAnimal.Count);
        }
        static void Main(string[] args)
        {
            Program t = new Program();
            Cat c = new Cat();

            int choice;

            Console.WriteLine("1.Create a Crocodile");

            Console.WriteLine("2.Create a Cat");

            Console.WriteLine("3.Create a Fish");

            Console.WriteLine("4.View Terrestrial Animals");

            Console.WriteLine("5.View Marine Animals");

            Console.WriteLine("6.View All Animals");

            Console.WriteLine("7.Delete Animal");

            Console.WriteLine("8.Exit");
            do
            {

                Console.Write("\nPlease select an item: ");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {

                    case 1: t.addCrocodile();
                    case 2: t.addCat();
                    case 3: t.addFish();
                    case 4: t.ViewTerrestrialAnimals();
                    case 5: t.ViewMarineAnimals();
                    case 6: t.ViewAllAnimals();
                    case 7: t.DeleteAnimals();
                    case 8:
                }
            }
        }
    }
}
