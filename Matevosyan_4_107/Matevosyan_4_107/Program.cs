
Console.WriteLine("Введите номер масти карты (1-пики, 2-крести, 3-бубни, 4-черви ");
int cardNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер значения карты");
int cardMeaning = int.Parse(Console.ReadLine());

switch (cardMeaning)
{
    case 6:
        Console.WriteLine("Шестерка");
        break;
    case 7:
        Console.WriteLine("Семерка");
        break;
    case 8:
        Console.WriteLine("Восьмерка");
        break;
    case 9:
        Console.WriteLine("Девятка");
        break;
    case 10:
        Console.WriteLine("Десятка");
        break;
    case 11:
        Console.WriteLine("Валет");
        break;
    case 12:
        Console.WriteLine("Дама");
        break;
    case 13:
        Console.WriteLine("Король");
        break;
    case 14:
        Console.WriteLine("Туз");
        break;
}
switch (cardNumber)
{
    case 1:
        Console.WriteLine(" пики");
        break;
    case 2:
        Console.WriteLine(" крести");
        break;
    case 3:
        Console.WriteLine(" бубни");
        break;
    case 4:
        Console.WriteLine(" червей");
        break;
}