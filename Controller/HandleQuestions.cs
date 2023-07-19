using show_do_milhao.Model;
using show_do_milhao.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show_do_milhao.Controller {
    class HandleQuestions {
        protected static AskingModel[] GameQuestion = Asking.GameQuestions;
        public static int Index = 0;
        static bool HelpRemove = true;
        static bool HelpCard = true;
        static bool HelpUniversity = true;
        public static bool Quit = false;
        public static bool IsRight = false;
        public static bool HandleReply(string reply) {
            if (GameQuestion[Index].Reply == reply) {
                Index++;
                IsRight = true;
                return true;
            } else if (reply == "1" ) {
                HandleHelp.Cards();
                HelpCard = false;
                return true;
            } else if (reply == "2") {
                HandleHelp.University();
                HelpUniversity = false;
                return true;
            } else if (reply == "3") {
                HandleHelp.RemoveAnwser();
                HelpRemove = false;
                return true;
            } else if (reply == "4") {
                Quit = true;
            }
            return false;
        }

        public static void HandleQuestion() {
            View.Ask(GameQuestion[Index].Ask, Index);
            View.Replies(GameQuestion[Index].Alternatives);
            View.Help(HelpCard, HelpUniversity, HelpRemove);
            View.Points(Index);
        }
    }
}
