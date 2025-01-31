// See https://aka.ms/new-console-template for more information
class Employee
{
    //Attributes
    private string name;
    private int id;
    private double salary;

    //Constructor
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    //Displaying the Employee details
    public void DisplayDetails()
    {
        Console.WriteLine("The name of the employee is " + name);
        Console.WriteLine("The id of the employee is " + id);
        Console.WriteLine("The salary of the employee is " + salary);
    }
}

public class Program {
    /*public static void Main(String[] args) {
        Employee employee1 = new Employee("Ajitesh",291,50000);

        employee1.DisplayDetails();
    }*/
}
