using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalTaskAdditional.Models
{
    internal class Student
    {
        private string _name;
        private bool _isHelpToPlagiate;
        private bool _isPlagiated;



        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        public bool IsPlagiated
        {
            get { return _isPlagiated; }
            set { _isPlagiated = value; }
        }




        public bool IsHelpToPlagiate
        {
            get { return _isHelpToPlagiate; }
            set { _isHelpToPlagiate = value; }
        }



        public Student(string name, bool isplagiated, bool ishelptoplagiate)
        {
            Name = name;
            IsPlagiated = isplagiated;
            IsHelpToPlagiate = ishelptoplagiate;

        }

    }
}
