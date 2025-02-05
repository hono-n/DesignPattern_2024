using System;

namespace PrototypePatternApp
{
    namespace GreetFramework
    {
        public interface IGreeting : ICloneable
        {
            public abstract string Greet(Person To);

            public abstract IGreeting CreateClone();
        }

        class GreetingManager
        {
            private Dictionary<string, IGreeting> _showcase = [];
            public void Register(string name, IGreeting greeting)
            {
                _showcase.Add(name, greeting);
            }
            public IGreeting Create(string name)
            {
                IGreeting g = (IGreeting)_showcase[name];
                return g.CreateClone();
            }
        }

        public class Person
        {
            public string FamilyName { get; set; }
            public string FirstName { get; set; }
            public string Gender { get; set; }

            public Person(string familyName, string firstName, string gender)
            {
                this.FamilyName = familyName;
                this.FirstName = firstName;
                this.Gender = gender;
            }
        }
    }

}