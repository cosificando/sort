using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    public class Sort
    {
        public static List<int> asList(List<int> list)
        {
            List<int> sortList;
            sortList = new List<int>();

            if (list == null)
                return sortList;

            if (list.Count == 1)
                sortList.Add(list[0]);
            
            return sortList;
        }
    }
}
