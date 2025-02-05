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
            FormalGreeting fg = new FormalGreeting();
            manager.Register("casual", cg);
            manager.Register("formal", fg);

            Person p1 = new Person("鈴木", "恵子", "女性");
            Person p2 = new Person("菊池", "健吾", "男性");

            IGreeting casual = manager.Create("casual");
            IGreeting formal = manager.Create("formal");

            List<(IGreeting greet, Person person)> list = new List<(IGreeting greet, Person person)>(){
                (casual, p1),
                (casual, p2),
                (formal, p1),
                (formal, p2)
            };
            GreetingUtil.GreetToAll(list);
        }
    }
}