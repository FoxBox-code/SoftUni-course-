SortedDictionary<string, SortedSet<string>> sidesUsers = new SortedDictionary<string, SortedSet<string>>();



string command;

while ((command = Console.ReadLine()) != "Lumpawaroo")
{
    

    if (command.Contains("|"))
    {
        string[] argumment = command.Split(" | ",StringSplitOptions.RemoveEmptyEntries);
        string side = argumment[0];
        string user = argumment[1];

        if (!sidesUsers.Values.Any(n => n.Contains(user)))
        {


            if (!sidesUsers.ContainsKey(side))
            {
                sidesUsers.Add(side, new SortedSet<string>());

            }

            sidesUsers[side].Add(user);
        }
    }
    else
    {
        string[] argumment = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
        string side = argumment[1];
        string user = argumment[0]; 

        foreach (var sideUser in sidesUsers)
        {
            if (sideUser.Value.Contains(user))
            {
                sideUser.Value.Remove(user);
                break;
            }
        }
        if (!sidesUsers.ContainsKey(side))
        {
            sidesUsers.Add(side, new SortedSet<string>());

        }

        sidesUsers[side].Add(user);

        Console.WriteLine($"{user} joins the {side} side!");


        
    }

    
}
var orderByDecending = sidesUsers
        .OrderByDescending(x => x.Value.Count)
        .ToDictionary(s => s.Key, s => s.Value);

foreach (var order in orderByDecending)
{
    if (order.Value.Count > 0)
    {
        Console.WriteLine($"Side: {order.Key}, Members: {order.Value.Count}");

        foreach (var name in order.Value)
        {
            Console.WriteLine($"! {name}");
        }
    }
}

