using System;

namespace IteratorPatternApp
{

    public interface IAggregate<T>
    {
        public abstract IIterator<T> Iterator();
    }
}