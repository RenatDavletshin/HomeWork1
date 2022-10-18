//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 2;     //count число even.
if(num < count)
{
    Console.WriteLine("Таких чисел нет!");
}
else
    while(count <= num)
    {
        Console.Write($"{count}");
        count += 2;
    }
Console.WriteLine();    