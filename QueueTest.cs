//Demo program on Queue class

using System;
using System.Collections;

class QueueTest
{
public static void Main()
{
Queue q=new Queue();
q.Enqueue("cricket");
q.Enqueue("football");
q.Enqueue("tennis");
q.Enqueue("rugby");

while(q.Count !=0)
Console.WriteLine(q.Dequeue());


Console.WriteLine("After accessing all elements the count is {0}",q.Count);

}
}



//content of sohamglobal.com