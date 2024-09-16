namespace _16._09._2024_csharp_classes_methods_assignment;

//interface with two methods AddNumbers and SubtractNumbers
interface ICalculator
{
    //adds two parameters(inputs) to each method 
    double AddNumbers(double num1, double num2);
    double SubstactNumbers(double num1, double num2);
    double MultiplyNumbers(double num1, double num2);
    double DivideNumbers(double num1, double num2);
}

class Calculator : ICalculator //Calculator class implements the Icalculator interface, with the use of ":"
{
    /* 
    public - allows it to be accessed form outside the class
    double - makes the method return result as a double 
    */
    public double AddNumbers(double num1, double num2)
    {
        //implementing the addition logic
        return num1 + num2;
    }

    public double SubstactNumbers(double num1, double num2)
    {
        //implementing the substacion logic
        return num1 - num2;
    }
    public double MultiplyNumbers(double num1, double num2)
    {
        //implementing the multiplication logic
        return num1 * num2;
    }
    public double DivideNumbers(double num1, double num2)
    {
        //implementing the division logic - !!!needs zero exception
        return num1 / num2;
    }
}
class Program
{


    static void Main(string[] args)
    {

        /* //This part is for the video lesson -------------------------------------------------------------------------------------------
        // string = a datatype that contains text
        string helloWorld = "Hello, world";
        Console.WriteLine(helloWorld);

        //int = a datatype that contains whole numbers
        int x = 10;
        Console.WriteLine(x * 2);

        //double = a datatype that contains decimal numbers
        double y = 5.5;
        Console.WriteLine(x + y);

        //char = a datatype that containts a letter, which represents a predetermined number
        char a = 'A';
        char b = 'B';
        Console.WriteLine(a + b); // the predetermined number of a + b in ascii is 65 + 66 = 131

        //float = a datatype that stores positive and negative numbers with a decimal
        float z = 3.14f;
        Console.WriteLine(z);

        //bool = a datatype that only accepts true or false
        bool isOnline = false;
        Console.WriteLine(!isOnline); // use of "!" will make the value opposite of what is given

        
        //int -> contains 4 bytes -2,147,483,648 to 2,147,483,467
        //long -> contains 8 bytes -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        //float -> can hold decimal numbers with a precision of around six to seven decimals
        //double -> can hold decimal numbers with a precision of around fifteen decimals.
        
        long myNumber = 120000;
        Console.WriteLine(myNumber);
        */
    }
}
