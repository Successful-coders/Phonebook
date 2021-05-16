using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Control
    {
        private CallerList callerList = new CallerList();
        private SaveLoadFileStream fileStream = new SaveLoadFileStream();


        public Control()
        {

        }


        public Record GetRecordAt(int i)
        {
            return callerList.GetAt(i).Record;
        }
        public string GetRecordNameAt(int i)
        {
            return callerList.GetAt(i).Record.Name;
        }
        public string GetRecordPhoneNumberAt(int i)
        {
            return callerList.GetAt(i).Record.PhoneNumber;
        }
        public void AddRecord(Record newRecord)
        {
            callerList.Add(new Caller(newRecord));
        }
        public void RemoveRecord(Record removedRecord)
        {
            callerList.Remove(new Caller(removedRecord));
        }
        public void RemoveRecordAt(int index)
        {
            callerList.RemoveAt(index);
        }
        public void Clear()
        {
            callerList.Clear();
        }
        public int GetRecordIndex(string name, string phoneNumber)
        {
            return callerList.GetCallerIndex(new Caller(new Record(name, phoneNumber)));
        }
        public void CreateFile(string path)
        {
            fileStream.CreateFile(path);
        }
        public void SavePhonebookToFile()
        {
            fileStream.SavePhonebookToFile(callerList);
        }
        public void LoadPhonebookFromFile()
        {
            var loadedCallerList = fileStream.LoadPhonebookFromFile();
            if (loadedCallerList != null)
            {
                callerList = loadedCallerList;
            }
        }


        public CallerList CallerList => callerList;
        public int RecordsCount => callerList.Count;
    }
}
