using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArrayExample.AllTogether
{
    internal class SortedArray : IArrayOperations //Класс реализации интерфейса
    {
        private SortedLongArray _sortedArray;
        private int _count;

        public SortedArray(int size)
        {
            _sortedArray = new SortedLongArray(size);
            _count = 0;
        }

        public bool Contains(long value) => _sortedArray.Contains(value);

        public void Add(long value)
        {
            if (_sortedArray.Insert(value))
            {
                _count++;
            }
        }

        public bool Delete(long value)
        {
            bool delete = _sortedArray.Delete(value);
            if (delete) _count--;
            return delete;
        }

        public void Display()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_sortedArray[i] + " ");
            }
            Console.WriteLine();
        }

        public int GetSize() => _count;

        public long GetMin() => _sortedArray.GetMin();

        public long GetMax() => _sortedArray.GetMax();
    }

}
