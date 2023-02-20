// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your max number!");
int maxCount = Convert.ToInt32(Console.ReadLine());
for (var counter = 1; counter <= maxCount; counter++)
{
    List<string> result = new List<string>();

    if (counter % 3 == 0)
    {
        result.Add("FIZZ");
    }
    if (counter % 13 == 0)
    {
        result.Add("FEZZ");
    }
    if (counter % 5 == 0)
    {
        result.Add("BUZZ");
    }
    if (counter % 7 == 0)
    {
        result.Add("BANG");
    }
    if (counter % 11 == 0)
    {
        result.Add("BONG");
    }
    if (counter % 17 == 0)
    {
        result.Reverse();
    }
    if (result.Count == 0)
    {
        Console.Write(counter);
    }
    Console.WriteLine(string.Join("", result));

}

