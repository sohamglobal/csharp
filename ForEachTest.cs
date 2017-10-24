//Demo on foreach statement

using System;

class ForEachTest
{
public static void Main()
{
string[] nm=new string[5];
int j;

for(j=0;j<5;j++)
nm[j]=Console.ReadLine();

foreach(string s in nm)
Console.WriteLine("{0}",s);
}
}




//content of sohamglobal.com