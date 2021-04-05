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
    }
}
