using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show_do_milhao.Controller {
    class User {
        public static string Name { get; set; }
        static int Points = 0;

        public static void GetNameOfUser() {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Write("Digite seu Nome: ");
            Name = Console.ReadLine();
            Console.Clear();
        }

        public static void SetPoints(int point) {
            Points = point;
        }

        public static int GetPoints() {
            return Points;
        }
    }
}
