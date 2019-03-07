using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    public enum food { fish, mouse, milk, cream}
    public enum color { white, grey, black, mixed}
    public class Kitty
    {
        public string name { get; set; }
        public color color { get; set; }
        public int age { get; set; }
        public double fullness { get; set; }
        public food food{ get; set; }
        private static Random rnd = new Random();

        public Kitty(string name)
        {
            int k = rnd.Next(0,4);
            this.name = name;
            this.color = (color)k;
            this.age = rnd.Next(1,8);
            this.fullness = 0;
        }
        public double eat(food food)
        {
            if (food == food.fish)
                fullness += 500;
            if (food == food.mouse)
                fullness += 350;
            if (food == food.milk)
                fullness += 100;
            if (food == food.cream)
                fullness += 200;
            return fullness;
        }

        public void eatMenu()
        {
            Console.WriteLine("Выберите еду для кота");
            Console.WriteLine("1 - рыба, 2 - мышь, 3 - молоко, 4 - сметана");
            int choice = 0;
            bool isChoice = Int32.TryParse(Console.ReadLine(), out choice);
            if (isChoice &&choice>0&&choice<5)
            {
                this.fullness = eat((food)choice);
                
                Console.WriteLine("Кот {0} поел {1}\nТеперь он сыт на {2} калорий",
                    name, food, fullness);               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены некорректные данные");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }     
    }
}
//Создайте класс Кошка.У кошки будет свойство «уровень сытости» и метод «съесть что-то».
//    Создайте перечисление Еда(рыба, мышь…). 
//Каждый вид еды должен по-разному изменять уровень сытости.