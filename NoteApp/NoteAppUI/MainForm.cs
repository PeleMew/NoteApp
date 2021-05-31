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

        public Project Project
        {
            get
            {
                return _project;
            }
            set
            {
                _project = value;
            }
        }

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Documents);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Other);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.People);
            CategoryComboBox.Items.Add(NoteApp.NoteCategory.Work);
            CategoryComboBox.Items.Add("All");
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
                _project.Notes.Add(created);
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                NoteListBox.Items.Add(created.Name);
                NoteListBox.SelectedIndex = NoteListBox.Items.Count - 1;

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
    }
}
