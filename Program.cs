// See https://aka.ms/new-console-template for more information
// double total = 0;
// double minimumSpend = 30.00;

// double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
// double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// if (TotalMeetsMinimum())
// {
//     total -= 5;
// }

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     // Check if the total meets the minimum
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     // Format the double so only 2 decimal places are displayed
//     return input.ToString().Substring(0, 5);
// }

// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"S{vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd)
// {
//     int rate = 23500;
//     return (int)(rate * usd);
// }

// double VndToUsd(int vnd)
// {
//     double rate = 23500;
//     return vnd / rate;
// }

// string input = "there are snakes at the zoo";
// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseWord(string word)
// {
//     string result = "";

//     for (int i = word.Length - 1; i >= 0; i--)
//     {
//         result += word[i];
//     }

//     return result;
// }

// string ReverseSentence(string word)
// {
//     string result = "";

//     string[] wordArr = word.Split(" ");

//     for (int i = 0; i < wordArr.Length; i++)
//     {
//         for (int j = wordArr[i].Length - 1; j >= 0; j--)
//         {
//             result += wordArr[i][j];
//         }
//         result += " ";
//     }

//     return result;
// }


// string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words)
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(String word)
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end)
//     {
//         if (word[start] != word[end])
//         {
//             return false;
//         }

//         start++;
//         end--;
//     }

//     return true;
// }


// int target = 80;
// int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0)
// {
//     Console.WriteLine("No Two coins make change");
// }
// else
// {
//     Console.WriteLine($"Change found at positions");
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         if (result[i, 0] == -1)
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
//         }
//     }
// }

// int[,] TwoCoins(int[] coins, int target)
// {
//     int[,] result =
//     {
//         { -1, -1 },
//         { -1, -1 },
//         { -1, -1 },
//         { -1, -1 },
//         { -1, -1 }
//     };
//     int count = 0;

//     for (int i = 0; i < coins.Length; i++)
//     {
//         for (int j = i + 1; j < coins.Length; j++)
//         {
//             if (coins[i] + coins[j] == target)
//             {
//                 result[count, 0] = i;
//                 result[count, 1] = j;
//                 count++;
//             }

//             if (count == result.GetLength(0))
//             {
//                 return result;
//             }
//         }
//     }

//     return (count == 0) ? new int[0, 0] : result;
// }


Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);
        { }
        ;

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? readResult = Console.ReadLine();

    if (readResult != null)
    {
        if (readResult.ToLower() == "n")
        {
            return false;
        }
        else if (readResult.ToLower() == "y")
        {
            return true;
        }
    }

    return true;
}

string WinOrLose(int roll, int target)
{
    string result = "";

    if (roll > target)
    {
        result = "You Win!";
    }
    else
    {
        result = "You lose";
    }

    return result;
}
