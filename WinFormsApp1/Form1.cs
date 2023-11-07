using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
            LoadTasks();
            RefreshList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Date = DateTime.Now;
            task.DueDate = dueDateTimePicker.Value;
            task.Description = descriptionTextBox.Text;
            tasks.Add(task);
            SaveTasks();
            RefreshList();
            ClearForm();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedItem != null)
            {
                int index = tasksListBox.SelectedIndex;
                Task task = tasks[index];
                task.DueDate = dueDateTimePicker.Value;
                task.Description = descriptionTextBox.Text;
                tasks[index] = task;
                SaveTasks();
                RefreshList();
                ClearForm();
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedItem != null)
            {
                int index = tasksListBox.SelectedIndex;
                tasks.RemoveAt(index);
                SaveTasks();
                RefreshList();
            }
        }

        private void tasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedItem != null)
            {
                int index = tasksListBox.SelectedIndex;
                Task task = tasks[index];
                inputDateTextBox.Text = task.Date.Date.ToString("yyyy-MM-dd");
                dueDateTextBox.Text = task.DueDate.Date.ToString("yyyy-MM-dd");
                taskContentTextBox.Text = task.Description;
            }
        }

        private void SaveTasks()
        {
            string fileName = "tasks.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));
            using (FileStream stream = File.Create(fileName))
            {
                serializer.Serialize(stream, tasks);
            }
        }


        private void RefreshList()
        {
            tasksListBox.DataSource = null;
            tasksListBox.DataSource = tasks.OrderBy(t => t.DueDate).ToList();
            tasksListBox.DisplayMember = "DescriptionAndDueDate";
        }

        private void ClearForm()
        {
            dueDateTimePicker.Value = DateTime.Now;
            descriptionTextBox.Text = "";
        }

        private void LoadTasks()
        {
            string fileName = "tasks.xml";
            if (File.Exists(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));
                using (FileStream stream = File.OpenRead(fileName))
                {
                    tasks = (List<Task>)serializer.Deserialize(stream);
                }
            }
        }

        private void openSaveFolderButton_Click(object sender, EventArgs e)
        {
            string saveFilePath = Path.Combine(Environment.CurrentDirectory, "tasks.xml");
            string saveFolder = Path.GetDirectoryName(saveFilePath);

            Process.Start(saveFolder);
        }
    }

    public class Task
    {
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }

        public string DescriptionAndDueDate
        {
            get { return $"{DueDate.ToShortDateString()} - {Description}"; }
        }
    }
}