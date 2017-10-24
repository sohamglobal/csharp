/* Example Demostrate shared Static Member Function */

using System;

class Account
{
private string accno;
private int balance;
private static double Irate=11.00;

	public Account(string accno,int balance)
	{
	this.accno=accno;
	this.balance=balance;
	}

	public void ShowInterest()
	{
	int newbalance= balance+(balance* (int) Irate/100);
	Console.WriteLine("Account Number : "+accno);
	Console.WriteLine("Balance : "+balance);
	Console.WriteLine("Interest rate : {0}%",Irate);
	Console.WriteLine("Balance after interest : "+newbalance);
	Console.WriteLine("-------------------------------------");
	}

	public static void ChangeIrate(double r)
	{
	//applicable to all objects of Account class
	Irate=r;
	}
}

class AccountDemo
{
public static void Main()
	{
	Account soham,sharayu;
	soham=new Account("30129932",25300);
	Account.ChangeIrate(11.50);
	
	sharayu=new Account("32194900",13100);
	soham.ShowInterest();
	sharayu.ShowInterest();
	}
}


//content of sohamglobal.com