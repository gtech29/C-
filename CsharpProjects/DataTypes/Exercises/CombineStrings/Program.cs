string[] values = { "12.3", "45", "ABC", "11", "DEF" };
double total = 0;
string message = "";


foreach (string value in values)
{
  if (double.TryParse(value, out double number))
  {
    total += number;
  }
  else
  {
    message += value;
  }


}
Console.WriteLine($"The total is: {total}");
Console.WriteLine($"Message: {message}");