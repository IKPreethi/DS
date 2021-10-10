using System;
					
public class Program
{
	public static void Main()
	{
		Program main = new Program();
		var result = main.fib(8); 
		Console.WriteLine(result);
	}
	
	 public int fib(int n) {
         if (n<0) {
            return -1;
            }
    if (n==0 || n==1) {
             return n;
        }
    return fib(n-1) + fib(n-2);
  }
}