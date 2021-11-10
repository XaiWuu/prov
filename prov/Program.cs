using System;

prov();

static void prov()
{


string name = "";

int level = 0;

bool success = false;

Console.WriteLine($"Make a name (at least 3 letters, max 32 letters)");

name = Console.ReadLine();
Console.WriteLine($"Nice name {name}");

// den omvandlar int till en string
Console.WriteLine($"Choose a level 0 to 21");
while (success == false)
{
    string input = Console.ReadLine();
    success = int.TryParse(input, out level);

// om det är bokstäver så säger den det
    if (!success)
    {
        Console.WriteLine($"Only numbers");
    }
}

// om leveln är mellen 0 och 21 så händer det
if (level >= 0 && level <= 21)
{
    Console.WriteLine($"Good choise");
}

// om leveln är högre än 21 händer det
if (level > 21)
{
    Console.WriteLine($"Number to high");
}

// om leveln är mindre än 0 händer det 
if (level < 0)
{
    Console.WriteLine($"Number to low");
}


Console.ReadLine();

}