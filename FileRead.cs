//Demo program on reading a text file

using System;
using System.IO;

class FileRead
{
public static void Main()
{
string filenm;
Console.Write("Enter full filename ");
filenm=Console.ReadLine();

FileStream fsr=File.Open(filenm,FileMode.Open,FileAccess.Read);
byte[] b=new byte[fsr.Length];

Console.WriteLine("File is of {0} bytes",fsr.Length);

fsr.Read(b,0,b.Length);
//Console.Write(b);
Console.Write(System.Text.Encoding.ASCII.GetString(b));

fsr.Close();
}
}



//content of sohamglobal.com