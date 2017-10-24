//Demo program on ArrayList class

using System;
using System.Collections;

class ArrayListTest
{
public static void Main()
{
ArrayList list=new ArrayList();

list.Add("praffull");
list.Add("sachin");
list.Add("rahul");
list.Add("saurav");

for(int i=0;i<list.Count;i++)
Console.WriteLine(list[i]);


Console.Write("\n\n ---------------\n");

list.Insert(2,"zaheer");
list.Remove("praffull");

foreach(string nm in list)
Console.WriteLine(nm);

}
}


//content of sohamglobal.com