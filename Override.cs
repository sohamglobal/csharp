//Demo on method overriding,virtual keywork and runtime polymorphism

using System;

class One
{
public virtual void Show()
{
Console.WriteLine("class One executed...");
}
}

class Two:One
{
public override void Show()
{
Console.WriteLine("class Two executed...");
}
}

class Test
{
public static void Main()
{
    //Two x = new Two();
    //x.Show();
    //x.Show();

    One refobj;
    One x = new One();
    Two y = new Two();

    refobj = x;
    refobj.Show();

    refobj = y;
    refobj.Show();
   
}
}



//content of sohamglobal.com


