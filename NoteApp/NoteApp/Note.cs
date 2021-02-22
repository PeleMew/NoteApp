using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Note
    {
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
