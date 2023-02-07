// Third digit - 645:5, 78:Error, 32679:6
Console.Clear();
Console.WriteLine("Enter a Number:");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;

while (b > 999)
    b = b / 10;

if (a < 99)
    Console.WriteLine("None");
else
    Console.WriteLine(b%10);