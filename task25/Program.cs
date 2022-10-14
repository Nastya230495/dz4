Console.Clear();
Console.Write ("Введите 1-е число: "); 
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите 2-е число: "); 
int b = Convert.ToInt32(Console.ReadLine());
int result =a;
for (int i = 1; i<b; i++)
{
result=result*a;
}
Console.WriteLine (result + " ");
