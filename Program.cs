Console.Write("Bir tam sayı girin: ");
int n = int.Parse(Console.ReadLine());

bool powerTwo = false;
if (n>0)
{
    if ((n&(n-1))==0)
    {
        powerTwo = true;
    }
}
if (powerTwo)
{
    Console.WriteLine("2 nin quvvetidir");
}
else
{
    Console.WriteLine("2 nin quvveti deyil");
}


