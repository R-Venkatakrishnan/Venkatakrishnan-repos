using System;
class addsub
{
public void add()
{
int n1=25;
int n2=30;
Console.WriteLine(n1+n2);
Console.WriteLine(n1-n2);
}
}
class multidiv:addsub
{
public  void multi()
{
int n1=25;
int n2=30;
Console.WriteLine(n1*n2);
Console.WriteLine(n1/n2);
}
}
class inherit
{
public static void Main()
{
multidiv obj=new multidiv();
obj.add();
obj.multi();
}
}