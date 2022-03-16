using System;
class vattaxcalculation
{
public virtual void calculateTax()
{
int n1=200;
float vat=(float)(n1*(1+0.2));
Console.WriteLine("vat"+vat);
}
}
class gsttaxcalculation:vattaxcalculation
{
public override void calculateTax()
{
int n1=250;
int gst=n1*12/100;
Console.WriteLine("gst"+gst);
}
}
class inherit
{
public static void Main()
{
gsttaxcalculation obj=new gsttaxcalculation();
vattaxcalculation obj2=new vattaxcalculation();
obj.calculateTax();
obj2.calculateTax();

}
}