

//Zadanie 3


Console.WriteLine("Ile masz racji żywnościowych?");
int food = int.Parse(Console.ReadLine());
Console.WriteLine("Ilu jest członków twojej drużyny?");
int members = int.Parse(Console.ReadLine());
Console.WriteLine("Ile będzie dni twojej wyprawy?");
int days = int.Parse(Console.ReadLine());

double foodPerDay = food / days;
double foodPerPersonPD = foodPerDay / members;

Console.WriteLine("===================================================================================================");
Console.WriteLine($"Każdy członek drużyny dostanie: {food / members} pełnych racji żywnościowych.");
Console.WriteLine($"Po podziale pozostanie: {food % members % days} racji żywnościowych");
Console.WriteLine($"Twoja drużyna będzie zjadała {foodPerDay} racji dziennie.");
Console.WriteLine($"Jedna osoba będzie zjadała: {foodPerPersonPD} racji dziennie.");