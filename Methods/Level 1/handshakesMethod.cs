using System;

class handshakesMethod{
	static void handshake(){
		Console.WriteLine("Enter number of students");
		int stud = Convert.ToInt32(Console.ReadLine());
		
		int handshakes = (stud * (stud - 1))/2;
		Console.WriteLine("Total handshakes are "+ handshakes);
	}

	public static void Main(String [] args){
		handshake();
	}
}