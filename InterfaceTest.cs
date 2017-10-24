//Demo program on interfaces 

using System;

interface Bank
{
void ShowAmount(double bal);
}

interface Finance
{
void ShowLoan(double sal);
}

class Money:Bank,Finance
{
private double amount;
private double loan;

//definition of function of Bank interface
public void ShowAmount(double bal)
{
amount=bal+(bal*7/100);
Console.WriteLine("total amount will be {0}",amount);
}

//definition of function of Finance interface
public void ShowLoan(double sal)
{
loan=sal*25;
Console.WriteLine("total loan you can get is {0}",loan);
}

public void ShowMess()
{
Console.WriteLine("Try cross platform .NET core 2.0 on Linux");
}
}


class InterfaceTest
{
public static void Main()
{
Money m=new Money();
m.ShowLoan(7500);
m.ShowAmount(12900);
m.ShowMess();
}
}


//content of sohamglobal.com

