using System;
using PrototypePatternApp.GreetFramework;

namespace PrototypePatternApp
{
    // カジュアルな挨拶をするクラス
    public class CasualGreeting : IGreeting
    {

        public string Greet(Person To)
        {
            if (To.Gender == "女性")
            {
                return $"{To.FirstName}ちゃん、おはよう！";
            }
            else
            {
                return $"{To.FirstName}くん、おはよう！";
            }
        }

        public IGreeting CreateClone()
        {
            IGreeting g = null;
            try
            {
                g = (IGreeting)MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return g;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    // フォーマルな挨拶をするクラス
    public class FormalGreeting : IGreeting
    {

        public string Greet(Person To)
        {
            return $"{To.FamilyName}さん、おはようございます。";
        }

        public IGreeting CreateClone()
        {
            IGreeting g = null;
            try
            {
                g = (IGreeting)Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return g;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}