// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");

int GetNumberTwo(int Number)
{
    return (Number/10)%10;
}

int InputNumber = Convert.ToInt32(Console.ReadLine());
if (InputNumber/100 == 0)
{
    Console.WriteLine("Некорректно введенное число");
}
else
{
    Console.WriteLine(Math.Abs(GetNumberTwo(InputNumber)));
}