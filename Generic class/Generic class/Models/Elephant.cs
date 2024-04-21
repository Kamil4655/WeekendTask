using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class.Models
{
    internal class Elephant : Animal
    {
        private double _weight;
        private bool _isTranied;

        
        
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }




        public bool IsTrained
        {
            get { return _isTranied; }
            set { _isTranied = value; }
        }





        public Elephant(int avglifetime, string breed, int healtpoint, Gender gender, double weight, bool istrained) : base(avglifetime, breed, healtpoint, gender)
        {
            Weight = weight;
            IsTrained = istrained;
        }

    }
}
