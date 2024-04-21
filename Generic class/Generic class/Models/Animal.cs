using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class.Models
{
  
    
    public abstract class Animal
    {
        private int _avgLifeTime;
        private string _breed;
        private int _healthPoint;
        private Gender _gender;




        public Gender GenderMain
        {
            get { return _gender; }
            set { _gender = value; }
        }




        public int AvgLifeTime
        {
            get { return _avgLifeTime; }
            set { _avgLifeTime = value; }
        }



        public enum Gender
        {
            male,
            female
        }




        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }





        public int HP
        {
            get { return _healthPoint; }
            set { _healthPoint = value; }
        }



        protected Animal(int avglifetime, string breed, int healtpoint, Gender gender)
        {
            Breed = breed;
            HP = healtpoint;
            AvgLifeTime = avglifetime;
            GenderMain = gender;

        }

    }
}
