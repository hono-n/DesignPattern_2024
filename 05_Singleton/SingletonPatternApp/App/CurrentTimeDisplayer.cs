using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using SingletonPatternApp.Config;

namespace SingletonPatternApp
{

    namespace App
    {
        public class CurrentTimeDisplayer
        {
            public static void DisplayCurrentTime(){
                LanguageConfig lc = LanguageConfig.GetInstance();
                if (lc.CurrentLanguage == "En")
                {
                    Console.WriteLine($"Current Time is {DateTime.Now}");
                }
                else
                {
                    lc.SetToJa();
                    Console.WriteLine($"現在時刻は{DateTime.Now}です");
                }
            }
        }
    }
}