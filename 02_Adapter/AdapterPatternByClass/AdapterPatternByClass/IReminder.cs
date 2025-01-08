using System;

namespace AdapterPatternByClass
{
    interface IReminder
    {
        public string Target {get; set;}
        public string Due { get; set;}
        public bool TodayIsDueDate(string date);
        public void Remind();
    }
}