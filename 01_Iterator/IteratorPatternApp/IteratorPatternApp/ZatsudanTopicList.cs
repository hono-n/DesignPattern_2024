using System;
namespace IteratorPatternApp
{
    public class ZatusdanTopicList : IAggregate
    {
        private readonly ZatsudanTopic[] zatsudanTopics;
        private int last = 0;
        public ZatusdanTopicList(int maximize)
        {
            this.zatsudanTopics = new ZatsudanTopic[maximize];
        }
        public ZatsudanTopic GetZatsudanTopicAt(int index)
        {
            return zatsudanTopics[index];
        }
        public void AppendZatsudanTopic(ZatsudanTopic zatsudanTopic)
        {
            this.zatsudanTopics[last] = zatsudanTopic;
            last++;
        }
        public int GetLength()
        {
            return last;
        }
        public IIterator Iterator()
        {
            return new ZatusdanTopicListIterator(this);
        }
    }
}