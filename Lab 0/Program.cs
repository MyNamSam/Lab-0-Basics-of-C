//Lab 0: Basics of C#
//Sam M

class DifferenceCalculator
{
    static void Main()
    {
        // Low number prompt
        int LowNum;
        
        do
        { 
            Console.Write("Enter a low number: ");
            LowNum = Convert.ToInt32(Console.ReadLine());

            // Error output if user inputs number below or equal to 0 for low number
            if (LowNum <= 0)
            {
                Console.WriteLine("Error... Enter a positive number.");
            }
        } while (LowNum <= 0);

        // High number prompt 
       int HighNum;

        do
        {
            Console.Write("Enter a high number: ");
            HighNum = Convert.ToInt32(Console.ReadLine());
        
            // Error output if user inputs nymber below or equal to the low number for high number
            if(HighNum <= LowNum)
            {
                Console.WriteLine($"Please enter a number greater than {LowNum}.");
            }
        
        } while (HighNum <= LowNum);

        // Difference formula
        int Difference = HighNum - LowNum;

        // Difference calculator output
        Console.WriteLine($"The difference between {LowNum} and {HighNum} is: {Difference}");

        // Array that holds every number between low and high numbers
        int[] NumbArray = new int[Difference + 1];
        for (int i = 0; i <= Difference; i++)
        {
            NumbArray[i] = LowNum + i;
        }

        // Write each number in reverse order to the file
        Array.Reverse(NumbArray);
        // Creates a file called "numbers.txt" that writes each number in the array to the file in reverse order (largest to smallest).
        using (var NumbFile = File.AppendText("numbers.txt"))
        {
            foreach (var NumbReverse in NumbArray)
            {
                NumbFile.WriteLine(NumbReverse);
            }
        }

        // Output of number text file
        Console.WriteLine($"The number(s) between {LowNum} and {HighNum} has been written to \"numbers.txt\" in reverse order from largest to smallest.");

    }
}


