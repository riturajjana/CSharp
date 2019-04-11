using System;
class Program
{
  public int add(int a,int b)
  {
  return a+b;
  }
  public int sub(int a,int b)
  {
  return a-b;
  }
    public int mul(int a,int b)
  {
  return a*b;
  }
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
