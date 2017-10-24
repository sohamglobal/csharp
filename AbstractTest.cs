//Demo program on abstract class,protected member and this keyword

using System;

abstract class MyName
{
protected string nm;
public abstract void ShowName();
public void TestFun()
{
Console.WriteLine("normal function in abstract class tested ok...");
}
}

class MyCity:MyName
{
private string cit;
public void GetName(string nm)
{
this.nm=nm;
}

public void ShowCity(string ct)
{
this.cit=ct;
Console.WriteLine("my city is {0}",cit);
}

public override void ShowName()
{
Console.WriteLine("My name is {0}",nm);
}
    
}

class AbstractTest
{
public static void Main()
{
//MyName mn=new MyName();   //abstract classes cant be instantiated
MyCity me=new MyCity();
me.GetName("Praffull Singh");
me.ShowName();
me.ShowCity("London");
me.TestFun();
}
}





//content of sohamglobal.com




