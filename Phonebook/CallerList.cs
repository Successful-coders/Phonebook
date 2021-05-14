using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class CallerList
    {
        private List<Caller> callers = new List<Caller>();


        public void Add(Caller caller)
        {
            callers.Add(caller);
        }
        public void Remove(Caller removedCaller)
        {
            int removedIndex = GetCallerIndex(removedCaller);

            RemoveAt(removedIndex);
        }
        public void RemoveAt(int removedIndex)
        {
            if (removedIndex > 0 && removedIndex < callers.Count)
            {
                callers.RemoveAt(removedIndex);
            }
        }
        public Caller ReadAt(int index)
        {
            return callers[index];
        }
        public int GetCallerIndex(Caller searchedCaller)
        {
            for (int i = 0; i < callers.Count; i++)
            {
                if (callers[i].Equals(searchedCaller))
                {
                    return i;
                }
            }

            return -1;
        }
        public void Clear()
        {
            callers.RemoveAll();
        }


        public int Count => callers.Count;
    }
}
