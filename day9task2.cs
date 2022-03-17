using System;
abstract class Calculator
{
public abstract void Arithmetic();
}

class Addition:Calculator
{
public override void Arithmetic( )
{
int a=20;
int b=20;
int sum;
Console.WriteLine("ADD");
sum=a+b;
Console.WriteLine(sum);
}
}


class Subtract:Calculator
{
public override void Arithmetic()
{
 int c=20;
 int d=20;
int sub;
Console.WriteLine("SUB");
sub=d-c;
Console.WriteLine(sub);
}
}


class Multiply:Calculator
{
public override void Arithmetic()
{
 int e=20;
int f=5;
int mul;
Console.WriteLine("MUL");
mul=e*f;
Console.WriteLine(mul);
}
}


class Divide:Calculator
{
public override void Arithmetic()
{
int g=20;
int h=5;
int div;
Console.WriteLine("DIV");
div=g/h;
Console.WriteLine(div);
}
}
class task
{
public static void Main()
{
Addition addobj = new Addition();
addobj.Arithmetic();
Subtract subobj = new Subtract();
subobj.Arithmetic();
Multiply mulobj = new Multiply();
mulobj.Arithmetic();
Divide divobj = new Divide();
divobj.Arithmetic();

}
}