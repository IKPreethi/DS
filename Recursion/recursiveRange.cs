using System;
					
public class Program
{
	public static void Main()
	{
		Program main = new Program();
		var result = main.recursiveRange(4); 
		Console.WriteLine(result);
	}
	
	 public int recursiveRange(int num) {
       if(num<0)
       {
           return 0;
       }
    return num + recursiveRange(num-1);
   } 
}