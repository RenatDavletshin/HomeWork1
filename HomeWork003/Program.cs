//Напишите программу, которая на вход принимает число и выдает, является ли число четным.
Console.WriteLine("Введите число: ");
if(int.Parse(Console.ReadLine()) % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}