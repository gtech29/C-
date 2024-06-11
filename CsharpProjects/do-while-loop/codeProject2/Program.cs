string? readResult;
bool validEntry = false;
Console.WriteLine("Enter user type (Administrator, Manager, or User):");
readResult = Console.ReadLine().Trim();

while (readResult != null)
{

    
    if (readResult == "Admin")
    {
        Console.WriteLine($"The role name {readResult} is not valid. ");
        Console.WriteLine("Enter user type (Administrator, Manager, or User):");
        readResult = Console.ReadLine().Trim();

        if (readResult != "Admin")
        {
            Console.WriteLine($"Your input {readResult} has been accepted ");
            break;
        }
    }
    else {
        Console.WriteLine($"Your input {readResult} has been accepted ");
            break;
    }
}