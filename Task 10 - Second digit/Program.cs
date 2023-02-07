// Second digit - 456:5, 782:8, 918:1
Console.Clear();
Console.WriteLine("Enter a 3-digit number:");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;

if (b > 99 & b < 1000)
{
    b = (a - (a/100*100 + a%10))/10;
    Console.WriteLine($"Second digit is {b}.");
}
    
else
    Console.WriteLine("Not a 3-digit number.");