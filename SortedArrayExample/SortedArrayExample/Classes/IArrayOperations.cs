using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArrayExample.AllTogether
{ 
        public interface IArrayOperations
        {
            bool Contains(long searchValue);
            void Add(long value);
            bool Delete(long value);
            void Display();
            int GetSize();
            long GetMin();
            long GetMax();
        }
}
