using System;
using PierresBakery.Models;

namespace PierresBakery 
{
  public class Program 
  {
    public static void Main() 
    {
      Console.WriteLine("Hello and welcome to Pierre's Bakery! \n\n");
      Console.WriteLine("Bread: $5 each --- Pastry: $2 each \n\n     **** \n\n Today we have a promo for our bread and pastries! \n Breads: Buy two get one free \n Pastries: 3 for $5 \n\n     **** \n");

//Bread
      Console.WriteLine("How many loaves of bread would you like to buy today?");
      string stringInputtedBread = Console.ReadLine();
      int inputtedBreadAmount = int.Parse(stringInputtedBread);
      Bread breadOrder = new Bread(inputtedBreadAmount);
      int breadTotal = breadOrder.BreadTotal();
      
//Pastry
      Console.WriteLine("And how many pastries?");
      string stringInputtedPastry = Console.ReadLine();
      int inputtedPastryAmount = int.Parse(stringInputtedPastry);
      Pastry pastryOrder = new Pastry(inputtedPastryAmount);
      int pastryTotal = pastryOrder.PastryTotal();

//Total Cost
      int totalCost = pastryTotal + breadTotal;
      Console.WriteLine($"\nYour total is ${totalCost} \n \nWould you like to place another order? (Y/N)");
      string again = Console.ReadLine();
      if (again == "y" || again == "Y")
      {
        Console.WriteLine("\n\n\n ******* \n\n New Order :) \n\n ******* \n" );
        Main();
      }
      else {
      Console.WriteLine("\n\nEnjoy! :)");
      }
    }
  }
}