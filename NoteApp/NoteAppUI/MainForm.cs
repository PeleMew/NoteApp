using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
		/// Объект класса Project для хранения заметок
		/// </summary>
        private Project _project;

        /// <summary>
		/// Коллекция объектов Note для хранения заметок по выбранной категории
		/// </summary>
        private List<Note> _categoryNotes;


        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();

            if (noteForm.DialogResult == DialogResult.OK)
            {
                var created = noteForm.Note;
                _project.Notes.Add(created);
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);

            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

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
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
        }
    }
}
