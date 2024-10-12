using System.ComponentModel.Design;

public class Fabseries
{
    public static void Main(string[] args)
    {

        //   for (int i = 0; i <= 40; i += i+1) 
        // Console.WriteLine(i);
        Console.WriteLine("Enter The Limit");
        long limit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (limit > 0 && limit > 1)

        {
            long firstNumber = 0;
            Console.WriteLine(firstNumber);
            long secondNumber = 1;
            Console.WriteLine(secondNumber);
            long thirdNumber;

            for (int i = 0; i< limit; i++)
            {

                thirdNumber = firstNumber + secondNumber;
                if (thirdNumber < limit)
                {
                    Console.WriteLine(thirdNumber);
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                }
                else

                {

                    Console.WriteLine("break");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Limit Must be Above 0 or 1");
        }
    }
}
        
                

        
    



