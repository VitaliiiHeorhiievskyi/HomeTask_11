using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum EGender
{
    Girl,
    Boy
}

namespace HomeTask_11
{
    class Toy
    {
        public string Name { get; set; }

        public EGender Gender  { get; set; }

        public Toy(string name, EGender gender)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name is empty");

            Name = name;
            
            Gender = gender;
        }
    }
}
