using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Record
    {
        private string name;
        private string phoneNumber;


        public Record(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }


        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber;  set => phoneNumber = value; }
    }
}
