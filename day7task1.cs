using System;
class printage
{
public static void Main()
{
int age;
String name;
Console.WriteLine("Enter name:");
name=Console.ReadLine();
Console.WriteLine("Enter age:");
age=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<age;i++)
{
 Console.WriteLine(name);
}
}
}
