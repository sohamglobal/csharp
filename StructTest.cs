//Demo of using structure 

using System;

struct sample
{
public string nm;
public string mobile;

/*
public void ShowData()
{
Console.WriteLine("Name: {0}, Mobile: {1}",nm,mobile);
}
*/

}

class StructTest
{
public static void Main()
{
sample s;
s.nm="praffull";
s.mobile="1234512345";

Console.WriteLine("Name: {0}, Mobile: {1}",s.nm,s.mobile);

//s.ShowData();
}
}