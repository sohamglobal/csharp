//Demo program on SortedList class

using System;
using System.Collections;

class SortedListTest
{
public static void Main()
{
SortedList slist=new SortedList();
slist.Add(43,"java");
slist.Add(59,"C#");
slist.Add(17,"C++");
slist.Add(38,"python");
slist.Add(13,"SQL");

Console.WriteLine("Sorted Items are -");

foreach(string nm in slist.GetValueList())
Console.WriteLine(nm);

}
}



//content of sohamglobal.com