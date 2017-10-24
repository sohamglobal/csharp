//Demo on creating directory and writing a file

using System;
using System.IO;

class FileTest
{
public static void Main()
{

if(!Directory.Exists("d:\\sohamglobal"))
Directory.CreateDirectory("d:\\sohamglobal");

string filename="d:\\sohamglobal\\csharp.txt";
StreamWriter obj=new StreamWriter(filename);
obj.Write("this is c# testing");
obj.Close();


Console.WriteLine("Directory and file created successfully");

}
}




//content of sohamglobal.com