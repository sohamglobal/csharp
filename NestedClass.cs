//Demo program on nested classes

using System;

class Outer
{
	public void ShowOuter()
	{
	Console.WriteLine("outer tested ok..");
	}

	public class Inner
	{
	public void ShowInner()
	{
	Console.WriteLine("inner tested ok..");
	}
	}
}

class NestedClass
{
public static void Main()
{
Outer.Inner inobj=new Outer.Inner();
//inobj.ShowOuter();
inobj.ShowInner();

Outer outobj=new Outer();
outobj.ShowOuter();
//outobj.ShowInner();
}
}



//content of sohamglobal.com
