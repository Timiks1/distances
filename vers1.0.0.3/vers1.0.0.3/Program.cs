Console.WriteLine("enter deegres");
float degree = float.Parse(Console.ReadLine());
float toFar(float a)
{
    float h = 9 ;
    h = h / 5;
    h = h * a;
    return h+ 32;
}
Console.WriteLine("far gradus = " + toFar(degree));