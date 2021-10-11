using System;
					
public class Program
{
	public static void Main()
	{
		Program main = new Program();
		var result = main.reverse("java"); 
		Console.WriteLine(result);
	}
	
	 public string reverse(string s) {
		 if(string.IsNullOrEmpty(s)){
			 return s;
		 }
            return reverse(s.Substring(1))+ s[0];
  }
}