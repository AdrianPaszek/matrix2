using System;
using System.Collections.Generic;
using System.Text;
using Eisenhower_Matrix.Model;

namespace Eisenhower_Matrix
{
    public class ToDoQuarter
    {
        public List<ToDoItem> ToDoItems;

        public ToDoQuarter()
        {
            ToDoItems = new List<ToDoItem>();
        }

      
        public void AddItem(int id, string title, DateTime deadline, bool isDone)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Tytuł zadania nie może być pusty lub null.", nameof(title));
            }

            if (deadline < DateTime.Now)
            {
                throw new ArgumentException("Termin wykonania zadania nie może być w przeszłości.", nameof(deadline));
            }

            ToDoItems.Add(new ToDoItem(id, title, deadline, isDone));
        }

        public void RemoveItem(int index)
        {
            if (index < 0 || index >= ToDoItems.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Indeks poza zakresem.");
            }

            ToDoItems.RemoveAt(index);
        }

        public ToDoItem GetItem(int index)
        {
            if (index < 0 || index >= ToDoItems.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Indeks poza zakresem.");
            }

            return ToDoItems[index];
        }

        public void ArchiveItems()
        {
            ToDoItems.RemoveAll(item => item.IsDone);
        }

     
        public List<ToDoItem> GetItems()
        {
            return ToDoItems;
        }

  
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ToDoItems.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {ToDoItems[i]}");
            }
            return sb.ToString();
        }
    }
}
