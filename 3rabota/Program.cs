using System;

namespace _3rabota
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите дату рождения");
                Console.WriteLine("День: ");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("Месяц: ");
                string n = string.Format(Console.ReadLine());
                if (d <= 30 && d > 0)
                {
                    switch (n)
                    {
                        case "Март":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Овен");
                            else Console.WriteLine("Ваш знак зодика: Рыба"); break;
                        case "Апрель":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Телец");
                            else Console.WriteLine("Ваш знак зодика: Овен"); break;
                        case "Май":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Близнец");
                            else Console.WriteLine("Ваш знак зодика: Телец"); break;
                        case "Июнь":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Рак");
                            else Console.WriteLine("Ваш знак зодика: Близнецы"); break;
                        case "Июль":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Лев");
                            else Console.WriteLine("Ваш знак зодика: Рак"); break;
                        case "Август":
                            if (d >= 22) Console.WriteLine("Дева");
                            else Console.WriteLine("Ваш знак зодика: Лев"); break;
                        case "Сентябрь":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Весы");
                            else Console.WriteLine("Ваш знак зодика: Дева"); break;
                        case "Октябрь":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Скорпион");
                            else Console.WriteLine("Ваш знак зодика: Весы"); break;
                        case "Ноябрь":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Стрелец");
                            else Console.WriteLine("Ваш знак зодика: Скорпион"); break;
                        case "Декабрь":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Козерог");
                            else Console.WriteLine("Ваш знак зодика: Стрелец"); break;
                        case "Январь":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Водолей");
                            else Console.WriteLine("Ваш знак зодика: Козерог"); break;
                        case "Февраль":
                            if (d >= 22) Console.WriteLine("Ваш знак зодика: Рыбы");
                            else Console.WriteLine("Ваш знак зодика: Водолей"); break;
                        default: Console.WriteLine("Введите месяц или число правильно, повторите попытку"); break;
                    }

                }

                else Console.WriteLine("В месяце всего 30 дней!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
