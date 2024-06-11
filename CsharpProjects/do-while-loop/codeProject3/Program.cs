string[] myStrings = new string[2] { "I like pizza. I like roast chicken I like salad.", "I like all three of the menu choices" };
int end = myStrings.Length;
int start = end/2;
Console.WriteLine();
Console.WriteLine("All occurrences of '.' from position {0} to {1}.", start, end-1);
Console.WriteLine("{1}{0}{2}{0}{3}{0}", Environment.NewLine);
Console.Write("The string '.' occurs at position(s): ");

int count = 0;
int at = 0;
while((start <= end) && (at > -1))
{
    // start+count must be a position within -str-.
    count = end - start;
    at = myStrings.IndexOf(".", start, count);
    if (at == -1) break;
    Console.Write("{0} ", at);
    start = at+1;
}
Console.WriteLine();






// foreach (string i in myStrings){
//     string myString = i;
//     Console.WriteLine(i);
   
//     int periodLocation = myString.IndexOf(".");
//     Console.WriteLine(myString.IndexOf("."));
// }
