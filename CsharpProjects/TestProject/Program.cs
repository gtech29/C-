// Random random = new();

// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 10;

// if(daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if(daysUntilExpiration == 1)
// {
//     Console.WriteLine($"Your subscription expires within {daysUntilExpiration} day.\nRenew now and save {discountPercentage}%!");
// }
// else if(daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%! ");
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }
////////////////////////////////////////////////////////////////////////////////////////////////////


////////////////////////////////////////////////////////////////////////////////////////////////////

// string[] orders =
// {
// "B123",
// "C234",
// "A345",
// "C15",
// "B177",
// "G3003",
// "C235",
// "B179"
// };

// foreach (string item in orders)
// {
//     if (item.StartsWith("B"))
//     {
//         string fraudOrder = item;
//         Console.WriteLine($"The following orders start with B: {fraudOrder} ");
//     }

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         // }
//         Console.WriteLine("Enter sale amount: ");
//         int saleAmount = 0;

//         int messages = saleAmount > 1000 ? 100 : 50;
//         Console.WriteLine($"Discount: {messages}");
//     }


// write code to display the result of a coin flip
// Random coin = new Random();
// int flip = coin.Next(1,3);
// string ans = flip > 1 ? "tails": "heads";
// Console.WriteLine(ans);

// Exercise - Complete a challenge activity using Boolean expressions
// Console.WriteLine("Enter user type:");
// var permission = Console.ReadLine();

// Console.WriteLine("Enter your Level: ");
// int level = Convert.ToInt32(Console.ReadLine());


// var userType = (permission.Contains("Admin")) ?
//         ((level > 55) ? "Super Admin user" : "Admin user") : 
//             (permission.Contains("Manager")) ?((level >= 20) ? 
//             "Contact an Admin for access" : "You do not have sufficient privileges") : "You do not have sufficient privileges" ;

// Console.WriteLine($"Welcome, {userType}.");


// Complete a challenge activity using variable scope
// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

// foreach (int number in numbers)
// {
// total += number;

// var nums = (number == 42) ? "Set contains 42" : "Never mind!";
// Console.WriteLine(nums);
// }

// Console.WriteLine($"Total: {total}");

