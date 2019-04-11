using System;
class Program
{
  //Add
  public int add(int a,int b)
  {
  return a+b;
  }
  //Sub
  public int sub(int a,int b)
  {
  return a-b;
  }
  //Mul
    public int mul(int a,int b)
  {
  return a*b;
  }
  //div
    public int div(int a,int b)
  {
  return a/b;
  } 
  public static void Main()
  {
    Console.WriteLine(add(2,3));
    Console.WriteLine(sub(5,3));
    Console.WriteLine(mul(7,3));
    Console.WriteLine(div(9,3));
  }
}
