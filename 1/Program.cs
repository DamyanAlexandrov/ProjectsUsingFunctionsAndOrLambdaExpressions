var nums = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x))
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToArray();

Console.WriteLine(String.Join(", ", nums));
