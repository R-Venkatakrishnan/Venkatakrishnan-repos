using System;
class validation
{
public void options(string a,int b)
{
Console.WriteLine("Option A "+"Email "+a+" password "+b);
}
public void options(double c,int d)
{
Console.WriteLine("Option B " +"Membership ID "+c+" Pin "+d);
}
public void options(int e,int f)
{
Console.WriteLine("Option C "+ "Mobile Number "+e+" Pin "+f);
}
public static void Main()
{
	string a;
	int b;
	Console.WriteLine("Enter YOUR Email");
	a=Console.ReadLine();
	Console.WriteLine("Enter YOUR password");
	b=Convert.ToInt32(Console.ReadLine());
    validation obj=new validation();
    obj.options(a,b);
    double c;
	int d;
	Console.WriteLine("Enter YOUR Membership_id");
	c=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter pin");
	d=Convert.ToInt32(Console.ReadLine());
	obj.options(c,d); 
	int e;
	int f;
	Console.WriteLine("Enter YOUR Mobile number");
	e=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter pin");
	f=Convert.ToInt32(Console.ReadLine());
	obj.options(e,f);
	Console.WriteLine("VALIDATION COMPLETED");
}
}
