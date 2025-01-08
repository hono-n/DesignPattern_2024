using System;

namespace AdapterPatternByInstance
{
    class BirthdayReminderAdapter : Reminder
    {
        private BirthdayReminder birthdayReminder;

        public BirthdayReminderAdapter(string name, string birthday){
            this.birthdayReminder = new BirthdayReminder(name, birthday) ;
        }

        public override bool TodayIsDueDate(string date)
        {
            return birthdayReminder.TodayIsBirthday(date);
        }
        public override void Remind()
        {
            string message = "【誕生日】" + birthdayReminder.Congraturate();
            Console.WriteLine(message);
        }

    }
}