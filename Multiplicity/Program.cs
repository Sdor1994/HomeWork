Console.WriteLine("Введите число:");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число:");
int Number2 = Convert.ToInt32(Console.ReadLine());
int result = 0;

int MultipleNumber()
{
    result = Number1 % Number2;
    return result;
}

MultipleNumber();

if (result == 0) System.Console.WriteLine("Число" +(Number1)+ " кратно числу " + (Number2));
else
{
    Console.WriteLine("Число "+(Number1)+" не кратно числу " +(Number2)+", остаток от деления равен " + (result));
}
