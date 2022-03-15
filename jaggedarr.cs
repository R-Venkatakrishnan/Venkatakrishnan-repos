using System;
class jaggedarr
{
public static void Main()
{
string[][] product=new string[4][];
product[0] = new string[]{"List","Product category","No.of items"};
product[1] = new string[]{"a","Buiscuit"," ","There are 4 items"};
product[2] = new string[]{"b","chocolate"," ","There are 5 items"};
product[3] = new string[]{"c","drinks"," "," ","There are 6 items"};
for(int i=0;i<product.Length;i++)
{
  for(int j=0;j<product[i].Length;j++)
  Console.Write(product[i][j]+"\t");
  Console.WriteLine();
}
}
} 