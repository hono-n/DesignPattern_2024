using System;
using System.Collections.Concurrent;

namespace IteratorPatternApp
{
    public class ZatsudanTopic
    {
        public string Title { get; }
        public string Description { get; }

        private bool Consumed { get; set; }

        public ZatsudanTopic(string title, string description)
        {
            Title = title;
            Description = description;
            Consumed = false;
        }

        public void MarkAsConsumed()
        {
            Consumed = true;
        }

        public bool Available()
        {
            return !Consumed;
        }

        public override string ToString()
        {
            return $"・{this.Title}【{this.Description}】";
        }
    }
}