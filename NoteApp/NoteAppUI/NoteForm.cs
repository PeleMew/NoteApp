using System;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {

        private Note _note;

        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                if (_note != null)
                {
                    EditNameTextBox.Text = _note.Name;
                    EditTextBox.Text = _note.Text;
                    EditCategoryComboBox.SelectedItem = _note.Category;
                    EditModifiedDateTimePicker.Value = _note.ModifiedTime;
                    EditCreatedDateTimePicker.Value = _note.CreatedTime;

                }
            }
        }

        public NoteForm()
        {
            InitializeComponent();
            EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Documents);
            EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Finance);
            EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Home);
            EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Other);
            EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.People);
            EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.HealthAndSport);
            EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Work);
        }

        private void EditOKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EditNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Name = EditNameTextBox.Text;
        }

        private void EditTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Text = EditTextBox.Text;
        }
    }
}
