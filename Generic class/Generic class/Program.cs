using Generic_class.Models;
using static Generic_class.Models.Animal;

namespace Generic_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Wolf wolf = new Wolf(10, "Afgan", 50, Animal.Gender.male, true,100);
            Console.WriteLine(wolf.Breed);
            Elephant elephant = new Elephant(25, "Finlandiya", 90, Animal.Gender.female, 2500, 23, false);
            wolf.Hunt(elephant);
            Console.WriteLine(elephant.HP);
            Meat meet = new Meat(25, Meat.Type.fish);

            ZooCage<Wolf, Meat> wolfCage = new ZooCage<Wolf, Meat>(wolf, meet);

            
        }
    }
}
