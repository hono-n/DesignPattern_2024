using System;

namespace IteratorPatternApp
{
    public class ZatusdanTopicListIterator : IIterator
    {
        private readonly ZatusdanTopicList zatusdanTopicList;
        private int index;
        public ZatusdanTopicListIterator(ZatusdanTopicList zatusdanTopicList)
        {
            this.zatusdanTopicList = zatusdanTopicList;
            this.index = 0;
        }
        public bool HasNext()
        {
            if (index < zatusdanTopicList.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object Next()
        {
            ZatsudanTopic zatusdanTopic = zatusdanTopicList.GetZatsudanTopicAt(index);
            index++;
            return zatusdanTopic;
        }
    }
}