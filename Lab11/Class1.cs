using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Cat
    {
        public const int coutFeet = 4;
        public readonly bool wool=true;
        public string Name { get; set; }
        public string Color { get; set; }
        int age;

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возрасто не должен быть меньше нуля");
                }
            }
            get { return age; }

        }
        public Cat(string name, string color, int age, bool wool)
        {
            Name = name;
            Color = color;
            Age = age;
            this.wool = wool;
        }
        public void Say()
        {
            Console.WriteLine("Мяу.Меня зовут {0}.У меня {1} черный цвет. Мне {2} лет", Name, Color, Age);
        }
    }
}
