using System.Collections;
using System.Security.Cryptography.X509Certificates;
using TransportArend.Classes;


bool trigger = true;
int cycle = 0;

Car lada = new Car("Лада Калина", "Черный", 150);
Car mercedes = new Car("Мерседес Бенз", "Голубой", 200);
Car volkswagen = new Car("Фольцваген поло", "Белый", 150);

Bicycle stels = new Bicycle("Stels Scout", "Зеленый");
Bicycle victory = new Bicycle("Победа", "Серый");

Bike yamaha = new Bike("M330", "Красный", 160);
Bike ural = new Bike("Урал", "Желтый", 130);
Bike kayo = new Bike("KAYO 4420", "Белый", 200);

Boat stalker = new Boat("Сталкер", 50);
Boat neman = new Boat("Неман 340", 60);

Scooter explore = new Scooter("Explore", "Рыжий");
Scooter techteam = new Scooter("TechTeam Duker", "Хаки");

List<Transport> transports = new List<Transport>() 
    { 
        lada, mercedes, volkswagen, stels, victory,
        yamaha, ural, kayo, explore, stalker, neman,
        techteam
    };

do
{
    if(cycle == 0)
    {
        Console.WriteLine("Список доступных авто:");
        PrintList(SortList());
        cycle++;
    }

    Console.WriteLine("Выберите транспорт");
    int choiceTransport = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine($"Вы хотите арендовать {SortList()[choiceTransport].Model}?");
    string yesNo = Console.ReadLine();
    switch(yesNo)
    {
        case "Да":
            SortList()[choiceTransport].Arend(); break;
        case "Нет":
            break;
    }
} while (trigger);

List<Transport> SortList()
{
    List<Transport> sortedList = new List<Transport>();
    for (int i = 0; i < 5; i++)
    {
        foreach (Transport transport in transports)
        {
            if (i == transport.GetClass())
            {
                sortedList.Add(transport);
            }
        }
    }
    return sortedList;
}

void PrintList(List<Transport> list)
{
    int i = 1;
    foreach(Transport transport in list)
    {
        Console.Write(i + ". ");
        transport.Print();
        Console.WriteLine();
        i++;
    }
}

