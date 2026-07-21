using System.Runtime.CompilerServices;

double largura = 0;
double comprimento = 0;
double valor = 1500;
double area = 0;
double preco = 0;
string nome;
double telefone;
string email;

Console.WriteLine("Digite o nome do cliente:"); 
nome = Console.ReadLine();

Console.WriteLine("Digite o email: ");
email = Console.ReadLine();

Console.WriteLine("Digite o telefone: ");
telefone = double.Parse(Console.ReadLine());



Console.WriteLine("Digite a largura do terreno em metros:");
largura = double.Parse(Console.ReadLine());

Console.WriteLine("""Digite o comprimento do terreno em metros:""");
comprimento = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do metro quadrado:");
valor = double.Parse(Console.ReadLine());

area = largura * comprimento;

preco = area * valor;

Console.WriteLine($"""
    ==================================================================
    =                                                                
    = Cliente : {nome}, Telefone :{telefone}, Email :{email}         
    =                                                                
    =,Area do imovel  é :{area}, o valor toltal é {preco}            
    =                                                                
    ==================================================================
    """);

