//Demo program on creating array in C#
using System;

class Arrays
{
public static void Main()
{
int i;
int[] arr=new int[10];
for(i=0;i<10;i++)
{
arr[i]=Convert.ToInt32(Console.ReadLine());
}

foreach(int n in arr)
Console.WriteLine("{0}",n);
}
}


//content of sohamglobal.com