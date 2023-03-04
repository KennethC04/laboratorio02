//  PRACTICA EN LABORATORIO 4 
Console.WriteLine("Ejercicio 1: Operaciones aritmeticas ");

double n1d, n2d;
Console.Write("Ingrese un numero: "); // 5
int n1 = Convert.ToInt32(Console.ReadLine()); //3

Console.Write("Ingrese otro numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int suma = n1 + n2;
Console.WriteLine( n1 + n2  + suma );
n1d = n1;
n2d = n2;

int mod;
int div;
double multiplicacion, division;

// ejercicio 2 operaciones booleanas
Console.WriteLine("Ejercicio 2: Operaciones Booleanas");

bool mayorQue = n1 > n2;
bool menorQue = n1 < n2;
bool igualQue = n1 == n2;
string valorBooleano = "";
string valorBooleano2 = "";
string valorBooleano3 = "";

// PROGRAMA  1
if (mayorQue)
{
    valorBooleano = "Verdadero";
}
else
{
    valorBooleano = "Falso";
}
// PROGRAMA 2
if (menorQue)
{
    valorBooleano2 = "Verdadero";
}
else
{
    valorBooleano2 = "Falso";
}

//PROGRAMA 3

if (igualQue)
{
    valorBooleano3 = "Verdadero";
}
else
{
    valorBooleano3 = "Falso";
}

Console.WriteLine("es " + n1 + " mayor que " + n2 + " ? R// " + valorBooleano);
Console.WriteLine("es " + n1 + " menor que " + n2 + " ? R// " + valorBooleano2);
Console.WriteLine("es " + n1 + " igual que " + n2 + " ? R// " + valorBooleano3);

// EJERCICIO 3

Console.WriteLine("");
Console.WriteLine("Ejercicio 3: Jerarquia de operaciones");

int a;
int b;
int c;

Console.WriteLine("Ingrese el primer numero a operar");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero a operar");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer numero a operar");
c = int.Parse(Console.ReadLine());

double aDouble = a;
double bDouble = b;
double cDouble = c;

int primeraOperacion = (a * b) + c;
int segundaOperacion = (b + c) * a;
double terceraOperacion = aDouble / (bDouble * cDouble);
double cuartaOperacion = ((3 * aDouble) + (2 * bDouble)) / Math.Pow(cDouble, 2);

Console.WriteLine("a * b + c = " + primeraOperacion);
Console.WriteLine("a * (b + c) = " + segundaOperacion);
Console.WriteLine("a / b * c = " + terceraOperacion);
Console.WriteLine("3*a + 2*b / C^2 = " + cuartaOperacion);

//EJERCICIO 3
Console.WriteLine("Ejercicio 3: Jerarquía de operaciones");

// PERMITIR AL USUARIO INGRESAR 3 NUMEROS 
Console.Write("Ingresa una vairable para a: ");
double aa = double.Parse(Console.ReadLine());
Console.Write("Ingresa una variable para b: ");
double bb = double.Parse(Console.ReadLine());
Console.Write("Ingrese una variable para c: ");
double cc = double.Parse(Console.ReadLine());

Console.WriteLine("a * b + c = " + (a * b + c));
Console.WriteLine("a * (b + c) = " + (a * (b + c)));
Console.WriteLine("a / b * c = " + (a / b * c));
Console.WriteLine("3a + 2b / c^2 = " + (3 * a + 2 * b / Math.Pow(c, 2)));
