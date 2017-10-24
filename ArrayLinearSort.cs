//Demo program on Linear sort

using System;

class ArrayLinearSort
{
public static void Main()
{
int i,j,tmp;
int[] arr=new int[10];
Console.WriteLine("Enter 10 numbers -");

for(i=0;i<10;i++)
arr[i]=Convert.ToInt32(Console.ReadLine());

//Linear Sort

for(i=0;i<=8;i++)
{
for(j=i+1;j<=9;j++)
{
if(arr[j]<arr[i])
{
tmp=arr[j];
arr[j]=arr[i];
arr[i]=tmp;
}
}
}

Console.WriteLine("The sorted Array -");
foreach(int n in arr)
Console.WriteLine("{0}",n);


}
}




//content of sohamglobal.com




