using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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
                 DateTime dt = DateTime.Now;
                if (lc.CurrentLanguage == "En")
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Console.WriteLine($"Current Time is【{dt.ToString("f", culture)}】");
                }
                else
                {
                    CultureInfo culture = new CultureInfo("ja-JP");
                    Console.WriteLine($"現在時刻は【{dt.ToString("f", culture)}】です");
                }
            }
        }
    }
}