string input = Console.ReadLine();
int userInput = int.Parse(input);

List<string> result = new List<string>();

for (int x = 1; x <= userInput; x++)
{
    string output = "";

    if (x % 3 == 0)
        output += "foo";
    if (x % 5 == 0)
        output += "bar";
    if (x % 7 == 0)
        output += "jazz";

    if (output == "")
        output = x.ToString();

    result.Add(output);
}

Console.WriteLine(string.Join(", ", result));
