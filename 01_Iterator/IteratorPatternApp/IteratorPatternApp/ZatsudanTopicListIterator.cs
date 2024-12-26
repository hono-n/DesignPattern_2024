using System;

namespace IteratorPatternApp
{
    public class ZatsudanTopicListIterator : IIterator<ZatsudanTopic>
    {
        private readonly ZatsudanTopicList ZatsudanTopicList;
        private int index;
        public ZatsudanTopicListIterator(ZatsudanTopicList ZatsudanTopicList)
        {
            this.ZatsudanTopicList = ZatsudanTopicList;
            this.index = 0;
        }
        public bool HasNext()
        {
            if (index < ZatsudanTopicList.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ZatsudanTopic Next()
        {
            ZatsudanTopic zt = ZatsudanTopicList.GetZatsudanTopicAt(index);
            index++;
            return zt;
        }
    }
}