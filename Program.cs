const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
const string openSpan = "<span>";
const string closeSpan = "</span>";
int openSpanStart = input.IndexOf(openSpan);
int openSpanEnd = openSpanStart + openSpan.Length;
int closeSpanStart = input.IndexOf(closeSpan);
int subStringLength = closeSpanStart - openSpanEnd;

// value between <span> and </span>
string quantity = input.Substring(openSpanEnd, subStringLength);
// set to value of input, then remove <div> and </div>
string output = input;
output = output.Replace("<div>", "");
output = output.Replace("</div>", "");
output = output.Replace("&trade;", "&reg;");

// Replace (&trade;) with (&reg;) (HTML Characters)


// Should look like:
// Quantity: 5000
// Output: <h2>Widgets &reg;</h2><span>5000</span>

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");