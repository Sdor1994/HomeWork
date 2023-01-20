Console.WriteLine("Первое число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1 == Num2 * Num2) Console.WriteLine((Num1)+" это квадрат "+(Num2));
if (Num2 == Num1 * Num1) Console.WriteLine((Num2)+" это квадрат "+ (Num1));
else Console.WriteLine("Оба не соотностяться");