//Demo on pointer manipulations

using System;
class MyClass
{
public unsafe void Method()
{
int x = 10;
int y = 20;
int *sum = Add(&x,&y);
Console.WriteLine(*sum);
}
public unsafe int* Add(int *x, int *y)
{
int sum;
sum = *x + *y;
return &sum;
}
}


class PointerSum
{
public static void Main()
{
MyClass obj = new MyClass();
obj.Method();
}
} 