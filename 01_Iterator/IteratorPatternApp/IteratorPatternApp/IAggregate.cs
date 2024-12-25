using System;

namespace IteratorPatternApp
{

    public interface IAggregate
    {
        public abstract IIterator Iterator();
    }
}