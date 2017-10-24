//Demo program on function overloading

using System;

class Calculate
{
private int sum;

public void CalcSum(int a,int b)
{
sum=a+b;
}

public void CalcSum(int a,int b,int c)
{
sum=a+b+c;
}

public void CalcSum(int a,int b,int c,int d)
{
sum=a+b+c+d;
}

public void ShowSum()
{
Console.WriteLine("sum is {0}",sum);
}
}

class FunOver
{
public static void Main()
{
Calculate cal=new Calculate();
cal.CalcSum(23,45,12);
cal.ShowSum();
cal.CalcSum(44,78);
cal.ShowSum();
}
}




//content of sohamglobal.com

