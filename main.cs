using System;

class Program {
  public static void Main (string[] args) {
  FibIteration Fi = new FibIteration();
  FibFormula Ff = new FibFormula();
   Console.WriteLine("Enter the number you want to find the Fibonacci Series for: ");
   int n = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Fib of " + n + " by iteration is: " + Fi.calculate_fib(n));
   Console.WriteLine("Fib of " + n + " by formula is: " + Ff.calculate_fib(n));
  }
  interface IFindFib {
    int calculate_fib(int x);
  }

  class FibIteration : IFindFib {
    public int calculate_fib(int n){
      int y = 1;
      int ysub = 0;
      int totSeq = 0;
      if (n == 1 || n == 2){
        totSeq = 1;
      }
      else {
        for (int i = 0; i < (n + 1); i++){
           totSeq = ysub;
            ysub = y;
            y = totSeq + y;
        }
      }
      return totSeq;
    }
  }
  class FibFormula : IFindFib {
    public int calculate_fib(int n){
      double rFive = Math.Sqrt(5);
      double gR = (1 + rFive) / 2;
      double phi = (1 - rFive) / 2;
      return Convert.ToInt32((Math.Pow(gR, n) - Math.Pow(phi, n)) / rFive);
    }
  }
}