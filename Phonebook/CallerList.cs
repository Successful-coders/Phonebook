using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class CallerList
    {
        private const int WRONG_CALLER_INDEX = -1;


        private List<Caller> callers = new List<Caller>();


        public void Add(Caller caller)
        {
            int insertIndex = 0;
            while (insertIndex < callers.Count && callers[insertIndex].IsLess(caller.Record))
            {
                insertIndex++;
            }

            callers.Insert(insertIndex, caller);
        }
        public void Remove(Caller removedCaller)
        {
            int removedIndex = GetCallerIndex(removedCaller);

            RemoveAt(removedIndex);
        }
        public void RemoveAt(int removedIndex)
        {
            if (removedIndex >= 0 && removedIndex < callers.Count)
            {
                callers.RemoveAt(removedIndex);
            }
        }
        public Caller GetAt(int index)
        {
            return callers[index];
        }
        public int GetCallerIndex(Caller searchedCaller)
        {
            for (int i = 0; i < callers.Count; i++)
            {
                if (callers[i].Equals(searchedCaller.Record))
                {
                    return i;
                }
            }

            return WRONG_CALLER_INDEX;
        }
        public void Clear()
        {
            callers = new List<Caller>();
        }
        public bool Contains(Caller caller)
        {
            return GetCallerIndex(caller) != WRONG_CALLER_INDEX;
        }


        public int Count => callers.Count;
    }
}
