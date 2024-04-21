using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalTaskAdditional.Models
{
    internal class SabirHocam
    {
        public void Fail(Student student)
        {
            if (student.IsHelpToPlagiate || student.IsPlagiated)
            {
                Console.WriteLine($"{student.Name}: kesildi ,tohmet aldi");
            }
             Console.WriteLine("kesilmedi tohmet almadi"); 
            
        }
    }
}
