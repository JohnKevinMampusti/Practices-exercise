//this is diamond shape that row is inputed by the user

using System;  
public class practice4 
{  
    public static void Main(string[]args)
{
   int i,j,r;
   
   Console.Write("Input number of rows (half of the diamond) :");
   r = Convert.ToInt32(Console.ReadLine());   
   for(i=0;i<=r;i++)
   {
     for(j=1;j<=r-i;j++)
     Console.Write(" ");
     for(j=1;j<=2*i-1;j++)
     Console.Write("*");
     Console.WriteLine("");
   }
 
   for(i=r-1;i>=1;i--)
   {
     for(j=1;j<=r-i;j++)
     Console.Write(" ");
     for(j=1;j<=2*i-1;j++)
       Console.Write("*");
     Console.WriteLine("");
   }
  }
}
