Func<string, int> parcer = n => int.Parse(n);

var nums = Console.ReadLine()
    .Split(",")
    .Select(parcer)
    .ToArray();

Console.WriteLine(nums.Count());
Console.WriteLine(nums.Sum());
