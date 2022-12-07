Console.WriteLine("введите пятизначное число");

string number = Console.ReadLine();
int num;
bool success = int.TryParse(number, out num);
if (success == false)
Console.WriteLine("это не число");
else
    if (number.Length<5 || number.Length>5)
    Console.WriteLine("цисло не пятизначное");
    else
        if (number[0]==number[4] && number[1]==number[3])
        Console.WriteLine("да");
        else
        Console.WriteLine("нет");