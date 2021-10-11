using System;
					
public class Program
{
	public static void Main()
	{
		Program main = new Program();
		var result = main.isPalindrome("haah"); 
		Console.WriteLine(result);
	}
	
	 public bool isPalindrome(string s) {
		 if(string.IsNullOrEmpty(s) || s.Length == 1 ){
			 return true;
		 }
		 if(s[0] == s[s.Length-1])
		 {
			 return isPalindrome(s.Substring(1, s.Length-2));
		 }
		 else 
			 return false;
  }
}
