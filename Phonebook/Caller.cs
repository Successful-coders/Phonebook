using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Caller
    {
        private Record record;


        public Caller(Record record)
        {
            this.record = record;
        }


        public bool IsLess(Record record)
        {
            return (this.record.Name.CompareTo(record.Name) < 0 && this.record.PhoneNumber < record.PhoneNumber);
        }
        public bool Equals(Record record)
        {
            return (this.record.Name == record.Name && this.record.PhoneNumber == record.PhoneNumber);
        }


        public Record Record { get => record; set => record = value; }
    }
}
