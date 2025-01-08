using System;

namespace AdapterPatternByClass
{
    class BirthdayReminderAdapter : BirthdayReminder, IReminder
    {
        public string Target
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public string Due
        {
            get { return this.Birthday; }
            set { this.Birthday = value; }
        }

        public BirthdayReminderAdapter(string target, string date): base(target, date){}
        public bool TodayIsDueDate(string date)
        {
            return TodayIsBirthday(date);
        }
        public void Remind()
        {
            string message = "【誕生日】" + Congraturate();
            Console.WriteLine(message);
        }

    }
}