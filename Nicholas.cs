using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11
{
    static class Nicholas
    {
        public static List<Toy> Toys { get; set; }

        public static List<FoodForChild> Food { get; set; }

        public static List<string> Wishes { get; set; }

        private static int Counter=0;

        public static Gift MakeGift(Child child)
        {
            if (child==null)
                throw new ArgumentNullException("Child is null");

            Random rand = new Random();

            if (child.CountOfGoodActions > child.CountOFBadActions)
            {
                return new Gift(GetToy(child.Gender), Wishes[rand.Next(Wishes.Count - 1)], Food[rand.Next(Food.Count - 1)]);
            }
            else return new Gift(new Toy("Withe", child.Gender), "Be more polite!!", Food[rand.Next(Food.Count - 1)]);
        }

        public static Gift MakeGift2(Child child)
        {
            Random rand = new Random();

            if (Counter >= Toys.Count)
                Counter = 0;

            return new Gift(Toys[Counter++], Wishes[rand.Next(Wishes.Count - 1)], Food[rand.Next(Food.Count - 1)]);
        }

        private static Toy GetToy(EGender gender)
        {
            Random rand = new Random();

            return Toys.FindAll(i=>i.Gender==gender)[rand.Next(Toys.FindAll(i => i.Gender == gender).Count - 1)];
        }
    }
}
