using System;
					
public class Program
{
	public static void Main()
	{
		Program main = new Program();
        int[] arr = {1, 2, 3, 4, 5};
		var result = main.productofArray( arr, 5); 
		Console.WriteLine(result);
	}
	
	public int productofArray(int[] A, int N) 
    { 
        if(N<=0){
            return A[0];
        }
        return A[N-1] * productofArray(A, N-1);
    } 
}