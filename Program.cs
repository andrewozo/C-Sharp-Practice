// See https://aka.ms/new-console-template for more information

// decimal price = 123.45m;
// int discount = 50;

// Console.WriteLine($"Price: {price:C} (save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurment: {measurement:N} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax Rate: {tax:P2}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format(
//     "You saved {0:C2} off the regular {1:C2} price. ",
//     (price - salePrice),
//     salePrice
// );

// yourDiscount += $"A discount of {(price - salePrice) / price:P2}";

// Console.WriteLine(yourDiscount);

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"      Sub Total: {subtotal:C}");
// Console.WriteLine($"         Tax Percentage: {taxPercentage:P2}");
// Console.WriteLine($"      Total Billed: {total:C}");

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);
// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine(
    "As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return."
);

Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}");

Console.WriteLine(
    $"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:N}."
);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage =
    $"{currentProduct.PadRight(19)} {currentReturn:P}   {currentProfit:C} \n{newProduct.PadRight(19)} {newReturn:P}   {newProfit:C}";

// Your logic here

Console.WriteLine(comparisonMessage);
