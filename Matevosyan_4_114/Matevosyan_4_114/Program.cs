Console.WriteLine("Введите год: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер месяца: ");
int mounthNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите день: ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine($"Дата предыдущего дня: {day - 1}.{mounthNumber}.{year}");
Console.WriteLine($"Дата следующего дня: {day + 1}.{mounthNumber}.{year}");
if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год не високосный");
}