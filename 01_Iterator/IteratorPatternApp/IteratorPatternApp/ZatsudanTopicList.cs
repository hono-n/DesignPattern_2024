using System;
using System.Collections.Generic;

namespace IteratorPatternApp
{
    public class ZatsudanTopicList : IAggregate<ZatsudanTopic>
    {
        private readonly List<ZatsudanTopic> ZatsudanTopics;

        public ZatsudanTopicList()
        {
            ZatsudanTopics = [];
        }
        public ZatsudanTopic GetZatsudanTopicAt(int index)
        {
            return ZatsudanTopics[index];
        }
        public void AppendZatsudanTopic(ZatsudanTopic zatsudanTopic)
        {
            ZatsudanTopics.Add(zatsudanTopic);

        }
        public int GetLength()
        {
            return ZatsudanTopics.Count;
        }
        // 戻り値がZatsudanToppicListIterator型ではなく、IIterator型（インターフェース）になっているのがミソ
        public IIterator<ZatsudanTopic> Iterator()
        {
            return new ZatsudanTopicListIterator(this);
        }

        public IIterator<ZatsudanTopic> AvailableIterator(){
            return new AvailableZatsudanTopicListIterator(this);
        }
    }
}