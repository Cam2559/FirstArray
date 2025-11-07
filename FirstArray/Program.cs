string apartments = "A105,B308,C555,B432,B222,A006";
string[] aptNums = apartments.Split(',', StringSplitOptions.RemoveEmptyEntries);
Array.Sort(aptNums);

Console.WriteLine("HalfBlood Aparment Complex\n");

foreach (var apt in aptNums)
{
    if (apt == "C555")
    {
        Console.WriteLine($"{apt}\t\tMaintenance");
    }
    else
    {
        Console.WriteLine($"{apt}\t\tResident");
    }
};


