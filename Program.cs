Console.Clear();

int adultosComAlcool, adultosSemAlcool, crianças;
double carne, acompanhamentos, cerveja, refrigerante, agua;


Console.WriteLine("-----------------Churrasco do Menezes--------------");
Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
adultosComAlcool = Convert.ToInt16(Console.ReadLine()!);

Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
adultosSemAlcool =  Convert.ToInt16(Console.ReadLine()!);

Console.Write("Crianças........................................: ");
crianças =  Convert.ToInt16(Console.ReadLine()!);



carne = ((adultosComAlcool + adultosSemAlcool) * 0.4 ) + (crianças * 0.2);
acompanhamentos = ((adultosComAlcool + adultosSemAlcool) * 0.2) + (crianças * 0.2);
cerveja = adultosComAlcool * 2;
refrigerante =  (adultosSemAlcool * 0.5) + (crianças * 0.5);
agua = ((adultosComAlcool + adultosSemAlcool) * 0.4) + (crianças * 0.4);

Console.WriteLine("");

Console.WriteLine($"Carne.......................: {carne:F1}Kg");
Console.WriteLine($"Acompanhamentos.............: {acompanhamentos:F1}Kg");
Console.WriteLine($"cerveja.....................: {cerveja:F1}l");
Console.WriteLine($"Refrigerante................: {refrigerante:F1}l");
Console.WriteLine($"Água........................: {agua:F1}l");

