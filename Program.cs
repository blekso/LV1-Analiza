using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza
{
    class Program
    {
        static void Main(string[] args)
        {
            Note testNote = new Note();
            Note defaultNote = new Note("Bok, c# je bas super!", "Mihael");
            Note privilegedNote = new Note("Na noge svi sad, nek trese se grad!", "Severina", 3);

            Console.WriteLine(testNote.getNoteAuthor());
            Console.WriteLine(testNote.getNoteText());

            Console.WriteLine(defaultNote.getNoteAuthor());
            Console.WriteLine(defaultNote.getNoteText());

            Console.WriteLine(privilegedNote.getNoteAuthor());
            Console.WriteLine(privilegedNote.getNoteText());

            Console.WriteLine(privilegedNote.ToString());

            DateTime date = DateTime.Now;
            TimeNote noteWithTimeStamp = new TimeNote("Karantena nije super, send help :(", "Mihael", 3, date);
            Console.WriteLine(noteWithTimeStamp.ToString());

            ToDoList tasks = new ToDoList();
            tasks.AddNote();
            tasks.AddNote();
            tasks.AddNote();
            Console.WriteLine(tasks.ToString());
            tasks.RemoveHighestImportanceNotes();
            Console.WriteLine(tasks.ToString());



            Console.ReadLine();
        }
    }
}
