using System;
class Covidtest
{
public static void Main()
{
string ans;
Console.WriteLine("travel history iruka ?");
ans =Console.ReadLine();
if(ans=="yes")
{
Console.WriteLine("Temprature iruka ?");
ans =Console.ReadLine();
if(ans=="yes")
{
Console.WriteLine("cough/sneeze iruka");
ans =Console.ReadLine();
if(ans=="yes")
{
Console.WriteLine("swab test edu");
}
else
Console.WriteLine("quarantine pannu");
}
else
Console.WriteLine("home quarantine pannu");
}
else
Console.WriteLine("neengal safe");
}
}