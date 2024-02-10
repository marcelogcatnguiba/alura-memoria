using System.Diagnostics;


IList<Guid> list = new List<Guid>();
LinkedList<Guid> linkedList = new LinkedList<Guid>();

Stopwatch sw = new Stopwatch();

sw.Start();

for (int i = 0; i < 1000000; i++)
{
    list.Add(Guid.NewGuid());
}

sw.Stop();
System.Console.WriteLine("List:");
System.Console.WriteLine($"Elapsed time: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();
sw.Start();

for (int i = 0; i < 1000000; i++)
{
    linkedList.AddLast(Guid.NewGuid());
}

sw.Stop();
System.Console.WriteLine("Linked list:");
System.Console.WriteLine($"Elapsed time: {sw.Elapsed.TotalMilliseconds}");