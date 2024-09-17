
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
        if (num2 == 0)
        {
            throw new DivideByZeroException("cant divide by 0"); //this handles what happens if num1 is divided by 0
        }
        //implementing the division logic
        return num1 / num2;
    }
}