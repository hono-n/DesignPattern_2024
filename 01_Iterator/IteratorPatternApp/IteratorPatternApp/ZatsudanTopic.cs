using System;

namespace IteratorPatternApp
{
    public class ZatsudanTopic
    {
        public string Title { get;}
        public string Description {get;}

        public ZatsudanTopic(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Introduce(){
            return $"・{this.Title}【{this.Description}】";
        }
    }
}