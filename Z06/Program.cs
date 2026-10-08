

//Zadanie 6


Console.WriteLine("Jak nazywa się bohater?");
string name = Console.ReadLine();
Console.WriteLine("Ile bohater ma aktualnych punktów życia? (0-100)");
int hp = int.Parse(Console.ReadLine());

const int maxhp = 100;
double hpPercent = (double)hp / maxhp * 100;


Console.WriteLine("Ile obrażen zadaje podstawowo bohater?");
int damage = int.Parse(Console.ReadLine());
Console.WriteLine("Jaki bonus do obrażeń daje jego broń?");
int bonus = int.Parse(Console.ReadLine());
Console.WriteLine("Jaki jest mnożnik ataku krytycznego twojego bohatera?");
double crit = double.Parse(Console.ReadLine());

int attack = damage + bonus;
int critattack = (int)(attack * crit);


Console.WriteLine("Czy twój bohater ma mapę? (true/false)");
bool map = bool.Parse(Console.ReadLine());
int mapv = map ? 1 : 0;
Console.WriteLine("Czy twój bohater ma pochodnię? (true/false)");
bool torch = bool.Parse(Console.ReadLine());
int torchv = torch ? 1 : 0;
Console.WriteLine("Ile twój bohater posiada mikstur? (0-3)");
int pot = int.Parse(Console.ReadLine());

int gold = pot * 5 + mapv * 10 + torchv * 12;
int inv = mapv + torchv + pot;


bool alive = hp > 0;
bool full = hp == maxhp;
bool freeslots = inv < 5;

Console.WriteLine("+==========================================+");
Console.WriteLine("|             KARTA BOHATERA               |");
Console.WriteLine("+==========================================+");
Console.WriteLine($" Bohater: {name}");
Console.WriteLine("+==========================================+");
Console.WriteLine($" Zdrowie: {hp}/{maxhp} ({hpPercent})");
Console.WriteLine($" Siła: {damage}");
Console.WriteLine($" Bonus od broni: {bonus}");
Console.WriteLine($" Zwykłe obrażenia: {attack}");
Console.WriteLine($" Mnożnik ataku krytycznego: {crit}");
Console.WriteLine($" Obrażenia ataku krytycznego: {attack * crit}");
Console.WriteLine("+==========================================+");
Console.WriteLine($" Ekwipunek: {inv}/5");
Console.WriteLine($" Mapa: {map}");
Console.WriteLine($" Pochodnia: {torch}");
Console.WriteLine($" Wartość ekwipunku: {gold}");
Console.WriteLine("+==========================================+");
Console.WriteLine($" Żyje: {alive}");
Console.WriteLine($" Ma pełne zdrowie: {full}");
Console.WriteLine($" Potrzebuje leczenia: {!full}");
Console.WriteLine($" Ma wolne miejsca w ekwipunku: {freeslots}");
Console.WriteLine("+==========================================+");