// Demo program on multithreading

using System;
using System.Threading;

public class MyThread 
{

public void Activity1() 
{
for (int i = 1; i <= 10; i++) {
Console.WriteLine("sohamglobal " + i);
Thread.Sleep(500);
}
}

public void Activity2() 
{
for (int i = 11; i <= 20; i++) 
{
Console.WriteLine("Spider " + i);
Thread.Sleep(500);
}
}
}

public class MultiThreading 
{
public static void Main() {
Console.WriteLine("Multithreading in C#");
MyThread thr1 = new MyThread();
MyThread thr2 = new MyThread();
Thread act1 = new Thread(new ThreadStart(thr1.Activity1) );
act1.Start();

Thread act2 = new Thread(new ThreadStart(thr2.Activity2) );
act2.Start();
}
}