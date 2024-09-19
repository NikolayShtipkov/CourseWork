//====================== Задача 365 ===================
//Задача 365. Съставете метод, който при зададен ЕГН връща датата на раждане на притежателя на ЕГН по следния начин:
//а) 7524169268 Дата на раждане 16.04.1875г.
//б) 7524169268 Дата на раждане 16-ти април 1875г.
//в) 7524169268 Дата на раждане шестнадесети април 1875г.
//г) 7524169268 Мъжът е роден на 16.04.1875.

using System;
using System.Text;

namespace Excercise365
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Напишете вашето ЕГН: ");
            string? egn = Console.ReadLine();

            string year = egn.Substring(0, 2);
            string month = egn.Substring(2, 2);
            string day = egn.Substring(4, 2);

            Console.WriteLine($"Дата на раждане {day}.{month}.19{year} г.");

            string dayWithFix = "";
            char digit = day[1];
            dayWithFix = digit switch
            {
                '1' => day + "-ви",
                '2' => day + "-ри",
                '7' or '8' => day + "-ми",
                _ => day + "-ти",
            };

            string monthAsText = "";
            int monthAsInt = Convert.ToInt32(month);
            GetMonthAsText(out monthAsText, monthAsInt);

            Console.WriteLine($"Дата на раждане {dayWithFix} {monthAsText} 19{year} г.");

            string dayAsText = "";
            int dayAsInt = Convert.ToInt32(day);
            GetDayAsText(out dayAsText, dayAsInt);

            Console.WriteLine($"Дата на раждане {dayAsText} {monthAsText} 19{year} г.");

            Console.WriteLine($"Мъжът е роден {day}.{month}.19{year} г.");
        }

        private static void GetMonthAsText(out string monthAsText, int monthAsInt)
        {
            switch (monthAsInt)
            {
                case 1:
                    monthAsText = "Януари";
                    break;
                case 2:
                    monthAsText = "Февруари";
                    break;
                case 3:
                    monthAsText = "Март";
                    break;
                case 4:
                    monthAsText = "Април";
                    break;
                case 5:
                    monthAsText = "Май";
                    break;
                case 6:
                    monthAsText = "Юни";
                    break;
                case 7:
                    monthAsText = "Юли";
                    break;
                case 8:
                    monthAsText = "Август";
                    break;
                case 9:
                    monthAsText = "Септември";
                    break;
                case 10:
                    monthAsText = "Октомври";
                    break;
                case 11:
                    monthAsText = "Ноември";
                    break;
                case 12:
                    monthAsText = "Декември";
                    break;
                default:
                    monthAsText = "Няма такъв месец";
                    break;
            }
        }

        private static void GetDayAsText(out string dayAsText, int dayAsInt)
        {
            dayAsText = dayAsInt switch
            {
                1 => "първи",
                2 => "втори",
                3 => "трети",
                4 => "четвърти",
                5 => "пети",
                6 => "шести",
                7 => "седми",
                8 => "осми",
                9 => "девети",
                10 => "десети",
                11 => "единадесети",
                12 => "дванадесети",
                13 => "тринадесети",
                14 => "четиринадесети",
                15 => "петнадесети",
                16 => "шестнадесети",
                17 => "седемнадесети",
                18 => "осемнадесети",
                19 => "деветнадесети",
                20 => "двадесети",
                21 => "двадесет и първи",
                22 => "двадесет и втори",
                23 => "двадесет и трети",
                24 => "двадесет и четвърти",
                25 => "двадесет и пети",
                26 => "двадесет и шести",
                27 => "двадесет и седми",
                28 => "двадесет и осми",
                29 => "двадесет и девети",
                30 => "тридесети",
                31 => "тридесет и първи",
                _ => "Няма такъв ден",
            };
        }
    }
}