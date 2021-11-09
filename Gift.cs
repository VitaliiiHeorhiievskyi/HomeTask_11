using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum FoodForChild
{
    Chocholate,
    Kinder,
    Snack,
    Mandarins
}

namespace HomeTask_11
{
    class Gift
    {
        public Toy PlayThing { get; set; }

        public string Wish { get; set; }

        public FoodForChild Food { get; set; }

        public Gift(Toy toy, string wish, FoodForChild food)
        {
            PlayThing = toy;

            Wish = wish;

            Food = food;
        }

        public override string ToString()
        {
            return $"Toy: {PlayThing.Name}.\nWish: {Wish}\nFood: {Food}";
        }
    }
}
