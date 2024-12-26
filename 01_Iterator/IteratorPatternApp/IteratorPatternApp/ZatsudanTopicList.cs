using System;
using System.Collections.Generic;

namespace IteratorPatternApp
{
    public class ZatsudanTopicList : IAggregate
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
        public IIterator Iterator()
        {
            return new ZatsudanTopicListIterator(this);
        }

        public IIterator AvailableIterator(){
            return new AvailableZatsudanTopicListIterator(this);
        }
    }
}