var numbers = new int[] { 1, 2, 3, 4, 5 };

// Console.WriteLine(numbers[5]); // will throw a System.IndexOutOfRangeException because the array has only 4 indeces

// try-catch block

try
{
    Console.WriteLine(numbers[5]); // will now put our code in a try block
}
catch (IndexOutOfRangeException e)
{
    // If we throw an exception do...
    Console.WriteLine($"That was not an index that exists. {e.Message}"); // message to user before moving on with code
}
catch (Exception e) // an umbrella catch for if there's an error you didn't anticipate, catches all exceptions
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("Continue on..."); // line to show that the try-catch prevents the code from breaking. We throw the exception, execute the catch block and continue on



try
{
    Console.WriteLine("Please enter a number:");
    var userInput = int.Parse(Console.ReadLine());
    Console.WriteLine(userInput);
}
catch (FormatException e)
{
    Console.WriteLine($"Failed to Parse. {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    // optional
    // happens no matter what
    Console.WriteLine("Finally block");
}

Console.WriteLine("Continue on...");

// make a list of strings in number format

var strNumbers = new string[] { "12", "2", "twelve", "ten", "thirty", "33", "four", "9" };

var realNumbers = new List<int>();

foreach (var strNumber in strNumbers)
{
    try
    {
        var parseNumber = int.Parse(strNumber);
        realNumbers.Add(parseNumber);
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Could not parse {strNumber}. {e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Parsed numbers:");

foreach (var number in realNumbers)
{
    Console.WriteLine(number);
}