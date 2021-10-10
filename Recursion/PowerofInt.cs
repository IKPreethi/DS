using System;
					
public class Program
{
	public static void Main()
	{
		Program main = new Program();
		var result = main.Power(2,9); 
		Console.WriteLine(result);
	}
	
	public decimal Power(int num, int pow){
		if(pow < 0){
			return -1;
		}
	   if(pow == 0){
			return 1;
		}
			return num * Power(num, pow-1);
	}
}