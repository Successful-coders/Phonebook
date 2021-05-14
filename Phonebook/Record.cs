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
        private int phoneNumber;


        public string Name { get => name; set => name = value; }
        public int PhoneNumber { get => phoneNumber;  set => phoneNumber = value; }
    }
}
