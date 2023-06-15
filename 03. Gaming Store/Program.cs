float balance = float.Parse(Console.ReadLine());
float boughtSum = 0;
string game = "";

while ((game = Console.ReadLine()) != "Game Time")
{
    if (game == "OutFall 4")
    {
        if (balance >= 39.99f)
        {
            balance -= 39.99f;
            boughtSum += 39.99f;
            Console.WriteLine("Bought OutFall 4");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "CS: OG")
    {
        if (balance >= 15.99f)
        {
            balance -= 15.99f;
            boughtSum += 15.99f;
            Console.WriteLine("Bought CS: OG");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "Zplinter Zell")
    {
        if (balance >= 19.99f)
        {
            balance -= 19.99f;
            boughtSum += 19.99f;
            Console.WriteLine("Bought Zplinter Zell");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "Honored 2")
    {
        if (balance >= 59.99f)
        {
            balance -= 59.99f;
            boughtSum += 59.99f;
            Console.WriteLine("Bought Honored 2");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "RoverWatch")
    {
        if (balance >= 29.99f)
        {
            balance -= 29.99f;
            boughtSum += 29.99f;
            Console.WriteLine("Bought RoverWatch");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "RoverWatch Origins Edition")
    {
        if (balance >= 39.99f)
        {
            balance -= 39.99f;
            boughtSum += 39.99f;
            Console.WriteLine("Bought RoverWatch Origins Edition");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else
    {
        Console.WriteLine("Not Found");
    }

    if (balance <= 0f)
    {
        Console.WriteLine("Out of money!");
        break;
    }
}

if (balance > 0f)
{
    Console.WriteLine($"Total spent: ${boughtSum:F2}. Remaining: ${balance:F2}");
}