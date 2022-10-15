Console.WriteLine("enter gramms");
int gramms = int.Parse(Console.ReadLine());
float toLitr(int a)
{
    return a / 1000;
}
Console.WriteLine("liters = " + toLitr(gramms));
Console.WriteLine("enter new liters");
int liters = int.Parse(Console.ReadLine());
double toGal(int a)
{
    return a* 0.264172;
}
Console.WriteLine("galons = " + toGal(liters));