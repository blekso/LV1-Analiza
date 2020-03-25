using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza
{
    class ToDoList : IListOperations
    {

        private List<Note> Tasks;

        public ToDoList()
        {
            this.Tasks = new List<Note>();
        }

        public void AddNote()
        {
            Console.WriteLine("Enter task and its author");
            Note temp = new Note(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            Tasks.Add(temp);
        }

        public void RemoveNote(int iImportanceLevel)
        {
            foreach(Note note in Tasks)
                if(iImportanceLevel == note.getImportanceLevel())
                {
                    Tasks.Remove(note);
                }
        }

        public void RemoveHighestImportanceNotes()
        {
            int importance = FindHighestImportanceNotes();
            for(int i = 0; i<Tasks.Count; i++)
            {
                if(Tasks[i].getImportanceLevel() == importance)
                {
                    Tasks.RemoveAt(i);
                    i--;
                }
            }
        }

        public int FindHighestImportanceNotes()
        {
            int maxImportance = 0;
            foreach (Note note in Tasks)
            {
                if (note.getImportanceLevel() > maxImportance)
                {
                    maxImportance = note.getImportanceLevel();
                }
            }
            return maxImportance;
        }

        public Note GetNoteAtIndex(int index)
        {
            return Tasks.ElementAt(index);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Note note in Tasks)
            {
                stringBuilder.Append(note).Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
}