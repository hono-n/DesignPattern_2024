using System;

namespace AdapterPatternByInstance
{
    public abstract class Reminder
    {
        public string? Target {get; set;}
        public string? Due { get; set;}
        abstract public bool TodayIsDueDate(string date);
        abstract public void Remind();
    }
}