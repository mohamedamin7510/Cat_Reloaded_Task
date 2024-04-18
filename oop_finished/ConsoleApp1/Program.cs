using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{


    abstract class superclass
    {
        public int number = 3;
        public abstract void childclass1();

        public abstract void childclass2();
        
        

    }

    class subclass1:superclass
    {
         int number = 3;
        public  override void childclass1() 
        {
            Console.WriteLine("this is a childclass1 in subclass1");
        }
        public override  void childclass2() 
        {
            Console.WriteLine("this is a childclass1 in subclass1"); 
        }


    
   
    }





    internal class Program
    {
      
        static void Main(string[] args)
        {
          
            var x=new subclass1 ();
            x.childclass1 ();
            x.childclass2 ();
            Console.ReadKey();
        }
    }
}
