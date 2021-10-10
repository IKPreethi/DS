using System;
					
public class Program
{
	public static void Main()
	{
		Program main = new Program();
		var result = main.gcd(8,4); 
		Console.WriteLine(result);
	}
	
	public int gcd(int a, int b){
        if(a < 0 || b < 0){
            return -1;
        }
		if(b == 0){
			return a;
		}
		   return gcd(b, a%b);
	}
}