using System;
class pack
{
public static void Main()
{
string package;
Console.WriteLine("enter package name");
package=Console.ReadLine();
switch(package)
{
case "A":Console.WriteLine("The package cost is 250rs and channels are southspecial,childres's club,movies");
break;
case "B":Console.WriteLine("The package cost is 450rs and channels are news,sports,movies,regional-2");
break;
case "c":Console.WriteLine("The package cost is 350rs and chennels are discovery,history,national");
break;
}
} 
}