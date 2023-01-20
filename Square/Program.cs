Console.WriteLine("Первое число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1 == Num2 * Num2) Console.WriteLine("Да " + (Num1)+ " это квадрат "+(Num2));
else Console.WriteLine("Нет " + (Num1)+ " это квадрат "+(Num2));