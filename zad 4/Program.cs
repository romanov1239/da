Console.Clear();
Console.WriteLine("a:");
int a = int.Parse (Console.ReadLine());
Console.WriteLine("b:");
int b = int.Parse (Console.ReadLine());
Console.WriteLine("c:");
int c = int.Parse (Console.ReadLine());

int max = a;

if ( b > max )
{
   max = b;
}
if ( c > max )
{
   max = c;
}
Console.WriteLine ($"max = {max}");