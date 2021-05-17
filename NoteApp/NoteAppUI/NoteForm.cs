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
            }
        }

        public NoteForm()
        {
            InitializeComponent();
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
    }
}
