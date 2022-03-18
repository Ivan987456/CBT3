int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int i;
for (i = 0; i < a; i++)
{
    a -= b;
}
Console.WriteLine("Частное: " + i + "\nОстаток:" + a);