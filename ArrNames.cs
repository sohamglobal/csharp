//Demo program on string array

using System;
class ArrNames
{
public static void Main()
{
string[] nm=new string[10];
string sval;
int i;

for(i=0;i<10;i++)
{
Console.Write("Enter name ");
nm[i]=Console.ReadLine();
}

Console.Write("Enter name to be searched ");
sval=Console.ReadLine();

for(i=0;i<10;i++)
{
if(sval==nm[i])
Console.WriteLine("Name found at {0}",i+1);
}

}
}

//sequential search on string array