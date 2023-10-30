using TransportArend.Classes;

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

void PrintList()
{
    for (int i = 0; i < 5; i++)
    {
        foreach (Transport transport in transports)
        {
            if (i == transport.GetClass())
            {
                transport.Print();
            }
        }
    }
}

PrintList();