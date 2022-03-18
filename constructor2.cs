using System;
class DAY10
{
int num1;
public DAY10()
{
Console.WriteLine("The name is venkat");
}
public DAY10(int num1)
{
this.num1=num1;
}
public static void Main()
{
DAY10 obj=new DAY10();
DAY10 obj1=new DAY10(22);
Console.WriteLine(obj1.num1);
}
}