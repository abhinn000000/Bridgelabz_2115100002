using System;

class BMI{
	public static void Main(String [] args){
		Console.WriteLine("Enter the number of people");
		int num = Convert.ToInt32(Console.ReadLine());
		double [] heights = new double [num];
		double [] weights = new double [num];
		double [] bmi = new double [num];
		string [] ws = new string [num];
		for(int i = 0;i < num;i++){
			Console.WriteLine("Enter your weight");
			double weight = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter your height");
			double height = Convert.ToDouble(Console.ReadLine());
			heights[i] = height;
			weights[i] = weight;
			bmi[i] = weights[i]/heights[i]; 
			if(bmi[i] < 18.4){
				ws[i]= "Underweight";
			}
			else if(bmi[i] < 24.9 && bmi[i] > 18.4){
				ws[i]= "Normal";
			}
			else if(bmi[i] < 39.9 && bmi[i] > 25){
				ws[i]= "Overweight";
			}
			else{
				ws[i]= "Obese";
			}
		}
		for(int j = 0;j < num;j++){ 
			Console.WriteLine("Weight: "+weights[j]+" Height: "+heights[j]+" BMI: "+bmi[j]+" Weight Status: "+ws[j]);
		}
	}
}