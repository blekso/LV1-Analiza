using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza
{
    class Note
    {
        private string noteText;
        private string noteAuthor;
        private int importanceLevel;


        public Note()
        {
            this.noteText = "-";
            this.noteAuthor = "-";
            this.importanceLevel = 1;
        }

        public Note(string iNoteText, string iNoteAuthor)
        {
            this.noteText = iNoteText;
            this.noteAuthor = iNoteAuthor;
            this.importanceLevel = 1;
        }

        public Note(string iNoteText, string iNoteAuthor, int iImportanceLevel)
        {
            this.noteText = iNoteText;
            this.noteAuthor = iNoteAuthor;
            this.importanceLevel = iImportanceLevel;
        }


        public string getNoteText()
        {
            return noteText;
        }

        public string getNoteAuthor()
        {
            return noteAuthor;
        }

        public int getImportanceLevel()
        {
            return importanceLevel;
        }

        public void setNoteText(string iNoteText)
        {
            this.noteText = iNoteText;
        }

        public void setImportanceLevel(int iImportanceLevel)
        {
            this.importanceLevel = iImportanceLevel;
        }

        public string NoteText
        {
            get { return this.noteText; }
            set { this.noteText = value; }
        }

        public string NoteAuthor
        {
            get { return this.noteAuthor; }
        }

        public int ImportanceLevel
        {
            get { return this.importanceLevel; }
            set { this.importanceLevel = value; }
        }

        public override string ToString()
        {
            return this.NoteAuthor + " - " + this.NoteText;
        }
    }
}
