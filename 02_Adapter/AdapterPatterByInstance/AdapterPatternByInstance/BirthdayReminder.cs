using System;

namespace AdapterPatternByInstance
{
    class BirthdayReminder
    {
        public string Name { get; set; }

        public String Birthday { get; set; }

        public BirthdayReminder(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public bool TodayIsBirthday(string date){
            return date == Birthday ;
        }

        public string Congraturate()
        {
            return $"今日{Birthday}日は{Name}の誕生日です！お祝いしましょう！";
        }
    }
}