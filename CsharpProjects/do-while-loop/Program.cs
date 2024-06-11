// Random random = new Random();
// int attack = random.Next(1, 11);
// int heroHealth = 10;
// int monsterHealth = 10;

// do
// {
//     attack = random.Next(1, 11);
//     int health = monsterHealth - attack;
//     Console.WriteLine("The hero attacks first.");
//     Console.WriteLine($"The monster lost {health} health points. The monster has {attack} health points remaining.");
    
    
//     int attack1 = attack > 0 ? attack = random.Next(1, 11) : 0 ;

//     int heroHealth1 =heroHealth - attack1;    
//     Console.WriteLine($"The hero lost {heroHealth1} health points. The hero has {attack1} health points remaining.");
// } 
// while (attack != 10);
// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();
    

//  Console.WriteLine("Enter your Level: ");
//         int level = Convert.ToInt32(Console.ReadLine());

//         var userType = (readResult.Contains("Admin")) ?
//             ((level > 55) ? "Super Admin user" : "Admin user") : 
//                 (readResult.Contains("Manager")) ?((level >= 20) ? 
//                     "Contact an Admin for access" : "You do not have sufficient privileges") : "You do not have sufficient privileges" ;




    // Console.WriteLine($"Welcome, {userType}.");


