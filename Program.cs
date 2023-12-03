// See https://aka.ms/new-console-template for more information

using System.Reflection;
using AdventOfCode;

foreach (var day in GetDays())
{
    var calculator = GetDayCalculator(day);
    if (calculator == null)
    {
        Console.Error.WriteLine($"Day{day}: calculator not found");
        continue;
    }

    var input = GetInput(day);
    var result1 = calculator.Part1(input);
    var result2 = calculator.Part2(input);
    Console.WriteLine($"Day{day}: {result1} {result2}");
}
return;

IEnumerable<int> GetDays()
{
    var days = new List<int>();
    foreach (var arg in args)
    {
        if(int.TryParse(arg,out var day))
        {
            days.Add(day);
        }
    }
    if(!days.Any()) Console.WriteLine("Please provide one or more days to calculate");

    return days.OrderBy(i => i);
}

List<string> GetInput(int day)
{
    try
    {
        var input = File.ReadAllLines($"input/Day{day}.txt").ToList();
        return input;
    }
    catch (Exception)
    {
        Console.Error.WriteLine($"Day {day} input not found");
        return new List<string>();
    }
}

IDay? GetDayCalculator(int day)
{
    var foundCalculator = Assembly
        .GetExecutingAssembly()
        .GetTypes()
        .Where(type => type.IsAssignableTo(typeof(IDay)))
        .Where(type => type.Name.Equals($"Day{day}"))
        .ToArray();
    if (foundCalculator.Any()) 
        return (IDay)Activator.CreateInstance(foundCalculator.First())!;
        
    return null;
}