Console.WriteLine("Введите положительное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = -numberA;
while (numberB <= numberA)
{
    Console.Write(numberB + " ");
    numberB++;
}
if (numberA < 0)
{
    Console.WriteLine("число должно быть положительным!");
}