int adultos, crianças, adultosAlcool, adultosSemAlcool, pessoas;
double carne, acompanhamentos,cerveja, agua, refrigerante;

Console.WriteLine("--- Churrasco ---\n");

Console.Write("Adultos (que consomem bebidas alcoolicas)....: ");
adultosAlcool = int.Parse(Console.ReadLine()!);

Console.Write("Adultos (que não consomem bebidas alcoolicas): ");
adultosSemAlcool = int.Parse(Console.ReadLine()!);

Console.Write("Crianças.....................................: ");
crianças = int.Parse(Console.ReadLine()!);

adultos = adultosAlcool + adultosSemAlcool;
pessoas = adultos + crianças;

carne = 0.4 * adultos + 0.2 * crianças;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * adultosAlcool;
refrigerante = 0.5 * (adultosSemAlcool + crianças);
agua = 0.4 * pessoas;

Console.Write("\n");

Console.WriteLine($"Carne..........: {carne:N1} kg");
Console.WriteLine($"Acompanhamentos: {acompanhamentos:N1} kg");
Console.WriteLine($"Cerveja........: {cerveja:n1}l");
Console.WriteLine($"Refrigerante...: {refrigerante:n1}l");
Console.WriteLine($"Agua...........: {agua:n1}l");

