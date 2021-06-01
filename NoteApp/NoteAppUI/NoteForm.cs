using System;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {

        private Note _note = new Note();

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
            foreach (NoteCategory category in Enum.GetValues(typeof(NoteCategory)))
            {
                EditCategoryComboBox.Items.Add(category);
            }
        }

        private void EditOKButton_Click(object sender, EventArgs e)
        {
            try
            {
                Note.Name = (String.IsNullOrWhiteSpace(EditNameTextBox.Text)) ? "Без названия" : EditNameTextBox.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void EditCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EditNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Note.Name = EditNameTextBox.Text;
        }

        private void EditTextBox_TextChanged(object sender, EventArgs e)
        {
            Note.Text = EditTextBox.Text;
        }

        private void EditCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note.Category = (NoteCategory)EditCategoryComboBox.SelectedItem;
        }
    }
}
