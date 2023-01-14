Console.Clear();
int count = 10;
int [] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;
System.Console.Write("Ищем: ");
System.Console.WriteLine(find);
System.Console.WriteLine("Массив: ");

while (index < count)
{
    array[index] = new Random().Next(1, 21);
    System.Console.Write(array[index]+ " ");
    index+=1;
}

index = 0;
bool flag = false;
while (index < count)
{
    if (array[index] == find)
    {
        flag = true;
    }
    index+=1;
}


if (flag)
{
        Console.Write("\nТакой элемент есть!");
}
else
{
Console.Write("\nТакого элемента нет!");
}
Console.WriteLine("\nEnd");