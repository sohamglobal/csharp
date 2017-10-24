//Demo program for switch statement

using System;
class CustomerSwitch
{
public static void Main()
{
string cnm;
int ctype;
double pamt,disc,net;

Console.Write("Enter Name ");
cnm=Console.ReadLine();
Console.Write("Enter type ");
ctype=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount ");
pamt=Convert.ToDouble(Console.ReadLine());

switch(ctype)
{
case 4:
disc=pamt*10/100;
break;
case 5:
disc=pamt*8/100;
break;
case 7:
disc=pamt*5/100;
break;
default:
disc=0;
break;
}
net=pamt-disc;
Console.Write("{0}, your net bill is Rs.{1}",cnm,net);
}
}
