// první řádek slouží, aby program rozpoznal jaký je momentálně měsíc 

MENU: DateTime cas = DateTime.Now;
int CisloMesice = cas.Month;
string[] poleMesicu = { "Prosinec", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec", "Leden"};
Console.WriteLine("Zadej číslo měsíce (1-12)");
int uzivatelMesic = int.Parse(Console.ReadLine());

Console.WriteLine($"Nyní je {poleMesicu[uzivatelMesic - 1]}, předchozí měsíc byl {poleMesicu[uzivatelMesic - 2]}, a přístí je {poleMesicu[uzivatelMesic]}.");
 
//pro pokračovaní xd

Console.WriteLine("chceš pokračovat (Ano/Ne)");
string odpoved = Console.ReadLine();
if (odpoved == "Ano")
{
    goto MENU;
}
else if (odpoved == "Ne")
{
    Console.WriteLine("dobře, měj se hezky toto je konec programu");
}
