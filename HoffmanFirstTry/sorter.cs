using System;
using System.Collections.Generic;

namespace HoffmanFirstTry
{
    public static class QuikSort
    {
        public static List<Node> Sort(List<Node> sort)
        {
            if (sort.Count <= 1)
                return sort;

            List<Node> Links = new List<Node>();
            List<Node> Rechts = new List<Node>();

            
            Node tmp = sort[sort.Count / 2];
            sort.Remove(sort[sort.Count / 2]);

            foreach (var item in sort)
                if (item.value > tmp.value)
                    Rechts.Add(item);
                else if (item.value < tmp.value)
                    Links.Add(item);
                else if (item.value == tmp.value)
                    Links.Add(item);

            Links = Sort(Links);
            Rechts = Sort(Rechts);
            sort.Clear();
            sort = Links;
            sort.Add(tmp);

            foreach (var item in Rechts)
                sort.Add(item);
            
            return sort;
        }
    }
}