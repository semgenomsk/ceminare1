Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = -numberA;
while (numberB <= numberA)
{
    Console.Write(numberB + " ");
    numberB++;
}