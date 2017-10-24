//Demo program on generating machine specifications

using System;

class MyMachine
{
public static void Main()
{
OperatingSystem os=Environment.OSVersion;
PlatformID id=os.Platform;
string[] drives=Environment.GetLogicalDrives();
string drvs="";

foreach(string dr in drives)
drvs+=dr+",";

Console.WriteLine("Machine Name : {0}",Environment.MachineName);
Console.WriteLine("Operating System : {0}",Environment.OSVersion);
Console.WriteLine("Operating System ID: {0}",id);
Console.WriteLine("Current Folder : {0}",Environment.CurrentDirectory);
Console.WriteLine("CLR version : {0}",Environment.Version);
Console.WriteLine("Present Drive : {0}",drvs);
}
}


//content of sohamglobal.com
