//Demo program on Call by value

using System;

class CallByValue
{
public static void Main()
{
int n=15;
Manipulate(n);
Console.WriteLine("Value of n is {0}",n);
}

private static void Manipulate(int a)
{
a+=10;
}
}




//content of sohamglobal.com