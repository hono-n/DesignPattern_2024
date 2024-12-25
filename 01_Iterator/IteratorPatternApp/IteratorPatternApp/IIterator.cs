using System;
namespace IteratorPatternApp
{

    public interface IIterator
    {
        public abstract bool HasNext();
        public abstract Object Next();
    }
}