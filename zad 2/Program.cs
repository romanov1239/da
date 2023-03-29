Console.Clear();
Console.WriteLine("a:");
int a = int.Parse (Console.ReadLine());
Console.WriteLine("b:");
int b = int.Parse (Console.ReadLine());

int max = a;
int min = a;
if ( b > max )
{
   max = b;
   min = a;
}
else
{
  min = b;
   max = a;  
}
Console.WriteLine ($"max = {max}, min = {min}");
