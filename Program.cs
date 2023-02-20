Console.WriteLine("Please enter your number!");

int maxCount = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your choice of numbers from 3,5,7,11,13 & 17 seperated by spaces");
string inputNumbers = Console.ReadLine();
string[] stringNumbers = inputNumbers.Split(' ');
int[] numbers = new int[stringNumbers.Length];

for (int i = 0; i < stringNumbers.Length; i++)
{
    numbers[i] = int.Parse(stringNumbers[i]);
}

Dictionary<int, string> myMap = new Dictionary<int, string>();
myMap.Add(3, "FIZZ");
myMap.Add(5, "BUZZ");
myMap.Add(7, "BANG");
myMap.Add(11, "BONG");
myMap.Add(13, "FEZZ");

for (var counter = 1; counter <= maxCount; counter++)
{
    List<string> result = new List<string>();
    for (var i = 0; i < numbers.Length; i++)
    {
        if (counter % 3 == 0 && numbers[i] == 3)
        {
            result.Add(myMap[3]);
        }
        if (counter % 13 == 0 && numbers[i] == 13)
        {
            result.Add(myMap[13]);
        }
        if (counter % 5 == 0 && numbers[i] == 5)
        {
            result.Add(myMap[5]);
        }
        if (counter % 7 == 0 && numbers[i] == 7)
        {
            result.Add(myMap[7]);
        }
        if (counter % 11 == 0 && numbers[i] == 11)
        {
            result.Add(myMap[11]);
        }
        if (counter % 17 == 0 && numbers[i] == 17)
        {
            result.Reverse();
        }
    }

    if (result.Count == 0)
    {
        Console.Write(counter);
    }
    Console.WriteLine(string.Join("", result));
}