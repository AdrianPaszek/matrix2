﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisenhower_Matrix
{
    internal class Input
    {
        internal bool titleInput = true; //czemu tu muszę deklarować tą zmienną, czemu nie może być stringiem?

        public string GetTitle()
        {
            var titleInput = Console.ReadLine();
            if (titleInput != null)
            {
                return titleInput;
            }
            //if (titleInput == "A")
            //{
            //    Console.WriteLine("Aaaaaaa");
            //}
            else
            {
                return "No title";
            }

        }

        public string GetDeadline()
        {
            // input provides only day and month - year is firmed to 2023
            var deadlineInput = Console.ReadLine();
            if (deadlineInput != null)
            {
                return deadlineInput;
            }
            else
            {
                return "No deadline";
            }
        }

        public string GetMark()
        {
            var markInput = Console.ReadLine();
            if (markInput != null)
            {
                return markInput;
            }
            else
            {
                return "No mark";
            }
        }
    }
}
