    using static System.Console;
try//tratamento de exceção (ERROS) TRY = TENTE, CATCH = CAPTURAR
{
    int a, b, c;
    double areaQuadrado, areaTriangulo, areaTrapezio;

    WriteLine("Digita o valor de A: ");
    a = int.Parse(Console.ReadLine());

    WriteLine("Digite o valor de B: ");
    b = int.Parse(ReadLine());

    WriteLine("Digite o calor de C: ");
    c = int.Parse(ReadLine());

    areaQuadrado = Math.Pow(a, 2);

    areaTriangulo = (a * b) / 2;

    areaTrapezio = (a + b) * c / 2;


    WriteLine($"AREA DO QUADRADO = {areaQuadrado:f4}:");

    WriteLine($"AREA DO TRIANGULO = {areaTriangulo:f4}");

    WriteLine($"AREA DO TRAPEZIO = {areaTrapezio:f4}");
}
catch (Exception ex)
{
    WriteLine("Digite um valor valido");
}
finally // usado para finalizar o programa, independente de ter dado erro ou não pode ser usado no final do try catch
{
    WriteLine("Encerrando programa");
}