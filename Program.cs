using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter any number greater than 2:");
      string stringNumber = Console.ReadLine();
      int number = int.Parse(stringNumber);
      if(number <=2)
      {
        Main();
      }
      else
      {
        List<int> primes = Prime.CheckPrime(number);
        Console.WriteLine("These are all the prime numbers between 2 and " + number + ":");
        foreach (int prime in primes)
        {
          Console.Write(prime + " ");
        }
        Console.WriteLine("");
      }
    }
  }
}