// Exploring data type casting and conversion
// int first = 2;
// string second = "4";
// string result = $"The first number: {first}\n"+ $"The second number: {second}";
// Console.WriteLine(result);


// Narrowing conversion means that you're attempting to convert a value from a data type that can hold more information to a data type that can hold less information.
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");