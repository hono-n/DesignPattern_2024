using System;
namespace IteratorPatternApp
{
    public interface IIterator<T>
    {
        public abstract bool HasNext();
        public abstract T Next();
    }
}