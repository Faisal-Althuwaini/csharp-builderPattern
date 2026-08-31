# ConsoleApp1 — Builder Pattern Demo

A small C# console app that demonstrates the **Builder** design pattern by
assembling `Meal` objects through a fluent `MealBuilder`, with a `MealDirector`
that provides pre-defined and interactive recipes.

## Structure

| File | Role |
| --- | --- |
| [Meal.cs](ConsoleApp1/Meal.cs) | Product — the object being built, with price calculation |
| [MealBuilder.cs](ConsoleApp1/MealBuilder.cs) | Fluent builder with chained `SetX` methods |
| [MealDirector.cs](ConsoleApp1/MealDirector.cs) | Predefined (`BuildComboMeal`, `BuildKidsMeal`) and interactive (`BuildCustomMeal`) builds |
| [Program.cs](ConsoleApp1/Program.cs) | Entry point / usage examples |

## Requirements

- [.NET SDK 10.0](https://dotnet.microsoft.com/download)

## Run

```bash
dotnet run --project ConsoleApp1
```

## Build

```bash
dotnet build
```
