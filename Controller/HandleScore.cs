using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show_do_milhao.Controller {
    internal class HandleScore {
        static int Points = 1000;
        public static int Correct(int index) {
            if (index < 5) {
                Points += 1_000;
            } else if (index == 5) {
                Points += 5_000;
            } else if(index < 10) {
                Points += 10_000;
            } else if (index == 10) {
                Points += 50_000;
            } else if (index < 13) {
                Points += 100_000;
            } else {
                Points = 1_000_000;
            }
            return Points;
        }
        public static int Quit(int index) {
            if (index == 1) {
                Points = 0;
            } else {
                Points /= 2;
            } 
            return Points;
        }

        public static int Wrong(int index) {
            if (index == 1) {
                Points = 0;
            } else {
                Points /= 4;
            }
            return Points;
        }

        public static int IfCorrect(int index) {
            if (index < 5) {
                return Points + 1_000;
            } else if (index == 5) {
                return Points + 5_000;
            } else if (index < 10) {
                return Points + 10_000;
            } else if (index == 10) {
                return Points + 50_000;
            } else if (index < 13) {
                return Points + 100_000;
            } else {
                return 1_000_000;
            }
        }
        public static int IfQuit(int index) {
            if (index == 0) {
                return 0;
            } 
            return Points / 2;
        }

        public static int IfWrong(int index) {
            if (index == 0) {
                return 0;
            }
            return Points / 4;
        }
    }
}
