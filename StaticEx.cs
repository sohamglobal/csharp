//basic example of static function

using System;

class TestStat
{
public void Show()
{
Console.WriteLine("Simple function tested ok");
}

public static void Display()
{
Console.WriteLine("Static function tested ok");
}

}

class StaticEx
{
public static void Main()
{
TestStat ts=new TestStat();
ts.Show();
//ts.Display()	not allowed
TestStat.Display();
}
}


//content of sohamglobal.com

