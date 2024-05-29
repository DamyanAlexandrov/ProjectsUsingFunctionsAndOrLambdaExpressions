Func<string, bool> upper = x => x[0] == x.ToUpper()[0];

var words = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(upper)
    .ToArray();

foreach(var word in words)
{
    Console.WriteLine(word);
}
