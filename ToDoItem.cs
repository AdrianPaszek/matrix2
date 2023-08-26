﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class ToDoItem
    {
        private string? Title { get; set; }
        private DateTime Deadline { get; set; }
        private bool IsDone { get; set; } = false;
        private char ItemMark { get; set; }

        public ToDoItem(string? title, DateTime deadline)
        {
            Title = title;
            Deadline = deadline;
        }

        public string CreateToDoItem(string title, DateTime deadline)
        {
            Title = title;
            Deadline = deadline;
            return ToString();
        }

        public void Mark()
        {
            IsDone = true;
        }

        public void Unmark()
        {
            IsDone = false;
        }

        public override string ToString()
        {
            ItemMark = IsDone ? 'x' : ' ';
            return $"[{ItemMark}] {Deadline} {Title}";
        }


    }
}