using System;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс <see cref="Note"/>, хранящий информацию о заметке
    /// </summary>
    public class Note : ICloneable
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
        private DateTime _createdTime;

        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        private DateTime _modifiedTime;

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
                if (value.Length > 50)
                {
                    throw new ArgumentException("Note name maximum 50 characters");
                }
                else
                {
                    _name = value;
                    _modifiedTime = DateTime.Now;
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
                _modifiedTime = DateTime.Now;
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
                _modifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает и задает время создания заметки
        /// </summary>
        public DateTime CreatedTime
        {
            get
            {
                return _createdTime;
            }

            private set
            {
                _createdTime = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время последнего изменения заметки
        /// </summary>
        public DateTime ModifiedTime
        {
            get
            {
                return _modifiedTime;
            }

            private set
            {
                _modifiedTime = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Note"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="text"></param>
        [JsonConstructor]
        public Note(string name, NoteCategory category, string text, DateTime createdTime, DateTime modifiedTime)
        {
            Name = name;
            Category = category;
            Text = text;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
        }

        /// <summary>
        /// Конструктор без параметров, устанавливает значения полей Название, Текст заметки, 
        /// Категория, Время создания ,Время изменения
        /// </summary>
        public Note()
        {
            Name = "Без названия";
            Text = null;
            Category = NoteCategory.Other;
            CreatedTime = DateTime.Now;
        }

        public Note(string name, NoteCategory category, string text) : this()
        {
            Name = "Без названия";
            Category = NoteCategory.Other;
            Text = null;
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
