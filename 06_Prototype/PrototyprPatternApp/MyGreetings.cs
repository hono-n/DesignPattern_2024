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

    // フォーマルな挨拶をするクラス
    public class FormalGreeting : IGreeting
    {
        // 　get のみにすることで、不変オブジェクトにできる
        private string TitleOfHonor { get; }

        public FormalGreeting(string titleOfHonor){
            this.TitleOfHonor = titleOfHonor;
        }

        public string Greet(Person To)
        {
            return $"{To.FamilyName}{TitleOfHonor}、おはようございます。";
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