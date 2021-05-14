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
            for (int i = 0; i < callers.Count; i++)
            {
                if (callers[i].Equals(removedCaller))
                {
                    callers.RemoveAt(i);

                    break;
                }
            }
        }
    }
}
