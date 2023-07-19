using show_do_milhao.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show_do_milhao.Controller {
    class HandleHelp : HandleQuestions{
        static int HelpAmount = 0;

        public static bool VerifyHelpAmount() {
            return HelpAmount < 3;
        }
        public static bool RemoveAnwser() {
            if (VerifyHelpAmount()){
                var keys = (new char[] { 'a', 'b', 'c', 'd' }).ToList();
                keys.Remove(char.Parse(GameQuestion[Index].Reply));
                int randomNum = new Random().Next(0,2);
                for (var i = randomNum; i >= 0; i--) {
                    keys.RemoveAt(i);
                }
                foreach (var item in keys){
                    GameQuestion[Index].Alternatives[item] = "";
                }
                HelpAmount++;
                return true;
            } else {
                return false;
            }
        }
        public static bool Cards() {
            if (VerifyHelpAmount()) {
                var alternatives = new string[] { "A", "B", "C", "D" };
                Random randomNum = new Random();
                Console.Clear();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("          " +
                      "_____\r\n         " +
                     $"|{GameQuestion[Index].Reply.ToUpper()} .  | _____" +
        $"\r\n         | /.\\ ||{alternatives[randomNum.Next(0, 3)]} ^  | _____\r\n" +
            $"         |(_._)|| / \\ ||{GameQuestion[Index].Reply.ToUpper()} _  | _____\r\n         " +
                     $"|  |  || \\ / || ( ) ||{alternatives[randomNum.Next(0, 3)]}_ _ |\r\n         " +
                     "|____♠||  .  ||(_'_)||( v )|\r\n                " +
                            "|____♦||  |  || \\ / |\r\n                       " +
                                   "|____♣||  .  |\r\n                              " +
                                          "|____♥|");
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("\n\n Aperte ENTER para continuar >>");
                Console.ReadKey();
                HelpAmount++;
                return true;
            } else {
                return false;
            }
        }
        public static bool University() {
            if (VerifyHelpAmount()) {
                var alternatives = new string[] { "A", "B", "C", "D"};
                Random randomNum = new Random();
                Console.Clear();
                Console.WriteLine("                     _____________________________________________\r\n" +
                    "                    |  _________________________________________  |\r\n" +
                    "                    | |26.1.00                                  | |\r\n" +
                    "           Z        | |                                         | |\r\n" +
                   $"          z         | |   ({GameQuestion[Index].Reply.ToUpper()})              ({GameQuestion[Index].Reply.ToUpper()})             ({alternatives[randomNum.Next(0, 3)]})  | |\r\n" +
                    "           z   .-------------------------------------.          | |\r\n" +
                    "         Z    | e talvez... talvez a resposta seja... |         | |\r\n" +
                    "          z   |   ... seja ...  sejz... zZzZzZzZ      |         | |\r\n" +
                    "               '-,-----------------------------------'          | |\r\n" +
                    "       ___     _/   | |                                         | |\r\n" +
                    "     .� __)         | |_________________________________________| |\r\n" +
                    "    ( /_ _(\\        |_____________________________________________|\r\n" +
                    "   ( _|  > ))\r\n" +
                    "  ( ( (---'-.\r\n" +
                    "  (_ `)\\-``  )\r\n" +
                    "    `/-/   ) \\\r\n" +
                    "----(__.�--------------.\r\n" +
                    "\\                       \\\r\n" +
                    "\\\\_______________________\\\r\n" +
                    "|,------------------------'\r\n ");

                Console.WriteLine("\n\n Aperte ENTER para continuar >>");
                Console.ReadKey();
                HelpAmount++;
                return true;
            } else {
                return false;
            }
        }
        public static string Quit() {
            return "quit";
        }
    }
}
