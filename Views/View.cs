using show_do_milhao.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show_do_milhao.Views {
    class View {
        public static void Ask(string ask, int index) {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine(new String('-', ask.Length + 10));
            Console.WriteLine($"({index + 1}) - {ask}");
            Console.WriteLine(new String('-', ask.Length + 10));
        }
        public static void Replies(Dictionary<char, string> alternatives) {
            Console.WriteLine("\n");
            foreach (var key in alternatives.Keys) {
                Console.WriteLine($"{key.ToString().ToUpper()} - {alternatives[key]}");
            }
        }

        public static void Help(bool card, bool university, bool remove) {
            Console.WriteLine("\n");
            Console.WriteLine("||||||||| AJUDAS |||||||||");
            Console.WriteLine($"||{(card ? "(1) - Cartas" : "            ")}          |||");
            Console.WriteLine($"||{(university ? "(2) - Universitarios" : "                    ")}  |||");
            Console.WriteLine($"||{(remove ? "(3) - Remover" : "             ")}         |||");
            Console.WriteLine("---------------------------");
            Console.WriteLine("\n(4) - Desistir \n\n");
        }

        public static void Points(int index) {
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine($"    A C E R T O             >   R$ {HandleScore.IfCorrect(index)}");
            Console.WriteLine($"    E R R O                 >   R$ {HandleScore.IfWrong(index)}");
            Console.WriteLine($"    D E S I S T Ê N C I A   >   R$ {HandleScore.IfQuit(index)}");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n\n");
        }
        public static string Response() {
            Console.Write(" >> ");
            string reply = Console.ReadLine().ToLower();
            while (reply != "a" && reply != "b" && reply != "c" && reply != "d" && reply != "1" && reply != "2" && reply != "3" && reply != "4") {
                Console.Write("Resposta Inválida, Digite Novamente >> ");
                reply = Console.ReadLine().ToLower();
            }
            return reply;
        }

        public static void Init(){
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("|   BEM VINDO AO SHOW DO MILHÃO   |\n\n");
            Console.WriteLine("\nAperte ENTER para INICIAR");
            Console.ReadKey();
        }

        public static void Rules() {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine(" ________________________________________________________________________________________\n");
            Console.WriteLine("|REGRAS:                                                                                 |\n");
            Console.WriteLine("|Universitários - A Professora pode revelar quais as alternativas que se aproximam da    |\n");
            Console.WriteLine("|resposta certa e cabe ao participante confiar ou não.                                   |\n");
            Console.WriteLine("|                                                                                        |\n");
            Console.WriteLine("|Remoção - 1 a 3 alternativas serão removidas.                                           |\n");
            Console.WriteLine("|                                                                                        |\n");
            Console.WriteLine("|Cartas - Quatro cartas de baralho são viradas onde é revelada um possivel gabarito      |\n");
            Console.WriteLine("|                                                                                        |\n");
            Console.WriteLine("|Pulos - O participante pode passar a pergunta caso não saiba a resposta. Este recurso   |\n");
            Console.WriteLine("|pode ser utilizado apenas uma vez.                                                      |\n");
            Console.WriteLine("|________________________________________________________________________________________|\n");
            Console.WriteLine("\nAperte ENTER para continuar >>");
            Console.ReadKey();
        }

        public static void ToRight(int point) {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("           A C E R T O U  !!!   \n");
            Console.WriteLine($"      VOCE RECEBEU R$ {point}\n");
            Console.WriteLine("\nAperte ENTER para continuar >>");
            Console.ReadKey();
        }
        public static void ToWrong(int point) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("               E R R O U  !!!   \n");
            Console.WriteLine($"      VOCE RECEBERÁ APENAS R$ {point}\n");
            Console.WriteLine("\nAperte ENTER para finalizar >>");
            Console.ReadKey();
        }

        public static void ToQuit(int point) {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("             D E S I S T I U  !!!   \n");
            Console.WriteLine($"      VOCE RECEBERÁ APENAS R$ {point}\n");
            Console.WriteLine("\nAperte ENTER para finalizar >>");
            Console.ReadKey();
        }

        public static void Final(int point) {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!   \n");
            Console.WriteLine("   J O G O   F I N A L I Z A D O    \n");
            Console.WriteLine($"      VOCE RECEBEU R$ {point}\n");
            Console.WriteLine("\nAperte ENTER para finalizar >>");
            Console.ReadKey();
        }
    }
}
