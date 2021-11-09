using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11
{
    class Child
    {
        public string Name { get; set; }

        public int CountOfGoodActions { get; set; }

        public EGender Gender { get; set; }

        public int CountOFBadActions { get; set; }

        public Child(string name, EGender gender,int countOfGoodActions, int countOfBadActions)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name is empty");

            Name = name;

            Gender = gender;

            CountOfGoodActions = countOfGoodActions;

            CountOFBadActions = countOfBadActions;
        }
    }
}
