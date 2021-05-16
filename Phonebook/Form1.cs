using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        private Control control = new Control();


        public Form1()
        {
            InitializeComponent();
        }


        private void UpdateList()
        {
            callersListView.Items.Clear();

            for (int i = 0; i < control.RecordsCount; i++)
            {
                callersListView.Items.Add(new ListViewItem(new string[] { control.GetRecordNameAt(i), control.GetRecordPhoneNumberAt(i)}));
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            control.LoadPhonebookFromFile();

            UpdateList();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            control.SavePhonebookToFile();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            control.Clear();

            UpdateList();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedIndices = callersListView.SelectedIndices;

            if (selectedIndices.Count == 1)
            {
                control.RemoveRecordAt(selectedIndices[0]);
            }

            UpdateList();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            var selectedIndices = callersListView.SelectedIndices;

            if (selectedIndices.Count == 1)
            {
                Record record = control.GetRecordAt(selectedIndices[0]);

                nameTextBox.Text = record.Name;
                phoneTextBox.Text = record.PhoneNumber;

                applyChangesButton.Visible = true;
            }
        }

        private void addCallerButton_Click(object sender, EventArgs e)
        {
            Record newRecord = new Record(nameTextBox.Text, phoneTextBox.Text);

            if (control.CallerList.Contains(new Caller(newRecord)))
            {
                MessageBox.Show("Данный абонент уже занесен в книгу!");
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Имя или телефон не могут быть пустыми!");
            }
            else
            {
                control.AddRecord(newRecord);

                nameTextBox.Text = "";
                phoneTextBox.Text = "";
            }

            UpdateList();
        }
        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            deleteButton_Click(sender, e);
            addCallerButton_Click(sender, e);

            applyChangesButton.Visible = false;
        }

        private void aboutToolButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var saveChangesDialogResult = MessageBox.Show("Сохранить изменения перед завершением?", "Завершение", MessageBoxButtons.YesNo);

            if (saveChangesDialogResult == DialogResult.Yes)
            {
                control.SavePhonebookToFile();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                UpdateList();

                return;
            }

            callersListView.Items.Clear();

            string searchText = searchTextBox.Text.ToLower();
            for (int i = 0; i < control.CallerList.Count; i++)
            {
                if (control.GetRecordNameAt(i).ToLower().StartsWith(searchText) 
                    || control.GetRecordPhoneNumberAt(i).ToLower().StartsWith(searchText))
                {
                    callersListView.Items.Add(new ListViewItem(new string[] { control.GetRecordNameAt(i), control.GetRecordPhoneNumberAt(i)}));
                }
            }
        }
    }
}
