
Console.WriteLine("enter meters ");
float metr = float.Parse(Console.ReadLine());

float toSant(float a)
{
    return a * 100;
}
float toKm(float a)
{
    return a / 1000;
}
Console.WriteLine("santimeters = " + toSant(metr));
Console.WriteLine("kilometers = " + toKm(metr));

