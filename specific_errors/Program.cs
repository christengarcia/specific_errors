using System;

namespace specific_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int[] numbers = { 10, 11, 12, 13, 14, 15 };
            Console.Write("Please enter the index of the array: ");

            /* In addition to the Exception class that handles general
               errors, we also have other classes that can handle more 
               specific errors. This is useful if you want to perform
               specific tasks depending on the error caught.
               For instance, you may want to display your own
               error message. */
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("numbers [{0}] = {1}", choice, numbers[choice]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index should be from 0 to 5.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: You did not enter an integer.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}