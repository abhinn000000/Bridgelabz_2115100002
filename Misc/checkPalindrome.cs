using System;

class checkPalindrome{
	static bool palindrome(string input){
		int start =0;
		int end = input.Length - 1;
		bool flag = false;
		while(start < end){
			if(input[start] == input[end]){
				flag = true;
			}
			start++;
			end--;
		}
		return flag;
	}
	
	static string takingInput(){
		Console.WriteLine("Enter a string");
		string input = Convert.ToString(Console.ReadLine());
		return input;
	} 
	
	static void printingResult(bool result){
		Console.WriteLine(result);
	}
	
	public static void Main(String [] args){
		string input = takingInput();
		bool result = palindrome(input);
		printingResult(result);
	}
}