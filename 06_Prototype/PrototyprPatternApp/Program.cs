using System;
using PrototypePatternApp.GreetFramework;

namespace PrototypePatternApp
{

    public abstract class Program
    {
        public static void Main()
        {
            GreetingManager manager = new GreetingManager();

            CasualGreeting cg = new CasualGreeting();
            FormalGreeting fg_san = new FormalGreeting("さん");
            FormalGreeting fg_kun = new FormalGreeting("君");
            manager.Register("casual", cg);
            manager.Register("formal_san", fg_san);
            manager.Register("formal_kun", fg_kun);

            Person p1 = new Person("鈴木", "恵子", "女性");
            Person p2 = new Person("菊池", "健吾", "男性");

            IGreeting casual = manager.Create("casual");
            IGreeting formal_san = manager.Create("formal_san");
            IGreeting formal_kun = manager.Create("formal_kun");

            List<(IGreeting greet, Person person)> list = new List<(IGreeting greet, Person person)>(){
                (casual, p1),
                (casual, p2),
                (formal_san, p1),
                (formal_san, p2),
                (formal_kun, p1),
                (formal_kun, p2)
            };
            GreetingUtil.GreetToAll(list);
        }
    }
}