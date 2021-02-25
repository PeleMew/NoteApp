using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс "Заметка" хранящий информацию о названии, тексте,
    /// категории, времени создания и изменения заметки
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Название заметки, не более 50 символов
        /// </summary>
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name.Length > 50)
                {
                    throw new ArgumentException("Название ограничено 50 символами");
                }
                else
                {
                    _name = value;
                    _lastChangeTime = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category;

        public NoteCategory Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
                _lastChangeTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _text;

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
                _lastChangeTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Время создания заметки
        /// </summary>
        private DateTime _creationTime;

        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }

            set
            {
                _creationTime = value;
            }
        }


        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        private DateTime _lastChangeTime;

        public DateTime LastChangeTime
        {
            get
            {
                return _lastChangeTime;
            }

            set
            {
                _lastChangeTime = value;
            }
        }

        /// <summary>
        /// Метод устанавливающий значения параметров
        /// </summary>
        /// <param name="name">Параметр имя заметки</param>
        /// <param name="category">Параметр категория заметки</param>
        /// <param name="text">Параметр текст заметки</param>
        public Note(string name, NoteCategory category, string text)
        {
            Name = name;
            Category = category;
            Text = text;
            CreationTime = DateTime.Now;
            LastChangeTime = DateTime.Now;
        }
    }
}
