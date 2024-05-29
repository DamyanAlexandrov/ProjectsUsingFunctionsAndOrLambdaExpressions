double[] prices = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .Select(x => x * 1.2)
    .ToArray();

foreach (var n in prices)
{
    Console.WriteLine($"{n:f2}");
}
