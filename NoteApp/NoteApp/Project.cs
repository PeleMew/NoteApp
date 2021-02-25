using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс "Проект" содержащий список всех заметок в приложении
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех заметок
        /// </summary>
        private List<Note> _notes;

        public List<Note> Notes
        {
            get
            {
                return _notes;
            }

            set
            {
                _notes = Notes;
            }
        }

        public Project()
        {
            
        }
    }
}
