

//Zadanie 5


Console.WriteLine("Jak bohater ma na imię?");
string name = Console.ReadLine();
Console.WriteLine("Ile bohater ma maksymalnych punktów życia? (0-100)");
int maxHp = int.Parse(Console.ReadLine());
Console.WriteLine("Ile bohater ma aktualnych punktów życia? (0-100)");
int Hp = int.Parse(Console.ReadLine());
Console.WriteLine("Ile podstawowych obrażeń zadaje jego broń?");
int Damage = int.Parse(Console.ReadLine());
Console.WriteLine("Jaka jest premia do siły bohatera?");
int Bonus = int.Parse(Console.ReadLine());
Console.WriteLine("Jaki jest mnożnik obrażeń bohatera?");
double Crit = double.Parse(Console.ReadLine());
Console.WriteLine("Ile wykonał zwykłych ataków?");
int Attacks = int.Parse(Console.ReadLine());


int DamageBonus = Damage + Bonus;
int CritDmg = (int)(DamageBonus * Crit);
int totalDamage = (DamageBonus * Attacks) + CritDmg;
double HpPercent = (double)Hp / maxHp * 100;
bool alive = Hp > 0;
bool fullHp = Hp == maxHp;


Console.WriteLine("========== RAPORT Z WALKI ==========");
Console.WriteLine($"Bohater: {name}");
Console.WriteLine($"Zdrowie: {Hp / maxHp} ({HpPercent}%)");
Console.WriteLine($"Zwykły atak:{Damage + Bonus}");
Console.WriteLine($"Atak specjalny: {DamageBonus * Crit}");
Console.WriteLine($"Zadane obrażenia: {totalDamage}");
Console.WriteLine($"Żyje: {alive}");
Console.WriteLine($"Ma pełne zdrowie: {fullHp}");
Console.WriteLine("=====================================");