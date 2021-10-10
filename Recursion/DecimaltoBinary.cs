using System;
					
public class Program
{
	public static void Main()
	{
		Program main = new Program();
		var result = main.decimalToBinary(10); 
		Console.WriteLine(result);
	}
	
	public int decimalToBinary(int num){
		if(num == 0){
			return 0;
		}
		   return num%2 + (10 * decimalToBinary(num/2));
	}
}