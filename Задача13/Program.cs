// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");

int GetNumberThree(int Number)
{
    int count = 0; 
    int divisible = Number;
    while (divisible > 0)
    {
        divisible = divisible/10;
        count++;
    }
    return Number/Convert.ToInt32(Math.Pow(10,(count-3)))%10;
}

int InputNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (InputNumber/100 == 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(GetNumberThree(InputNumber));
}    
