// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;



int s;


Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine()); // первое число
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine()); // второе число

Console.WriteLine("Введите степень скобки");
int q = Convert.ToInt32(Console.ReadLine()); // степень

s = Convert.ToInt32(Math.Pow((x+y), q));
Console.WriteLine($"Ответ: {s}");


Console.WriteLine(" ");


int otvet;
Console.WriteLine("Формула - a^3-3a^2b+3ab^2-b^3");
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

int e = 3;

otvet = Convert.ToInt32(Math.Pow(a-b, e));
Console.WriteLine($"Ответ: {otvet}");


Console.WriteLine(" ");


int otvet1;
Console.WriteLine("Формула - a^3 - 3a^2b + 3ab^2 - b^3");
Console.WriteLine("Введите число a");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b1 = Convert.ToInt32(Console.ReadLine());

int e1 = 3;


otvet1 = Convert.ToInt32(Math.Pow(a1 + b1, e1));

Console.WriteLine($"Ответ: {otvet1}");


Console.WriteLine(" ");


int otvet2;
Console.WriteLine("Формула - (a + b)*(a^2 - ab + b^2)");
Console.WriteLine("Введите число a");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b2 = Convert.ToInt32(Console.ReadLine());

int w2 = 2;

otvet2 = (a2+b2) * (Convert.ToInt32(Math.Pow(a2, w2) - a2*b2 + Convert.ToInt32(Math.Pow(b2, w2))));
    Console.WriteLine($"Ответ: {otvet2}");




Console.WriteLine(" ");


int otvet3;
Console.WriteLine("Формула - (a - b)*(a^2 + ab + b^2)");
Console.WriteLine("Введите число a");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b3 = Convert.ToInt32(Console.ReadLine());

int w3 = 2;


// w - 2, e - 3

otvet3 = (a3 - b3) * (Convert.ToInt32(Math.Pow(a3, w3) + a3 * b3 + Convert.ToInt32(Math.Pow(b3, w3))));
Console.WriteLine($"Ответ: {otvet3}");





Console.WriteLine(" ");


int otvet4;
Console.WriteLine("Формула - (a - b) * (a + b)");
Console.WriteLine("Введите число a");
int a4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b4 = Convert.ToInt32(Console.ReadLine());


// w - 2, e - 3

otvet4 = (a4 - b4) * (a4 + b4);
Console.WriteLine($"Ответ: {otvet4}");




Console.WriteLine(" ");


int otvet5;
Console.WriteLine("Формула - a^2 - 2ab + b^2");
Console.WriteLine("Введите число a");
int a5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b5 = Convert.ToInt32(Console.ReadLine());

int w5 = 2;

// w - 2, e - 3

otvet5 = (Convert.ToInt32(Math.Pow(a5, w5) - w5 * a5 * b5 + Convert.ToInt32(Math.Pow(b5, w5))));
Console.WriteLine($"Ответ: {otvet5}");






Console.WriteLine(" ");


int otvet6;
Console.WriteLine("Формула - a^2 + 2ab + b^2");
Console.WriteLine("Введите число a");
int a6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b6 = Convert.ToInt32(Console.ReadLine());

int w6 = 2;


// w - 2, e - 3

otvet6 = (Convert.ToInt32(Math.Pow(a6, w6) + w6 * a6 * b6 + Convert.ToInt32(Math.Pow(b6, w6))));
Console.WriteLine($"Ответ: {otvet6}");


Console.WriteLine(" ");
Console.WriteLine("Задание на 4");


long otvet7;
Console.WriteLine("Формула - ((a^2 - 4bc)/(a - a^0.5 - a^c) - (abc)^3)/(a^2 - 2ab + b^2)");
Console.WriteLine("Введите число a");
int a7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите с");
int c = Convert.ToInt32(Console.ReadLine());

long t1 = Convert.ToInt32((Math.Pow(a7, 2)));
long t2 = Convert.ToInt32((a7 - Convert.ToInt32((Math.Pow(a7, 0.5) - Convert.ToInt32((Math.Pow(a7, c)))))));
long t3 = Convert.ToInt32((Math.Pow(a7 * b7 * c, 0.5)));
long t4 = Convert.ToInt32(Math.Pow(a7, 2) - 2 * a7 * b7 + Convert.ToInt32(Math.Pow(b7, 2)));

if (t2 == 0 || t4 == 0)
{ Console.WriteLine("На ноль делить нельзя, введите другие числа"); }

else {
    otvet7 = (t1 / t2 - t3) / t4;
    Console.WriteLine($"Ответ: {otvet7}");
}




Console.WriteLine("Задание на 5");
Console.WriteLine("Формула - I (N + i=1) ");

int N;
int I = 0;
int I1 = Convert.ToInt32(Console.ReadLine()); // количество букв в сообщении

int G = 0;

int log = I1 * Convert.ToInt32((Math.Log2(1 / I1)));

do
{
    Console.WriteLine(G);

    I++;

    G = G + I1;

}

while (I < I1);




