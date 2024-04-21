using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class.Models
{
    public class ZooCage<T, U>
        
        where T : Animal
        where U : Food
        
    {
        
        private T _animal;
        private U _food;

        
        public T Animal
        {
            get { return _animal; }
            set { _animal = value; }
        }

        
        
        public U Food
        {
            get { return _food; }
            set { _food = value; }
        }
      
        
        public ZooCage(T animal, U food)
        {
            Animal = animal;
            Food = food;
        }

    }
}
