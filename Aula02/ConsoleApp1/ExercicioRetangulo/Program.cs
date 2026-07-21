

/*
 * area base  = base * altura
 * perimetro = base + altura + base + altura    
 * diagonal = 
 */
double bAse;
double altura;
double area;
double perimetro;
double diagonal;

Console.WriteLine("Digite a base do retangulo :  ");
bAse = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura do retangulo :");
altura = double.Parse(Console.ReadLine());


area = bAse * altura;

perimetro = bAse + altura + bAse + altura;

diagonal = Math.Sqrt(Math.Pow(bAse, 2) + Math.Pow(altura, 2));

Console.WriteLine($" a Area do retangulo é : {area.ToString("f4")}, o perimetro é : {perimetro:f4}, A diagonal é :{diagonal}");
       


