﻿using System.Collections.Generic;

namespace DataStructures.Dictionaries
{
    internal class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y,true);
        }
    }
}