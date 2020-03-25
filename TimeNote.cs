using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza
{
    class TimeNote : Note
    {

        public DateTime timeStamp;

        public TimeNote(string iNoteText, string iNoteAuthor, int iImportanceLevel, DateTime currentTimeStamp) : base(iNoteText, iNoteAuthor, iImportanceLevel)
        {
            this.timeStamp = currentTimeStamp;
        }

        public DateTime TimeStamp
        {
            get { return this.timeStamp; }
            set { this.timeStamp = value; }
        }

        public override string ToString()
        {
            return this.NoteAuthor + " - " + this.NoteText + ", Created:" + this.timeStamp;
        }
    }
}
