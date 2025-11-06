//                                           Вариант № 4
class Progam
{
    public static void Main(string[] args)
    {
        int exit = 1;
        Console.WriteLine("1 - Расёт массы имт");
        Console.WriteLine("2 - Выход из программы");
        while (exit == 0) ;
        {



            string val;
            val = Console.ReadLine();
            while (val != "1" && val != "2")
            {
                Console.WriteLine("Вы ввели неправильное действие. Введите 1,2 без пробелов");
                val = Console.ReadLine();
            }

            const double vBad = 16;
            const double Bad = 18.5;
            const double good = 22;
            const double notbed = 25;
            const double og1 = 30;
            const double og2 = 35;
            const double og3 = 40;
            float pol = 0;
            float mass = 0;
            float rost = 0;
            int value;
            float old = 0;

            //норма
            //Мужчины: 19–24 года — 21,4, 25–34 года — 21,6, 35–44 года — 22,9, 45–54 года — 25,8, более 55 лет — 26,6.
            //Женщины: 19–24 года — 19,5, 25–34 года — 23,2, 35–44 года — 23,4, 45–54 года — 25,2, более 55 лет — 27,3
            //константы имт и переменные веса и роста
            switch (val)
            {
                case "1":
                    try
                    {


                        //сделать таб

                        Console.WriteLine("Введите ваш вес в кг:");
                        bool isValid = false;
                        while (!isValid)
                        {
                            try
                            {
                                if (float.TryParse(Console.ReadLine(), out mass))
                                {
                                    if (mass >= 300 && mass <= 30)
                                    {
                                        throw new ArgumentOutOfRangeException();
                                    }

                                    isValid = true;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не чило");
                                }

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Ошибка введите более подходящие значения (ваш настоящий вес)");
                                Console.WriteLine("Введите ваш вес в кг:");
                            }
                        }






                        Console.WriteLine("Введите ваш рост в см или метрах:");
                        bool isValid1 = false;
                        while (!isValid1)
                        {
                            try
                            {
                                if (float.TryParse(Console.ReadLine(), out rost))
                                {
                                    if ((rost >= 2.5 && rost <= 1) || (rost >= 250 && rost <= 100))
                                    {
                                        throw new ArgumentOutOfRangeException();
                                    }

                                    isValid1 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не чило");
                                }

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Ошибка введите более подходящие значения (ваш настоящий рост)");
                                Console.WriteLine("Введите ваш рост в см:");
                            }
                        }


                        // проверки для корректности ввода
                        if (rost > 5)
                        {
                            rost = rost / 100;
                        }
                        Console.WriteLine("Введите ваш пол 1 - мужчина 2 - женщина");

                        bool isValid2 = false;
                        while (!isValid2)
                        {
                            try
                            {
                                if (float.TryParse(Console.ReadLine(), out pol))
                                {
                                    if (pol > 2 || pol < 1)
                                    {
                                        throw new ArgumentOutOfRangeException();
                                    }

                                    isValid2 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не число");
                                }

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Ошибка введите более подходящие значения (значения 1 или два)");

                            }
                        }

                        double imt = (double)mass / (double)Math.Pow(rost, 2);
                        Console.WriteLine("Введите ваш возраст");



                        bool isValid3 = false;
                        while (!isValid3)
                        {
                            try
                            {
                                if (float.TryParse(Console.ReadLine(), out old))
                                {
                                    if (old < 1 || old > 100)
                                    {
                                        throw new ArgumentOutOfRangeException();
                                    }

                                    isValid3 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не чило");
                                }

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Ошибка введите более подходящие значения (ваш настоящий возраст)");

                            }
                        }
                        Console.WriteLine("=== Результаты ===");
                        Console.WriteLine($"Ваш имт = {Math.Round(imt, 2)}");
                        //имт округлённый до двух знаков после запятой


                        if (imt < vBad)
                        {
                            Console.WriteLine("Очень низкая масса тела! Пора начинать нормально кушать!");
                        }
                        else if (imt < Bad)
                        {
                            Console.WriteLine("У вас низкая масса тела, пара начинать нормально кушать!");
                        }
                        else if (imt < good)
                        {
                            Console.WriteLine("У вас отличная масса тела! Держитесь в том же духе!");
                        }
                        else if (imt < notbed)
                        {
                            Console.WriteLine("Не плохая масса тела но переедать тоже не стоит");
                        }
                        else if (imt < og1)
                        {
                            Console.WriteLine("У вас избыточная масса тела! Надо что-то делать!");
                        }
                        else if (imt < og2)
                        {
                            Console.WriteLine("У вас сильно избыточная масса тела! Наверное пора худеть?");
                        }
                        else
                        {
                            Console.WriteLine("У вас слишком избыточная масса  тела! Пора садиться на диету");
                        }

                        // корректировка
                        Console.WriteLine("Все значения приблизительны, для более точной информации проконсультируйтесь со специалистом");
                        Console.WriteLine($"Ваш идеальный вес = {Math.Round((double)imt * (double)Math.Pow(rost, 2))}");
                        if (pol == 1)
                        {//Мужчины: 19–24 года — 21,4, 25–34 года — 21,6, 35–44 года — 22,9, 45–54 года — 25,8, более 55 лет — 26,6.

                            if (old < 19)
                            {
                                Console.WriteLine("Рекомендуемая имт для вашего возраста - 20");
                            }
                            else if (old < 24)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 21,4");
                            }
                            else if (old < 34)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 21,6");
                            }
                            else if (old < 44)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 22,9");
                            }
                            else if (old < 54)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 25,8");
                            }
                            else if (old > 55)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 26,6");
                            }
                        }
                        else
                        {//Женщины: 19–24 года — 19,5, 25–34 года — 23,2, 35–44 года — 23,4, 45–54 года — 25,2, более 55 лет — 27,3
                            if (old < 19)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 19");
                            }
                            else if (old < 24)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 19,5");
                            }
                            else if (old < 34)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 23,2");
                            }
                            else if (old < 44)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 23,4");
                            }
                            else if (old < 54)

                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 25,2");
                            }
                            else if (old > 55)
                            {
                                Console.WriteLine("Рекомендуемая имт тела для вашего возраста - 27,3");
                            }
                            int[] weights = new int[20];
                            for (int i = 0; i < 20;)
                            {
                                weights[i] = 0;
                                i = i + 1;

                            }
                            Console.WriteLine("");
                        }
                        break;
                    }
                    finally { Console.WriteLine("Все значения приблизительны, для более точной информацции проконсультируйтесь со специалистом"); }
                case "2":
                    Console.WriteLine("Вы точно хотите выйти из программы? Введите д, если хотите, или н, если не хотите выходить");
                    string yesOrNow2;
                    yesOrNow2 = Console.ReadLine();

                    while (yesOrNow2 != "д" && yesOrNow2 != "н")
                    {
                        Console.WriteLine("Вы ввели не д или н. Введите д, если хотите продолжить, или н, если не хотите");
                        yesOrNow2 = Console.ReadLine();
                    }

                    switch (yesOrNow2)
                    {
                        case "д":
                            Console.WriteLine("Вы вышли из программы");
                            exit = 0;
                            break;
                        case "н":
                            Console.WriteLine("Вы остались в программе");
                            break;
                    }
                    break;

            }
        }
    }
}