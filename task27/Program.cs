Console.Write ("Введите  число: "); 
int n = Convert.ToInt32(Console.ReadLine());
int sum =0;
while (n > 0)
{
 int m=n%10;
sum= sum +m;
 n=n/10;
}
Console.WriteLine (sum + " ");

