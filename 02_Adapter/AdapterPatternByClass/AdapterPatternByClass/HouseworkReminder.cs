using System;

namespace AdapterPatternByClass
{
    class HouseWorkReminder : IReminder
    {
        public string Target {get; set;}
        public string Due { get; set;}

        public HouseWorkReminder(string target, string date){
            this.Target = target;
            this.Due = date;
        }
        public bool TodayIsDueDate(string date){
            return date == Due;
        }
        public void Remind(){
            Console.WriteLine($"【家事】{Target}");
        }
    }
}