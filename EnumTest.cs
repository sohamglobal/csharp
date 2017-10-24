//Demo program on enumerations

using System;

enum Temperature
{
boilingpoint=100,
comfort=26,
conditioned=18,
freezingpoint=0
}

enum Rating
{
sachin,
rahul,
saurav,
zaheer
}

class EnumTest
{
public static void Main()
{
int i=(int) Temperature.conditioned;
Console.WriteLine("AC must not be kept to {0} centigrade",i);

byte rt=(byte) Rating.rahul;
Console.WriteLine("{0} is rated {1}",Rating.rahul,++rt);

}
}



//content of sohamglobal.com