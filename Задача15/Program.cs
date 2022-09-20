// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число: ");
string DayOfTheWeek(int Day)
{
    if ((Day == 6) || (Day == 7))
    {
        return "да";
    }
    else if ((Day == 1)||(Day == 2)||(Day == 3)||(Day == 4)||(Day == 5))
    {
        return "нет";
    }
    else
    {
        return "Некорректно введенное число";
    }
}
int InputNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DayOfTheWeek(InputNumber));