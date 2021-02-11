using System;
using System.Collections.Generic;

namespace ConsoleApp.For.While.DoWhile.Foreach.Break.Continue
{
  class Program
  {
    static void Main(string[] args)
    {
      /* //-for-
      var list = new List<int>();
      for (var i = 0; i < 10; i+=2)
      {
        list.Add(i);
      }
      for (var i = 0; i < list.Count; i++)
      {
        Console.WriteLine(list[i]);
      }
      Console.ReadLine();
      */

      /* //-while-
      var list = new List<string>();
      while (list.Count < 5)
      {
        list.Add(Console.ReadLine());
      }

      var i = 0;
      while (i < list.Count)
      {
        Console.WriteLine(list[i]);
        i++;
      }
      Console.ReadLine();
      */

      /* //-do while-
      var i = 0;
      do
      {
        i++;
      }
      while (i < 0);
      Console.WriteLine(i);
      Console.ReadLine();
      */

      /* //-foreach-
      var list = new List<string>();
      var rnd = new Random();
      for (int i = 0; i < 10; i++)
      {
        list.Add(rnd.Next(0, 100).ToString());
      }
      foreach (var item in list)
      {
        Console.WriteLine(item);
      }
      Console.ReadLine();
      */

      /* //-break-
      var count = 0;
      while(count < 100)
      {
        count++;
        if (count == 23)
          break;
      }
      Console.WriteLine(count);
      Console.ReadLine();
      */

      /* //-continue-
      var i = 0;
      var j = 0;
      while (i < 100)
      {
        i++;
        continue;
        while (j < 100)
        {
          j++;
        }
        j++;
      }
      Console.WriteLine(i);
      Console.WriteLine(j);
      Console.ReadLine();
      */

      var list = new List<int>();
      
      //input
      while(list.Count < 5)
      {
        if(int.TryParse(Console.ReadLine(), out int result))
          list.Add(result);
        else
          Console.WriteLine("! int format only !");
      }
      //sum
      int sum = 0;
      for (var i = 0; i < list.Count; i++)
      {
        sum += list[i];
      }
      //dif
      int dif = list[0];
      int count = 1;
      while(count < list.Count)
      {
        dif -= list[count];
        count++;
      }
      //prod
      int prod = 1;
      int j = 0;
      do
      {
        prod *= list[j];
        j++;
      }
      while (j < list.Count);

      Console.WriteLine($"sum = {sum}");
      Console.WriteLine($"dif = {dif}");
      Console.WriteLine($"prod = {prod}");

      foreach (var item in list)
      {
        Console.WriteLine(item);
      }
      Console.ReadLine();

    }
  }
}
