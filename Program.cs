// See https://aka.ms/new-console-template for more information

// string message = "What is the value <span>between the tags</span>";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;

// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(what if) I am (only interested) in the last (set of parantheses)?";

// while (true)
// {
//     int openingPosition = message.IndexOf("(");

//     if (openingPosition == -1)
//         break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(")");
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     message = message.Substring(closingPosition + 1);
// }




// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");

// char[] openSymbols = { '[', '{', '(' };
// int startingPosition = 6;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found without using startingPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startingPosition);
// Console.WriteLine(
//     $"Found WITH using startingPostion: {startingPosition}: {message.Substring(openingPosition)}"
// );


// string message =
//     "(What if) I have [different symbols] but every {open symbol} needs [matching closing symbol]?";

// char[] openSymbols = { '[', '{', '(' };

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1)
//         break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;

//         case "{":
//             matchingSymbol = '}';
//             break;

//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }


// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);




const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string openSpan = "<span>";
const string closingSpan = "</span>";
const string openDiv = "<div>";
const string closeDiv = "</div>";

int quantityStart = input.IndexOf(openSpan);
int quantityEnd = input.IndexOf(closingSpan);

int divStart = input.IndexOf(openDiv);
int divEnd = input.IndexOf(closeDiv);

quantityStart += openSpan.Length;
divStart += openDiv.Length;

int quantLength = quantityEnd - quantityStart;
int divLength = divEnd - divStart;

quantity = input.Substring(quantityStart, quantLength);
output = input.Substring(divStart, divLength);

output = output.Replace("trade", "reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
