using OptionalTaskAdditional.Models;

namespace OptionalTaskAdditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kamil", true, true);
            Lion lion = new Lion();
            lion.Fail(student);

        }
    }
}
