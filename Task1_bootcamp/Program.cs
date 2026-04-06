
string input = Console.ReadLine();
int userInput = int.Parse(input);

for (int i = 1; i <= userInput; i++)
{
    if (i % 3 == 0)
    {
        Console.Write("foo,");
    }
    else if (i % 5 == 0)
    {
        Console.Write("bar,");
    }
    if (i % 3 == 0 && i % 5 == 0 )
    {
        Console.Write("foobar,");
    }
    else
    {
        Console.Write( i + ",");
    }
}