Console.WriteLine("Enter a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)  max = b;
if (c > b) max = c;

Console.WriteLine(max);