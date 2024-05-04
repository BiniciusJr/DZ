using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Vranjes
{
    internal class ZAD4
    {
        public class Note
        {
            public string Title { get; set; }
            public string Text { get; set; }
            public DateTime CreatedAt { get; private set; }

            public Note(string title, string text)
            {
                Title = title;
                Text = text;
                CreatedAt = DateTime.Now;
            }
        }

        public class Notes
        {
            public string author { get; private set; }
            public List<Note> NotesList;

            public Notes(string author)
            {
                this.author = author;
                NotesList = new List<Note>();
            }

            public void AddNote(Note note)
            {
                NotesList.Add(note);
            }
        }
    }
}
