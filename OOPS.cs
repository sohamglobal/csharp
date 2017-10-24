//Demo program on basic oops, class and object

using System;

class Customer
{
private string custnm;
private double amt,disc,net;

//empty constructor
public Customer()
{
net=0.0;
Console.WriteLine("welcome to C# shop");
}

//parameterized constructor
public Customer(string shopnm)
{
net=0.0;
Console.WriteLine("welcome to {0}",shopnm);
}

public void GetNewCustData()
{
Console.Write("Enter name ");
custnm=Console.ReadLine();
Console.Write("Enter amount ");
amt=Convert.ToDouble(Console.ReadLine());
}

public void CalcNet()
{
disc=amt*10/100;
net=amt-disc;
}

public void ShowCustData()
{
Console.WriteLine("Name: {0}",custnm);
Console.WriteLine("NetBill:Rs. {0}",net);
}

public static void Display()
{
Console.WriteLine("Thanks for your visit");
}
}

class OOPS
{
public static void Main()
{
Customer c=new Customer("Shivaji Super Bazaar");
c.GetNewCustData();
c.CalcNet();
c.ShowCustData();
//c.Display();
//to run a static function
Customer.Display();
}
}




//content of sohamglobal.com



