Console.WriteLine("Enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numberC");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if (numberB > max)  max = numberB;
if (numberC > numberB) max = numberC;

Console.WriteLine(max);
