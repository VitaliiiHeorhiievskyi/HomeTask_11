using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Nicholas.Toys = new List<Toy> {new Toy("Car",EGender.Boy), new Toy("Lego", EGender.Boy),
                new Toy("Pistol", EGender.Boy), new Toy("Computer game", EGender.Boy),
            new Toy("Computer game", EGender.Girl),new Toy("Barby", EGender.Girl),
                new Toy("Pop It", EGender.Girl)};

            Nicholas.Wishes = new List<string> { "Wishing you a very Happy St. Nicholas Day….. May He fill your life with happiness and shoes with lots of gifts.",
                "On this pious day, I wish that your St. Nicholas Day is blessed with all the happiness and love….. " +
                "kindness and generosity…..health and wealth….. May you and your loved ones celebrate this special " +
                "occasion with great joy and merriment.",
                "Wishing you and your family a very happy, " +
                "blessed and joyous St. Nicholas…. ", 
                "I wish that you and your family is today and always blessed with happiness and health",
                "Wishing you a very Happy St. Nicholas Day." };

            Nicholas.Food = new List<FoodForChild> { FoodForChild.Chocholate, FoodForChild.Kinder, FoodForChild.Snack, FoodForChild.Mandarins };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = textBox1.Text;

                int countOfGoodActions = (int)numericUpDown1.Value;

                int countOfBadActions = (int)numericUpDown2.Value;

                EGender gender = radioButton1.Checked ? EGender.Boy : EGender.Girl;

                if(radioButton3.Checked)
                    MessageBox.Show(Nicholas.MakeGift2(new Child(name, gender, countOfGoodActions, countOfBadActions)).ToString());
               else MessageBox.Show(Nicholas.MakeGift(new Child(name, gender, countOfGoodActions, countOfBadActions)).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
