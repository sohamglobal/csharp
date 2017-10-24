//Demo program on constructor behavior during inheritance and "base" keyword

using System;

class One
{
public One()    //empty constructor of base class
{
Console.WriteLine("Empty constructor of base");
}
public One(string nm)  //parameterized constructor of base class
{
Console.WriteLine("welcome {0} to parameterized constructor of base...",nm);
}
public void DispOne()
{
Console.WriteLine("One ran successfully...");
}
}

class Two:One
{
public Two()
{
Console.WriteLine("Empty constructor of derived");
}

public Two(string nm):base(nm)  //constructor of derived class
{
Console.WriteLine("dear {0},running parameterized constructor of derived...",nm);
}
public void DispTwo()
{
Console.WriteLine("Two ran successfully ...");
}
}


class BaseConstruct
{
public static void Main()
{
//Two x=new Two();
Two x=new Two("praffull");
x.DispOne();
x.DispTwo();
}
}



//content of sohamglobal.com




