using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// "Заметка" хранит информацию о названии, тексте,
    /// категории, времени создания и изменения заметки
    /// </summary>
    public class Note:ICloneable
    {
        /// <summary>
        /// Название заметки, не более 50 символов
        /// </summary>
        private string _name;

        /// <summary>
        /// Категории заметок
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _text;

        /// <summary>
        /// Время создания заметки
        /// </summary>
        private DateTime _creationTime;

        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        private DateTime _lastChangeTime;

        /// <summary>
        /// Возвращает и задает название заметки
        /// </summary>
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
        /// Возвращает и задает категорию заметки
        /// </summary>
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
        /// Возвращает и задает текст заметки
        /// </summary>
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
        /// Возвращает и задает время создания заметки
        /// </summary>
        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }

            private set
            {
                _creationTime = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время последнего изменения заметки
        /// </summary>
        public DateTime LastChangeTime
        {
            get
            {
                return _lastChangeTime;
            }

            private set
            {
                _lastChangeTime = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Note"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="text"></param>
        [JsonConstructor]
        public Note(string name, NoteCategory category, string text, DateTime creationTime, DateTime lastChangeTime)
        {
            Name = name;
            Category = category;
            Text = text;
            CreationTime = DateTime.Now;
            LastChangeTime = DateTime.Now;
        }

        /// <summary>
        /// Создает экземпляр
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="text"></param>
        public Note(string name, NoteCategory category, string text)
        {
            Name = name;
            Category = category;
            Text = text;
            CreationTime = DateTime.Now;
            LastChangeTime = DateTime.Now;
        }

        /// <summary>
        /// Метод для создания копии объекта
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
