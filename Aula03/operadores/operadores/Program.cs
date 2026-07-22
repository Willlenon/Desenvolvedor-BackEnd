// operadores relacionais
/* < maior que
 * > menor que
 * <= menor ou igual a
 * >= maior ou igual a
 * == igual a
 * != diferente de



double x = 2.14;
int y = 2;
char a = 'S';
char b = 'N';


Console.WriteLine(a == b);// operador de igualdade
Console.WriteLine(a != b); // operador de diferente
Console.WriteLine(a == b ? "Verdade" : "ok");// operador ternário

if (x < y)// estrutura condicional
{
    Console.WriteLine("sim");
}
else {
    Console.WriteLine("nao");
}
 */

//operadores lógicos
/*
 * ! operador de negação
 * & e logico
 * | ou logico
 * ^ ou exclusivo lógico
 * &&  e logico ou condicional
 * || ou logico ou condicional
 */

bool x = true;
bool y = false;

Console.WriteLine(!x);// operador de negação faz a inversão do valor logico 
Console.WriteLine(x & y);// operador & logico retorna verdadeiro se ambos forem verdadeiros
Console.WriteLine(x && y);// operador && logico ou condicional retorna verdadeiro se ambos forem verdadeiros
Console.WriteLine(x | y);// operador | logico retorna verdadeiro se um dos dois for verdadeiro
Console.WriteLine(x ^ y);// operador ^ ou exclusivo logico retorna verdadeiro se um dos dois for verdadeiro e o outro falso
Console.WriteLine(x || y);// operador || logico ou condicional retorna verdadeiro se um dos dois for verdadeiro