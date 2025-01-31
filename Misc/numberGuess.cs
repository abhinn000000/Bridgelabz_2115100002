using System;

class numberGuess{
	
	static int generateGuess(){
		Random rnd = new Random();
		int guess = rnd.Next(1,101);
		return guess;
	}
	
	static string recieveUser(){
		Console.WriteLine("Higher ,lower or correct");
		string input = Convert.ToString(Console.ReadLine());
		return input;
	}
	
	static int nextGuess(string user,int previousGuess){
		Random rnd = new Random();
		if(user == "higher"){
			int guess = rnd.Next(previousGuess+1,101);
			return guess;
		}
		else if(user == "lower"){
			int guess = rnd.Next(1,previousGuess-1);
			return guess;
		}
		else if(user == "correct"){
			return -1;
		}
		else{
			return -2;
		}
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		int myGuess = generateGuess();
		bool game = false;
		while(!game){
			Console.WriteLine("Is "+myGuess+" your number?");
			string user = recieveUser();
			int newGuess = nextGuess(user,myGuess);
			if(newGuess == -1){
				Console.WriteLine("Great! I guessed your number!");
				game = true;
			}
			else if(newGuess == -2){
				Console.WriteLine("Please enter higher, lower or correct");
			}
			else{
				myGuess = newGuess;
			}
		
		}
	}
}
