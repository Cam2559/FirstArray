string apartments = "A105, B308, C555, B432, B222, A006";
string[] splitResult = apartments.Split(',');
Array.Sort(splitResult);

Console.WriteLine("HalfBlood Aparment Complex");

foreach (var aptNums in apartments)
{
    if (apartments == "C55") 
    {
        Console.WriteLine(apartments + "\t\tMaintenance");
    }
    else
    {
        Console.WriteLine(apartments +"\t\tResident");
    }
};


