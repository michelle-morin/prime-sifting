using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Prime
  {
    public static List<int> CheckPrime(int number)
    {
      List<int> primeNumbers = new List<int> {};
      for(int i = 2; i <= number; i++)
      {
        primeNumbers.Add(i);
      }
      for (int prime = 2; prime <= Math.Sqrt(number); prime++)
      {
        for (int i = 2; i < primeNumbers.Count; i++)
        {
          if (primeNumbers[i] % prime == 0)
          {
            primeNumbers.RemoveAt(i);
          }
        }
      }
      return primeNumbers;
    } 
  }
}