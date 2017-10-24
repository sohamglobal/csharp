//Demo on creating a pointer and "unsafe" keyword

using System;

class UnsafePointerTest
{
public unsafe static void Main()
{
int num=10;
int *ptr;

ptr=&num;

Console.WriteLine("Number {0}", *ptr);

}
}

//...............> csc/unsafe UnsafePointerTest.cs
//content of sohamglobal.com