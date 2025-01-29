using System;
using SingletonPatternApp.Config;
using SingletonPatternApp.App;

namespace SingletonPatternApp
{

    public abstract class Program
    {
        public static void Main()
        {
            Console.WriteLine("利用言語を選択してください / Choose your preferred language");
            Console.WriteLine("1: 日本語 / Ja");
            Console.WriteLine("2: 英語 / En");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                LanguageManager.SetLanguageConfig("Ja");
            }
            else
            {
                LanguageManager.SetLanguageConfig("En");
            }

            CurrentTimeDisplayer.DisplayCurrentTime();
        }
    }
}