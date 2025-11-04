using Imc.Models;

Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona.\n");

Console.Write("Proporcione su peso en kilogramos: ");
decimal peso = decimal.Parse(Console.ReadLine());

Console.Write("Proporcione su estatura en metros: ");
decimal estatura = decimal.Parse(Console.ReadLine());

decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);

Console.WriteLine($"El indice de masa corporal de la persona es {imc:F2}");
Console.WriteLine($"El estado nutricional de la persona es {CalculadoraImc.SituacionNutricional(imc)}");

