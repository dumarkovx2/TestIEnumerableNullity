using My.Extensions;

var a = new ClassA();

foreach (var e in a.DoSomething(1))
{
    Console.WriteLine(e);
}

a = null;
foreach (var e in a.DoSomething(2))
{
    Console.WriteLine(e);
}

foreach (var e in a?.DoSomething(3))
{
    Console.WriteLine(e);
}

public class ClassA {}

namespace My.Extensions
{
    public static class ExtClassA
    {
        public static IEnumerable<int> DoSomething(this ClassA a, int i)
        {
            Console.WriteLine($"DoSomething executed ({i})");

            return Enumerable.Range(1, 3);
        }
    }
}