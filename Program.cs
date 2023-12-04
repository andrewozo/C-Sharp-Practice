// See https://aka.ms/new-console-template for more information

// string? readResult;
// bool validEntry = false;
// int numValue = 0;

// Console.WriteLine("Enter a number between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     bool isNum = int.TryParse(readResult, out numValue);
//     if (readResult != null)
//     {
//         if (isNum)
//         {
//             if ((numValue >= 5) && (numValue <= 10))
//             {
//                 validEntry = true;
//             }
//             else
//             {
//                 Console.WriteLine($"You Entered {numValue} please enter a number between 5 and 10");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Sorry you entered an invalid number please try again");
//         }
//     }
// } while (validEntry == false);

// Console.WriteLine($"Your input ({numValue}) has been accepted");


// string? readResult;
// bool validEntry = false;

// Console.WriteLine("Enter your role name (administrator, manager, or user)");

// while (validEntry == false)
// {
//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         if ((readResult == "administrator") || (readResult == "manager") || (readResult == "user"))
//         {
//             validEntry = true;
//             Console.WriteLine($"Your input value ({readResult}) has been accepted");
//         }
//         else
//         {
//             Console.WriteLine(
//                 $"The role name that you entered, '{readResult}' is not valid. Enter your role name (administrator, manager, or user)"
//             );
//         }
//     }
// }

string[] myStrings = new string[2]
{
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices"
};
string myString = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence + "!");
}
