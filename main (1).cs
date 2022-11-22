//function call by value functions
using System;
class program
{
  public void show(int val)
  {
      int n;
      Console.WriteLine("value inside the show function");
      for(int i=0;i<10;i++)
      {
         n=val*i;
         Console.WriteLine(n);
      }
      Console.WriteLine("this is a function called by value");
  }
  public static void Main(String[] arg)
  {
      Console.WriteLine("enter the value for p");
      //int p1=Convert.ToInt(Console.ReadLine());
      int p1=123;
      program p=new program();
      Console.WriteLine("Value before the function called by value "+p1);
      
      p.show(p1);
      Console.WriteLine("Value after the show function "+p1);
  }
    
    
}
