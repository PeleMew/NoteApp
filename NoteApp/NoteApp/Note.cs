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
                }
            }
        }

        private NoteCategory _category;

        private string _text;

        private DateTime _creationTime;

        private DateTime _lastChangeTime;
    }
}
