
using show_do_milhao.Controller;
using show_do_milhao.Model;
using show_do_milhao.Views;
using System.Net.NetworkInformation;


View.Init();
View.Rules();
User.GetNameOfUser();
Asking.Start();
while (HandleQuestions.Index < 15){
    HandleQuestions.HandleQuestion();
    HandleQuestions.IsRight = false;
    string reply = View.Response();
    
    if (!HandleQuestions.HandleReply(reply)){
        if (HandleQuestions.Quit){
            var point = HandleScore.Quit(HandleQuestions.Index);
            User.SetPoints(point);
            View.ToQuit(point);
        } else {
            var point = HandleScore.Wrong(HandleQuestions.Index);
            User.SetPoints(point);
            View.ToWrong(point);
        }
        break;
    }
    if (HandleQuestions.IsRight) {
        var point = HandleScore.Correct(HandleQuestions.Index);
        User.SetPoints(point);
        View.ToRight(point);
    }

}

View.Final(User.GetPoints());
