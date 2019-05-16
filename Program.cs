using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(46);
            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);
            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Kerrin", "Mellisa", "Louise", "Paul" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();
            aList2.Insert(2, "Jim");
            ArrayList range = aList2.GetRange(1, 3);
            foreach(object o in range)
            {
                Console.WriteLine(o);
            }
            foreach (object o in aList)
            {
                Console.WriteLine(o);
            }
            //aList2.RemoveAt(1);
            //aList2.RemoveRange(2, 3);
            Console.WriteLine("Kerrin Index : {0}", aList2.IndexOf("Kerrin", 0));
            // convert arralist into array
            string[] myArray = (string[])aList2.ToArray(typeof(string));
            string[] customers = { "One", "Two", "Three" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);
            foreach (string s in custArrayList
                )
            {
                Console.WriteLine(s);
            }
            #endregion
            Console.ReadLine(); 
        }
    }
}
