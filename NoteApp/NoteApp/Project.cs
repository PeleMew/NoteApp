using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс <see cref="Project"/>, хранящий список заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Вовзращает и задает список заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        public Note ChosenCategory { get; set; }

        public List<Note> SortByCategory(NoteCategory category)
        {
            List<Note> byCategoryListNote = new List<Note>();
            foreach (Note note in Notes)
            {
                if (note.Category == category)
                {
                    byCategoryListNote.Add(note);
                }
            }

            byCategoryListNote.Sort();
            return byCategoryListNote;
        }
    }
}
