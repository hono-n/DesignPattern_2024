using System;
using System.Collections.Generic;

namespace IteratorPatternApp
{
    public class ZatusdanTopicList : IAggregate
    {
        private readonly List<ZatsudanTopic> ZatsudanTopics;

        public ZatusdanTopicList()
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
        // 戻り値がZatusdanToppicListIterator型ではなく、IIterator型（インターフェース）になっているのがミソ
        public IIterator Iterator()
        {
            return new ZatusdanTopicListIterator(this);
        }
    }
}