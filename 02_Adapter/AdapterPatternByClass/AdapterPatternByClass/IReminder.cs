using System;

namespace AdapterPatternByClass
{
    interface IReminder
    {
        // interfaceはすべてpublic
        string Target {get;}
        string Due { get;}
        bool TodayIsDueDate(string date);
        void Remind();
    }
}