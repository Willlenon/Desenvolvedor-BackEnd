int a;
int b;
int c;
bool a1;
Console.WriteLine("Digite o primeiro valor");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor");
c = int.Parse(Console.ReadLine());

a1 = a == b;

Console.WriteLine(a == b ? "Verdadeiro" : "Falso");

Console.WriteLine(a != b ? "Verdadeiro" : "Falso");

Console.WriteLine(b > a ? "Verdadeiro" : "Falso");

Console.WriteLine(b <= c ? "Verdadeiro" : "Falso");

Console.WriteLine(a == b &b> c ? "Verdadeiro" : "Falso");

Console.WriteLine(a != b || b >= c ? "Verdadeiro" : "Falso");

Console.WriteLine( !a1  ? "Verdadeiro" : "Falso");