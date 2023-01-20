Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int i = 2 ;

while ( i < Num + 1 )
{  
if (i %2 == 0 ) 
Console.Write(" четные " + i );

 i = i+2 ;
} 