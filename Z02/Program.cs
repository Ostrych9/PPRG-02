

//Zadanie 2


int lvl = 20;
int gold = 50;
int enter = 0;

Console.WriteLine("Poziom gracza: " + lvl);
Console.WriteLine("Złoto: " + gold);
Console.WriteLine($"Wejścia na arene: {enter}");

lvl += lvl + 25;
lvl *= 2;
gold -= 8;
gold += 15;
enter = ++enter;

Console.WriteLine("Poziom gracza: " + lvl);
Console.WriteLine("Złoto: " + gold);
Console.WriteLine($"Wejścia na arene: {enter}");