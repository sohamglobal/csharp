//Demo program on Stack class

using System;
using System.Collections;

class StackTest
{
public static void Main()
{
Stack st=new Stack();
st.Push("microsoft");
st.Push("oracle");
st.Push("intel");
st.Push("salesforce");
st.Push("google");

while(st.Count !=0)
{
Console.WriteLine("The count now is {0}",st.Count);
Console.WriteLine(st.Pop());
}

}
}



//content of sohamglobal.com