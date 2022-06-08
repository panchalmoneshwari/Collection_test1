using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_test
{
    class Listmockexan
    {
        static void Main(string[] args)
        {
            List<string> lt = new List<string>();
            lt.Add("Deepa mam");
            lt.Add("Manali");
            lt.Add("Deepa mam");
            lt.Add("Manali");
            lt.Add("Deepa mam");
            lt.Add("Deepa mam");
            Dictionary<string, int> ds = new Dictionary<string, int>();


            foreach (dynamic d in lt)
            {

                if (ds.ContainsKey(d))
                {
                    int oldval = ds[d];
                    ds[d] = oldval+1;

                }
                else
                    ds.Add(d, 1);
            }
            
                foreach (dynamic c in ds)
                {
                    Console.WriteLine(c);
                }
            
            Console.ReadLine();
        }
    }
    class List1
    {
        static void Main(string[] args)
        {
            string s = "manali";

        }
    }
}
