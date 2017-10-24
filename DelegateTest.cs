//Demo program on delegates

using System;

class DelegateTest
{
delegate int MyDelegate(int p,int q);

public static void Main()
{
MyDelegate MyMethod;

MyMethod=new MyDelegate(Add);
int res=MyMethod(23,56);
Console.WriteLine("sum is {0}",res);

MyMethod=new MyDelegate(Sub);
res=MyMethod(84,75);
Console.WriteLine("subtraction is {0}",res);

MyMethod=new MyDelegate(CalcBill);
res=MyMethod(4570,245);
Console.WriteLine("Net Bill is {0}",res);
}

static int Add(int a,int b)
{
return a+b;
}
static int Sub(int a,int b)
{
return a-b;
}
static int CalcBill(int amt,int disc)
{
int net;
net=amt-disc;
return(net);
}
}



//content of sohamglobal.com