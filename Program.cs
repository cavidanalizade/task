int n = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 1; i <= n/2; i++)
{
    if (n % i == 0)
    {
        count++;
    }
}
if (count == 1)
{
    Console.WriteLine( "sade ededdir");
}
else
{
    Console.WriteLine("Murekkeb ededdir");
}
