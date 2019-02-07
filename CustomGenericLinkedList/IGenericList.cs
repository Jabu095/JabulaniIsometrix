using System;
using System.Collections.Generic;
using System.Text;

namespace CustomGenericLinkedList
{
    public interface IGenericList<T>
    {
        void Add(T value);
        void AddByPositon(T value, int position);
        void DeleteByPosition(int position);
        string DisplayNode();
        T GetByPosition(int position);
    }
}
