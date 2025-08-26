/* string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result); */

/* string input = "Pad this";
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-')); */

/* string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

string test1 = "12345";
string test2 = "567788";

Console.WriteLine(test1.PadLeft(10));
Console.WriteLine(test2.PadLeft(10)); */

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine();
Console.WriteLine($"Currently, you own {currentShares:D2} at a return value of {currentReturn:P2}");


// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);
