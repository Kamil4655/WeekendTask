using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class.Models
{
    internal class Meat : Food
    {
        private Type _type;

       
        
        
        public Type TypeMain
        {
            get { return _type; }
            set { _type = value; }
        }
        
        
        
        public enum Type
        {
            chicken,
            cowMeat,
            baccon,
            fish

        }

       
        
        public Meat(int calorie, Type type) : base(calorie)
        {
            TypeMain = type;
        }
    }
}
