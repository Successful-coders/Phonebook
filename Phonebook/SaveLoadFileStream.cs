using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    class SaveLoadFileStream
    {
        private const string DEFAULT_FILE_PATH = ".\\callerList.txt";
        private const string COLUMN_SEPARATOR = "    ";


        private string path = DEFAULT_FILE_PATH;
        private FileStream fileStream;


        public SaveLoadFileStream()
        {

        }


        public void CreateFile(string path)
        {
            this.path = path;

            fileStream = File.Create(path);
        }
        public void SavePhonebookToFile(CallerList callerList)
        {
            var dialogResult = SaveFileDialog();
            if (dialogResult != DialogResult.OK)
                return;

            CreateFile(path);
            if (fileStream == null)
                return;

            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                for (int i = 0; i < callerList.Count; i++)
                {
                    Caller caller = callerList.GetAt(i);

                    streamWriter.WriteLine(caller.Record.Name + COLUMN_SEPARATOR + caller.Record.PhoneNumber);
                }
            }
        }
        public CallerList LoadPhonebookFromFile()
        {
            var dialogResult = OpenFileDialog();
            if (dialogResult != DialogResult.OK)
                return null;

            fileStream = File.OpenRead(path);

            var callerList = new CallerList();

            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] columns = line.Split(new string[] { COLUMN_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

                        if (columns.Length == 2)
                        {
                            callerList.Add(new Caller(new Record(columns[0], columns[1])));
                        }
                    }
                }
            }

            return callerList;
        }

        private DialogResult OpenFileDialog()
        {
            var openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    path = openFileDialog.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

            return dialogResult;
        }
        private DialogResult SaveFileDialog()
        {
            var saveFileDialog = new SaveFileDialog()
            {
                FileName = "callersList",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Save callers list"
            };

            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    path = saveFileDialog.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

            return dialogResult;
        }
    }
}
