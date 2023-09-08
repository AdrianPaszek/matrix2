﻿using System.Text;
using Eisenhower_Matrix.Model;

namespace Eisenhower_Matrix
{
    public class ToDoQuarter
    {

        // creates empty list named ToDoItems with strings containing description of ToDoItems objects
        public List<ToDoItem> ToDoItems;

        public ToDoQuarter()
        {
            ToDoItems = new List<ToDoItem>();
        }

        public void AddItem(int id, string title, DateTime deadline, bool isDone)
        {
            ToDoItems.Add(new ToDoItem(id, title, deadline, isDone));
        }

        public void RemoveItem(int index)
        {
            ToDoItems.Remove(ToDoItems[index]);
            // Removes *TodoItem* object using *index* of list *todoItems*
        }
        public void ArchiveItems()
        {
            // Removes all *TodoItem* objects with a parameter* isDone* set to *true* from list *todoItems*.
        }

        public void GetItem(int index)
        {
            // Returns* TodoItem* object from *index* of list* todoItems*.
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
