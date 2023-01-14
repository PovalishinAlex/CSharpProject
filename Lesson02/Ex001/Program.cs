Console.Clear();
int n = new Random().Next(10, 100); // выводит число в диапазоне от 10 до 99 включительно (полуинтервал) [10; 99)
Console.WriteLine("Привет, User ");
Console.ReadLine();
Console.Write("Загадано число: ");
Console.WriteLine(n);
int a = (n / 10);
int b = (n % 10);
Console.ReadLine();
if (a > b)
{
    Console.WriteLine("Наибольшее число ");
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Наибольшее число ");
    Console.WriteLine(b);
}