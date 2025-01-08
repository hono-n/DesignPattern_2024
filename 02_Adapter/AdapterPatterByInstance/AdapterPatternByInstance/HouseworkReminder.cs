using System;

namespace AdapterPatternByInstance
{
    class HouseworkReminder : Reminder
    {
        public HouseworkReminder(string target, string due){
            this.Target = target;
            this.Due = due;
        }
        public override bool TodayIsDueDate(string date){
            return date == Due;
        }
        public override void Remind(){
            Console.WriteLine($"【家事】{Target}");
        }
    }
}