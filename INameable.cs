namespace practice
{
    public interface INameable
{
    string Name {get; set;}
}
public interface IAge
{
    int Age {get;}
    void IncrementAge();
}
 public class Mamal {
        public double FurPercentage {get; set;}
    }
public class Person : Mamal, INameable, IAge
{
    public Person(int age, string name)
    {
        Age = age;
        Name= name;
    }
    public string Name {get; set;}
    public int Age {get; private set;}
    public void IncrementAge(){
        Age ++;
    }
    public override string ToString(){
        return $"{Name} is {Age} years old";
    }

}
    public class Dog : Mamal, INameable, IAge
    {
        public Dog(){
            Age=0;
        }
        public string Breed {get; set;}
        public string Name {get; set;}
        public int Age {get; set;}

        public void IncrementAge()
        {
            Age++;
            if (Age > 20)
            {
                Console.Writeline("That's an old dog");
            }
        }
        public override string ToString(){
        return $"{Breed} is {Age} years old";
    }
    }
}
