using System;
using SingletonPatternApp.Config;

namespace SingletonPatternApp
{

    namespace App
    {
        public class LanguageManager
        {
            public static void SetLanguageConfig(string to)
            {
                LanguageConfig lc = LanguageConfig.GetInstance();
                if (to == "En")
                {
                    lc.SetToEn();
                    Console.WriteLine("System Language has been set to En");
                }
                else
                {
                    lc.SetToJa();
                    Console.WriteLine("システムの言語設定が日本語に変更されました");
                }
            }
        }
    }
}