# AoC C# Template

## Editing

1. Save your Advent of Code input file as `day[X].txt` under `/input/` e.g.
  ```text
  day1.txt
  day2.txt
  dayN.txt
  ```
2. Implement `class DayX : IDay` e.g.
  ```csharp
  public class Day1 : IDay
  {
      public string Part1(string input)
      {
          //calculate the answer for part 1
          return "answer";
      }

      public string Part2(string input)
      {
          //calculate the answer for part 2
          return "answer";
      }
  }
  ```

## Running

Calculate a specific Advent of Code day:  
```
dotnet run -- 1

Day1: <answer1> <answer2>
```

Calculate multiple specific Advent of Code days:  
```
dotnet run -- 1 3 5

Day1: <answer1> <answer2>
Day3: <answer1> <answer2>
Day5: <answer1> <answer2>
```

