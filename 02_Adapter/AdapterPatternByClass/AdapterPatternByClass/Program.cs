// See https://aka.ms/new-console-template for more information
using System;
using System.Data;

namespace AdapterPatternByClass
{

    public class Program
    {
        public static void Main()
        {
            List<IReminder> reminderList = new List<IReminder>();

            reminderList.Add(new HouseWorkReminder("駐車場代の振込", "1/8"));
            reminderList.Add(new HouseWorkReminder("生協の受け取り（14:00-16:00）", "1/8"));
            reminderList.Add(new HouseWorkReminder("夫出張のため弁当不要", "1/9"));

            reminderList.Add(new BirthdayReminderAdapter("お義母さん", "1/8"));
            reminderList.Add(new BirthdayReminderAdapter("お義父さん", "10/12"));
            foreach (IReminder reminder in reminderList){
                string today = "1/8";
                if (reminder.TodayIsDueDate(today)){
                    reminder.Remind();
                }
            }
        }
    }
}
