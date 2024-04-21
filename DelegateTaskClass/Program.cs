using DelegateTask.Models;

namespace DelegateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new Group("AB106");
            Group ab105 = new Group("AB105");

            List<Student> students = new List<Student>();
            students.Add(new Student("Kamil", "Qehremanov", 20, 290, ab106));
            students.Add(new Student("Anar", "Amanli", 20, 200, ab106));
            students.Add(new Student("Rauf", "Dostuyeev", 20, 180, ab105));

            // AB106 qrupunda olanlar
            
            students.FindAll(s => s.Group == ab106).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            students.FindAll(s => s.Credit < 2400).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
               
                
            
            
           // Ad Soyada gore tapma;
           students.FindAll(s => s == s).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + "" + s.Surname)); 

            

            // Adinda a olan telebeler gostersin
            students.FindAll(s => s.Name.ToLower().Contains("a")).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));


            // Kredit sayina gore telebelerin siralanmasi
            students.OrderBy(s => s.Credit).ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Credit));

            
            // Umumi Kreditlerin Cemini tapmaq
            Console.WriteLine(students.Sum(s => s.Credit));

            
            // 18 yasdan asagi olanlar
            Console.WriteLine(students.Any(s => s.Age < 18));

            
            // en az 200 kredit varmi
            Console.WriteLine(students.Any(s => s.Credit < 200));
            
            



        }
    }
}