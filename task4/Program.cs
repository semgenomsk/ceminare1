Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int count = number % 10;
    Console.WriteLine(count); 
}
else
{
    Console.WriteLine("Введено не трехзначное число!");
}