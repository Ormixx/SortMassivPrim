using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArrayExample.AllTogether
{
    internal class SortedLongArray //Класс реализации поиска в упорядоченном массиве
    {
        private long[] _array;
        private int _count;

        public SortedLongArray(int size)
        {
            _array = new long[size];
            _count = 0;
        }

        public bool Contains(long searchValue)
        {
            int lowerBound = 0;
            int upperBound = _count - 1;

            while (lowerBound <= upperBound)
            {
                int currentIndex = (lowerBound + upperBound) / 2;
                if (_array[currentIndex] == searchValue)
                    return true;
                else if (_array[currentIndex] < searchValue)
                    lowerBound = currentIndex + 1;
                else
                    upperBound = currentIndex - 1;
            }
            return false;
        }

        public bool Insert(long value)
        {
            if (_count == _array.Length) return false;

            int i;
            for (i = 0; i < _count; i++)
            {
                if (_array[i] == value)
                    return false;
                else if (_array[i] > value)
                    break;
            }

            for (int j = _count; j > i; j--)
            {
                _array[j] = _array[j - 1];
            }
            _array[i] = value;
            _count++;
            return true;
        }

        public bool Delete(long value)
        {
            int index = Array.BinarySearch(_array, 0, _count, value);
            if (index < 0) return false;

            for (int j = index; j < _count - 1; j++)
            {
                _array[j] = _array[j + 1];
            }
            _count--;
            return true;
        }

        public long GetMin()
        {
            if (_count == 0) throw new InvalidOperationException("Array is empty");
            return _array[0];
        }

        public long GetMax()
        {
            if (_count == 0) throw new InvalidOperationException("Array is empty");
            return _array[_count - 1];
        }

        public long this[int index] => _array[index];
    }
}
