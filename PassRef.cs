//Demo on passing reference to a function using "ref" keyword

using System;

class PassRef
{
public static void Main()
{
int a=3;
Calc(ref a);
Console.WriteLine("value of a is {0}",a);
}

public static void Calc(ref int n)
{
n++;
}

}




//content of sohamglobal.com