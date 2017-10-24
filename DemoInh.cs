//Demo program on inheritance

using System;

class One
{
private int sum;

public void ShowSum(int a,int b)
{
sum=a+b;
Console.WriteLine("sum is {0}",sum);
}
}


class Two:One
{
private int sqr;

public void ShowSqr(int n)
{
sqr=n*n;
Console.WriteLine("square is {0}",sqr);
}
}


class Three:One
{
private int cub;

public void ShowCube(int n)
{
cub=n*n*n;
Console.WriteLine("Cube is {0}",cub);
}
}


class DemoInh
{
public static void Main()
{
Two obj=new Two();
obj.ShowSqr(22);
obj.ShowSum(55,90);
//obj.ShowCube(25); not allowed

Three x=new Three();
//x.ShowSqr(22); not allowed
x.ShowSum(47,42);
x.ShowCube(25);

}
}


//content of sohamglobal.com