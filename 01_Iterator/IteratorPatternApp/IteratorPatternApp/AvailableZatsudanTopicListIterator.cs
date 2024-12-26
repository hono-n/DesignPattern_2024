using System;

namespace IteratorPatternApp
{
    public class AvailableZatsudanTopicListIterator : IIterator
    {
        private readonly ZatsudanTopicList ZatsudanTopicList;
        private int index;
        public AvailableZatsudanTopicListIterator(ZatsudanTopicList ZatsudanTopicList)
        {
            this.ZatsudanTopicList = ZatsudanTopicList;
            this.index = 0;
        }
        public bool HasNext()
        {
            int _index = index;
            bool result = false;
            while (_index < ZatsudanTopicList.GetLength())
            {
                ZatsudanTopic zt = ZatsudanTopicList.GetZatsudanTopicAt(_index);
                if (zt.Available())
                {
                    result = true;
                    break;
                }
                _index++;
            }
            return result;
        }
        public object Next()
        {
            ZatsudanTopic zt = ZatsudanTopicList.GetZatsudanTopicAt(index);
            while (index < ZatsudanTopicList.GetLength())
            {
                if (zt.Available())
                {
                    break;
                }
                index++;
                zt = ZatsudanTopicList.GetZatsudanTopicAt(index);
            }
            index++;
            return zt;
        }
    }
}