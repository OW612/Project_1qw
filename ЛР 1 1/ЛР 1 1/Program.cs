using System;
 class Program
 {
   static void Main()
   {
      Console.Write("!a=");
      int a = int.Parse(Console.ReadLine());

      Console.Write("b=");
      int b = int.Parse(Console.ReadLine());

      Console.WriteLine("{0}+{1}={1}+{0}", a, b);

   }
 }
