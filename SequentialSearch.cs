//Demo program on sequential search

using System;

class SequentialSearch
{
public static void Main()
{
int[] a=new int[10];
int i,cnt=0;

for(i=0;i<=9;i++)
{
Console.Write("Enter a number ");
a[i]=Convert.ToInt32(Console.ReadLine());
}

//seq search mechanism to find total even numbers in the array

for(i=0;i<10;i++)
{
if(a[i]%2==0)
cnt++;
}

Console.WriteLine("Total even numbers are {0}",cnt);
}
}


//content of sohamglobal.com
