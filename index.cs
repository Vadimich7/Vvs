//                                           Âàðèàíò ¹ 4
class Progam
{
    public static void Main(string[] args)
    {
        int exit = 1;
        Console.WriteLine("1 - Ðàñ¸ò ìàññû èìò");
        Console.WriteLine("2 - Âûõîä èç ïðîãðàììû");
        while (exit == 0) ;
        {



            string val;
            val = Console.ReadLine();
            while (val != "1" && val != "2")
            {
                Console.WriteLine("Âû ââåëè íåïðàâèëüíîå äåéñòâèå. Ââåäèòå 1,2 áåç ïðîáåëîâ");
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

            //íîðìà
            //Ìóæ÷èíû: 19–24 ãîäà — 21,4, 25–34 ãîäà — 21,6, 35–44 ãîäà — 22,9, 45–54 ãîäà — 25,8, áîëåå 55 ëåò — 26,6.
            //Æåíùèíû: 19–24 ãîäà — 19,5, 25–34 ãîäà — 23,2, 35–44 ãîäà — 23,4, 45–54 ãîäà — 25,2, áîëåå 55 ëåò — 27,3
            //êîíñòàíòû èìò è ïåðåìåííûå âåñà è ðîñòà
            switch (val)
            {
                case "1":
                    try
                    {


                        //ñäåëàòü òàá

                        Console.WriteLine("Ââåäèòå âàø âåñ â êã:");
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
                                    Console.WriteLine("Âû ââåëè íå ÷èëî");
                                }

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Îøèáêà ââåäèòå áîëåå ïîäõîäÿùèå çíà÷åíèÿ (âàø íàñòîÿùèé âåñ)");
                                Console.WriteLine("Ââåäèòå âàø âåñ â êã:");
                            }
                        }






                        Console.WriteLine("Ââåäèòå âàø ðîñò â ñì èëè ìåòðàõ:");
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
                                    Console.WriteLine("Âû ââåëè íå ÷èëî");
                                }

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Îøèáêà ââåäèòå áîëåå ïîäõîäÿùèå çíà÷åíèÿ (âàø íàñòîÿùèé ðîñò)");
                                Console.WriteLine("Ââåäèòå âàø ðîñò â ñì:");
                            }
                        }


                        // ïðîâåðêè äëÿ êîððåêòíîñòè ââîäà
                        if (rost > 5)
                        {
                            rost = rost / 100;
                        }
                        Console.WriteLine("Ââåäèòå âàø ïîë 1 - ìóæ÷èíà 2 - æåíùèíà");

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
                                    Console.WriteLine("Âû ââåëè íå ÷èñëî");
                                }

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Îøèáêà ââåäèòå áîëåå ïîäõîäÿùèå çíà÷åíèÿ (çíà÷åíèÿ 1 èëè äâà)");

                            }
                        }

                        double imt = (double)mass / (double)Math.Pow(rost, 2);
                        Console.WriteLine("Ââåäèòå âàø âîçðàñò");



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
                                    Console.WriteLine("Âû ââåëè íå ÷èëî");
                                }

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Îøèáêà ââåäèòå áîëåå ïîäõîäÿùèå çíà÷åíèÿ (âàø íàñòîÿùèé âîçðàñò)");

                            }
                        }
                        Console.WriteLine("=== Ðåçóëüòàòû ===");
                        Console.WriteLine($"Âàø èìò = {Math.Round(imt, 2)}");
                        //èìò îêðóãë¸ííûé äî äâóõ çíàêîâ ïîñëå çàïÿòîé


                        if (imt < vBad)
                        {
                            Console.WriteLine("Î÷åíü íèçêàÿ ìàññà òåëà! Ïîðà íà÷èíàòü íîðìàëüíî êóøàòü!");
                        }
                        else if (imt < Bad)
                        {
                            Console.WriteLine("Ó âàñ íèçêàÿ ìàññà òåëà, ïàðà íà÷èíàòü íîðìàëüíî êóøàòü!");
                        }
                        else if (imt < good)
                        {
                            Console.WriteLine("Ó âàñ îòëè÷íàÿ ìàññà òåëà! Äåðæèòåñü â òîì æå äóõå!");
                        }
                        else if (imt < notbed)
                        {
                            Console.WriteLine("Íå ïëîõàÿ ìàññà òåëà íî ïåðååäàòü òîæå íå ñòîèò");
                        }
                        else if (imt < og1)
                        {
                            Console.WriteLine("Ó âàñ èçáûòî÷íàÿ ìàññà òåëà! Íàäî ÷òî-òî äåëàòü!");
                        }
                        else if (imt < og2)
                        {
                            Console.WriteLine("Ó âàñ ñèëüíî èçáûòî÷íàÿ ìàññà òåëà! Íàâåðíîå ïîðà õóäåòü?");
                        }
                        else
                        {
                            Console.WriteLine("Ó âàñ ñëèøêîì èçáûòî÷íàÿ ìàññà  òåëà! Ïîðà ñàäèòüñÿ íà äèåòó");
                        }

                        // êîððåêòèðîâêà
                        Console.WriteLine("Âñå çíà÷åíèÿ ïðèáëèçèòåëüíû, äëÿ áîëåå òî÷íîé èíôîðìàöèè ïðîêîíñóëüòèðóéòåñü ñî ñïåöèàëèñòîì");
                        Console.WriteLine($"Âàø èäåàëüíûé âåñ = {Math.Round((double)imt * (double)Math.Pow(rost, 2))}");
                        if (pol == 1)
                        {//Ìóæ÷èíû: 19–24 ãîäà — 21,4, 25–34 ãîäà — 21,6, 35–44 ãîäà — 22,9, 45–54 ãîäà — 25,8, áîëåå 55 ëåò — 26,6.

                            if (old < 19)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò äëÿ âàøåãî âîçðàñòà - 20");
                            }
                            else if (old < 24)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 21,4");
                            }
                            else if (old < 34)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 21,6");
                            }
                            else if (old < 44)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 22,9");
                            }
                            else if (old < 54)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 25,8");
                            }
                            else if (old > 55)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 26,6");
                            }
                        }
                        else
                        {//Æåíùèíû: 19–24 ãîäà — 19,5, 25–34 ãîäà — 23,2, 35–44 ãîäà — 23,4, 45–54 ãîäà — 25,2, áîëåå 55 ëåò — 27,3
                            if (old < 19)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 19");
                            }
                            else if (old < 24)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 19,5");
                            }
                            else if (old < 34)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 23,2");
                            }
                            else if (old < 44)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 23,4");
                            }
                            else if (old < 54)

                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 25,2");
                            }
                            else if (old > 55)
                            {
                                Console.WriteLine("Ðåêîìåíäóåìàÿ èìò òåëà äëÿ âàøåãî âîçðàñòà - 27,3");
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
                    finally { Console.WriteLine("Âñå çíà÷åíèÿ ïðèáëèçèòåëüíû, äëÿ áîëåå òî÷íîé èíôîðìàööèè ïðîêîíñóëüòèðóéòåñü ñî ñïåöèàëèñòîì"); }
                case "2":
                    Console.WriteLine("Âû òî÷íî õîòèòå âûéòè èç ïðîãðàììû? Ââåäèòå ä, åñëè õîòèòå, èëè í, åñëè íå õîòèòå âûõîäèòü");
                    string yesOrNow2;
                    yesOrNow2 = Console.ReadLine();

                    while (yesOrNow2 != "ä" && yesOrNow2 != "í")
                    {
                        Console.WriteLine("Âû ââåëè íå ä èëè í. Ââåäèòå ä, åñëè õîòèòå ïðîäîëæèòü, èëè í, åñëè íå õîòèòå");
                        yesOrNow2 = Console.ReadLine();
                    }

                    switch (yesOrNow2)
                    {
                        case "ä":
                            Console.WriteLine("Âû âûøëè èç ïðîãðàììû");
                            exit = 0;
                            break;
                        case "í":
                            Console.WriteLine("Âû îñòàëèñü â ïðîãðàììå");
                            break;
                    }
                    break;

            }
        }
    }
}
