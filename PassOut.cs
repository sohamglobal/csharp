//Demo on "out" keyword

using System;

class PassOut
{
public static void Main()
{
int a;
Calc(out a);
Console.WriteLine(a);
}

public static void Calc(out int n)
{
n=5;
n++;
}


}



//content of sohamglobal.com