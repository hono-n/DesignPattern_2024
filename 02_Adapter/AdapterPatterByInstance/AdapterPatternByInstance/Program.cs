// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace AdapterPatternByInstance
{

    public class Program
    {
        public static void Main()
        {
            List<Reminder> reminderList = new List<Reminder>();
            reminderList.Add(new HouseworkReminder("駐車場代の振込", "1/8"));
            reminderList.Add(new HouseworkReminder("生協の受け取り（14:00-16:00）", "1/8"));
            reminderList.Add(new HouseworkReminder("夫出張のため弁当不要", "1/9"));
            reminderList.Add(new BirthdayReminderAdapter("お義母さん", "1/8"));
            reminderList.Add(new BirthdayReminderAdapter("お義父さん", "10/12"));
            foreach (Reminder reminder in reminderList){
                string today = "1/8";
                if (reminder.TodayIsDueDate(today)){
                    reminder.Remind();
                }
            }
        }
    }
}