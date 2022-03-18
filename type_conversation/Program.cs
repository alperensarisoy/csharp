// See https://aka.ms/new-console-template for more information

//Bilinçsiz Dönüşüm
Console.WriteLine("******Bilinçsiz Dönüşüm****** ");
short a=5;
byte b=10;
sbyte c=29;

int x = a+b+c;

Console.WriteLine("x: "+x);

long h = x+1;

Console.WriteLine("h: "+h);

float i = h+1;

Console.WriteLine("i: "+i);

string e = "alperen";

char f = 'k';


//Bilinçli Dönüşüm

Console.WriteLine("******Bilinçli Dönüşüm****** ");
int j=4;
byte y = (byte)j;

Console.WriteLine("y: "+y);