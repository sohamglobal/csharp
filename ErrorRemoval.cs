//Demo program on Exception handling (try-catch)

using System;

class ErrorRemoval
{
public static void Main()
{
string nm;
int mks;

Console.Write("Enter Name ");
nm=Console.ReadLine();
Console.Write("Enter marks ");
try
{
mks=Convert.ToInt32(Console.ReadLine());
}
catch(Exception)
{
Console.WriteLine("sorry invalid marks..reset to zero");
mks=0;
}


if(mks>=35)
Console.WriteLine("{0} you are pass",nm);
else
Console.WriteLine("{0} you are FAIL",nm);
}
}




//content of sohamglobal.com