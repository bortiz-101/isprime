# isprime

A simple C# console application that checks whether a given integer is a prime number.

## Description

`isprime` prompts the user to enter an integer and determines whether the number is prime using the `Prime` class from the `Utils` namespace.

The program runs continuously, allowing multiple checks until the user exits manually (`Ctrl+C`).

## Requirements

* .NET SDK (6.0 or later recommended)
* `Utils` namespace containing the `Prime` class with an `IsPrime(int)` method

You can verify your .NET installation with:

```
dotnet --version
```

## Compile and Run

From the project root directory (where the `.csproj` file is located):

### Build the project

```
dotnet build
```

### Run the application

```
dotnet run
```

Alternatively, build and run in one step:

```
dotnet run --project isprime.csproj
```

## Example

```
Enter a number to check if it is prime:
> 7
7 is a prime number.
Enter another number to check, or press Ctrl+C to exit.
```

Press `Ctrl+C` to exit the program.
