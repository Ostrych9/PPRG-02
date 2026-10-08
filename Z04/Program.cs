

//Zadanie 4


Console.WriteLine("Ile bohater ma punktów życia? (0-100)");
int hp = int.Parse(Console.ReadLine());
Console.WriteLine("Ile bohater ma mikstur leczniczych?");
int potions = int.Parse(Console.ReadLine());
Console.WriteLine("Czy bohater ma klucz? (true/false)");
bool Key = bool.Parse(Console.ReadLine());
Console.WriteLine("Czy bohater ma mapę? (true/false)");
bool Map = bool.Parse(Console.ReadLine());

bool alive = hp > 0;
bool fullHp = hp == 100;
bool haspotions = potions > 0;
bool hasitem = Key || Map;

bool ready = alive && haspotions && hasitem;

Console.WriteLine("===================================================");
Console.WriteLine($"Bohater żyje: {alive}");
Console.WriteLine($"Potrzebuje leczenia: {!fullHp}");
Console.WriteLine($"Ma zaopatrzenie: {haspotions}");
Console.WriteLine($"Ma klucz lub mapę: {hasitem}");
Console.WriteLine($"Jest gotowy do wyprawy: {ready}");
