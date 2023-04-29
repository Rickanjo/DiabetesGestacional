// Faça um programa que receba o valor de glicemia (em mg/dL) e exiba o diagnóstico adequado.
Console.WriteLine("--- Diabetes Gestacional ---\n");

Console.Write("Digite o valor de glicemia (mg/dL)...:");
double glicemia = double.Parse(Console.ReadLine()!);

ConsoleColor corResposta = ConsoleColor.Red;


if (glicemia < 92){
    Console.ForegroundColor = corResposta;
    Console.Write("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}
else if (glicemia >= 92 && glicemia < 126) {
    Console.ForegroundColor = corResposta = ConsoleColor.Yellow ;
    Console.Write("Comapatível com Diabettes Gestacional");
}
else {
    Console.ForegroundColor = corResposta = ConsoleColor.Green;
    Console.Write("Diabetes Mellitus na Gravizez");
    
}
Console.ResetColor();