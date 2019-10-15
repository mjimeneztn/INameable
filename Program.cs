using System;
namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jill = new Person(28, "jill");
            Dog rick = new Dog()
            {
                Breed="collie";

            }
            Console.WriteLine(jill);
            Console.WriteLine(rick);
            AgeThatThing(jill);
            AgeThatThing(rick);
        }
        static void AgeThatThing(IAge ageblething){
            ageblething.IncrementAge();

        }
    }
}
