using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;



namespace show_do_milhao.Model {

     class AskingModel {
        public  string Ask { set; get; }
        public  Dictionary<char, string> Alternatives { set; get; }
        public  string Reply { set; get; }
    }
    class Asking {
        public static AskingModel[] AllQuestions { set; get; }
        public static AskingModel[] GameQuestions { set; get; }
        public Asking(){ }
        public static void GetQuestions() {
            using (StreamReader r = new StreamReader("../../../Model/perguntas.json")) {
                var json = r.ReadToEnd();
                AllQuestions = JsonConvert.DeserializeObject<AskingModel[]>(json);
            }
        }
        public static void RandomizerQuestions() {
            var Sets = new HashSet<int>();
            AskingModel[] arrayQuest = new AskingModel[15];
            while (Sets.Count < 15) {
                Sets.Add(new Random().Next(0, 15));
            }
            var index = 0;
            foreach (var i in Sets) {
                arrayQuest[index] = AllQuestions[i];
                index++;
            }
            GameQuestions = arrayQuest;
        }

        public static void Start() {
            GetQuestions();
            RandomizerQuestions();
            
        }
    }
}