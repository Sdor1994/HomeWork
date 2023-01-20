int Number = new Random().Next(10, 100);

int Max = 0;

int One = Number / 10;
int Two = Number % 10;
if (One > Two) Max = One;
else Max = Two;
System.Console.WriteLine("В числе " + ( Number ) + " наибольшая цифра " + (Max));