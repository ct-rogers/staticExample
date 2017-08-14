using System;

namespace staticExample
{

    public class Person
    {
        public string Name { get; set; }
        private static int Population { get; set; }

        public Person()
        {
            Person.IncreasePopulation();
        }
       
        public void SayHello()
        {
            Console.WriteLine("Hello my name is " + this.Name);
        }

        public static void IncreasePopulation()
        {
            Person.Population++;
        }

        public static int GetPopulation()
        {
            return Person.Population;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var paul = new Person{Name = "Paul"};
            var steve = new Person{Name = "Steve"};

            steve.SayHello();

            Console.WriteLine(Person.GetPopulation());

        }
    }
}
