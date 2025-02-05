using System;
using System.Diagnostics.Contracts;

namespace PrototypePatternApp
{
    namespace GreetFramework
    {
        class GreetingUtil
        {
            public static void GreetToAll(List<(IGreeting greet, Person person)> list)
            {
                foreach ((IGreeting greet, Person person) tuple in list)
                {
                    Console.WriteLine(tuple.greet.Greet(tuple.person));
                }
            }
        }
    }
}