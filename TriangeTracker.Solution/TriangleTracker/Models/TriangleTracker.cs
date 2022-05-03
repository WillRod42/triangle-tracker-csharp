using System;

namespace Tracker
{
  public class TriangleTracker
  {
    public static void Main()
    {
      Console.Write("Enter first side: ");
      int side1 = int.Parse(Console.ReadLine());

      Console.Write("Enter second side: ");
      int side2 = int.Parse(Console.ReadLine());

      Console.Write("Enter thrid side: ");
      int side3 = int.Parse(Console.ReadLine());

      Console.WriteLine(GetTypeOfTriangle(side1, side2, side3));
    }

    public static string GetTypeOfTriangle(int side1, int side2, int side3)
    {
      if (side1 > 0 && side2 > 0 && side3 > 0)
      {
        if (side1 == side2 && side2 == side3)
        {
          return "Equilateral triangle";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
          return "Isosceles triangle";
        }
        else if (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
        {
          return "Not a triangle";
        }
        else
        {
          return "Scalene triangle";
        }
      }
      else
      {
        return "Not a triangle";
      }
      
    }
  }
}