using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// Поле для хранения экземпляра проекта <see cref="Project"/>.
        /// </summary>
        private Project _project = new Project();

        private List<Note> _byCategory;

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.Add("All");
            foreach (NoteCategory category in Enum.GetValues(typeof (NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.SelectedItem = "All";
        }

        private void ShowNoteInformation(List<Note> noteList, int selectedIndex)
        {
            NameLabel.Text = noteList[selectedIndex].Name;
            NoteTextBox.Text = noteList[selectedIndex].Text;
            CategoryLabel.Text = "Category: " + noteList[selectedIndex].Category.ToString();
            CreatedDateTimePicker.Value = noteList[selectedIndex].CreatedTime;
            ModifiedDateTimePicker.Value = noteList[selectedIndex].ModifiedTime;
        }

        /// <summary>
        /// Метод для добавления новой заметки в проект.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                var created = noteForm.Note;
                _project.Notes.Insert(0, created);
                _project.ChosenCategory = created;
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                InsertInNoteListBox(created);
            }
        }

        private void InsertInNoteListBox(Note note)
        {
            if (CategoryComboBox.SelectedItem.ToString() == note.Category.ToString())
            {
                _byCategory = _project.SortByCategory(note.Category);
                NoteListBox.Items.Insert(0, note.Name);
                NoteListBox.SelectedIndex = 0;
            }
            else
            {
                if (CategoryComboBox.SelectedItem.ToString() == "All")
                {
                    NoteListBox.Items.Insert(0, note.Name);
                    NoteListBox.SelectedIndex = 0;
                }
            }
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = NoteListBox.SelectedIndex;
            var selectedNote = _project.Notes[selectedIndex];
            var noteForm = new NoteForm();
            noteForm.Note = selectedNote;
            noteForm.ShowDialog();

            if (noteForm.DialogResult == DialogResult.OK)
            {
                var editedNote = noteForm.Note;
                _project.Notes.RemoveAt(selectedIndex);
                _project.Notes.Insert(selectedIndex, editedNote);
                NoteListBox.Items.RemoveAt(selectedIndex);
                NoteListBox.Items.Insert(selectedIndex, editedNote.Name);
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                NoteListBox.SelectedIndex = selectedIndex;

            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = NoteListBox.SelectedIndex;

            if (selectedIndex > -1)
            {
                if (CategoryComboBox.SelectedItem.ToString() == "All")
                {
                    ShowNoteInformation(_project.Notes, selectedIndex);
                }
                else
                {
                    ShowNoteInformation(_byCategory, selectedIndex);
                }
            }
        }
    }
}
