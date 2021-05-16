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
        private const string DEFAULT_FILE_PATH = ".\\callerList.txt";
        private const string COLUMN_SEPARATOR = "    ";


        private CallerList callerList = new CallerList();
        private FileStream fileStream;


        public Control()
        {
            if (File.Exists(DEFAULT_FILE_PATH))
            {
                fileStream = File.Open(DEFAULT_FILE_PATH, FileMode.Open);
            }
            else
            {
                CreateFile(DEFAULT_FILE_PATH);
            }
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
            fileStream = File.Create(path);
        }
        public void SavePhonebookToFile()
        {
            CreateFile(DEFAULT_FILE_PATH);

            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                for (int i = 0; i < callerList.Count; i++)
                {
                    Caller caller = callerList.GetAt(i);

                    streamWriter.WriteLine(caller.Record.Name + COLUMN_SEPARATOR + caller.Record.PhoneNumber);
                }
            }
        }
        public void LoadPhonebookFromFile()
        {
            callerList.Clear();

            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                string line = streamReader.ReadLine();
                string[] columns = line.Split(new string[] { COLUMN_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

                callerList.Add(new Caller(new Record(columns[0], columns[1])));
            }
        }


        public int RecordsCount => callerList.Count;
    }
}
