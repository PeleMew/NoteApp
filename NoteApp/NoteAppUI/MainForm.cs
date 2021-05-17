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
        private Project _project;

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
                NoteListBox.Items.Add(created.Name);

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
