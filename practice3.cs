//this is pyramid that compose of numbers from 1

using System;  
public class Practice3
{  
    public static void Main(string[] args)
    {
       int i,rows,k,t=1;
       
       Console.Write("input number of rows : ");
       rows= Convert.ToInt32(Console.ReadLine());    
   
       for(i=1;i<=rows;i++)
       {
         for(k=rows;k>=i;k--)
            {
              Console.Write(" ");
            }
            for(int x=0;x<=k;x++)
            {
                Console.Write("{0} ",t++);
            }
            
        Console.WriteLine("");
       
       }
    }
}
