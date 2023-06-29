// this is pyramid that compose of *

using System;
namespace myApplication
{
    public class Practice2
    {  
        public static void Main(string[]args) 
        { int x;
            for(int i=1;i<=5;i++)
            {
                for(x=5;x>=i;x--)
                {
                    Console.Write(" ");
                }
                for(int y=0;y<=x;y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }	
    }
}