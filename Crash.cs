//Demo program with run time errors

using System;

class Crash
{
public static void Main()
{
string nm;
int mks;

Console.Write("Enter Name ");
nm=Console.ReadLine();
Console.Write("Enter marks ");
mks=Convert.ToInt32(Console.ReadLine());

if(mks>=35)
Console.WriteLine("{0} you are PASS",nm);
else
Console.WriteLine("{0} you are FAIL",nm);
}
}



//try entering string in marks, generates a runtime errors and terminates abnormally
//Check Exception handling code in ErrorRemoval.cs
//content of sohamglobal.com