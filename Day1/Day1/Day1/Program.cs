namespace Day1
{
    internal class Program
    {
        static decimal Calculator(decimal FirstNumber, decimal SecondNumber, char Operator)
        {
            if (Operator == '+') {
                      return FirstNumber + SecondNumber;
            }
            else if (Operator == '-'){
                return FirstNumber - SecondNumber;
            }
            else if (Operator == '*'){
                return FirstNumber * SecondNumber;
            }
            else if (Operator == '/')
            {
                return FirstNumber / SecondNumber;
            }
            else
            {
                Console.WriteLine("Please Enter Operator");
                return 0;
            }
        }
        static void CompleteNumbers()
        {
            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i/2; j++)
                {
                    if(i%j==0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
 
            Console.WriteLine("Enter FirstNumber");
            decimal FirstNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter SecondNumber");
            decimal SecondNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Opertar");
            char Operator = char.Parse(Console.ReadLine());
            Console.WriteLine(Calculator(FirstNumber, SecondNumber, Operator));

            Console.WriteLine("Complete Numbers are :");
            CompleteNumbers();
        }

    }
}