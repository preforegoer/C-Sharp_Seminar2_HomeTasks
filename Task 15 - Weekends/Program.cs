// Weekend - Error if Not 
Console.Clear();
Console.WriteLine("Enter a Number:");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 7 || a == 0)
    Console.WriteLine("1 Week = 7 Days (From 1 to 7).");

else if (a < 6)
    Console.WriteLine("Not a Weekend.");
else
    Console.WriteLine("Weekend.");