/* This is my Method Array Sum assignment.
 * By Jason Wang
 * Date: 7/8/2023
 * Professor: Weimar Ardila Rueda
 * Course: Managing Information Resources
 */
using System;
using System.Linq.Expressions;

namespace RandArrayMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input an integer between 5 and 15!");
                int input=int.Parse(Console.ReadLine());
                if (input >= 5 && input <= 15)
                {
                    Console.WriteLine("You have inputted " + input + ". Here are your numbers: ");
                    int[] mainArray = Rand_Array(input);           //Cannot call method inside foreacch, so reassigned Rand_Array to this one
                    foreach (int i in mainArray)
                    {
                        Console.WriteLine(i);
                    }
                    int tot=Summs(mainArray);                       //Replaces the array in Summs method with mainArray, which is linked to Rand_Array
                    Console.WriteLine("Your total sum is: " + tot);

                }
                else 
                { 
                    Console.WriteLine("The value was not between 5 and 15! Please try again."); 
                }

            }
            catch
            {
                Console.WriteLine("There was an error, plz input proper integer!");
            }
        }

        static int[] Rand_Array (int num)
        {
            Random rnd = new Random();                          //Random generator
            int[] inputArray = new int[num];                    //Create an array and set # of array to num input
            for (int i = 0; i < num; i++)                       //Initialize i as 0, and as long as it is less than user input, continue adding an-
            {
                inputArray[i] = rnd.Next(10,50);                //-random number between 10-50 into the inputArray, until it reaches user inputted #
            }
            return inputArray;                                  //Return is important as loop ends, giving the final value to the variable
        }

        static int Summs(int[] Array )                          //Sums method has array parameter
        {
            int sum=0;
            foreach (int i in Array)                            //Each element/number inside the Array will cause loop to repeat, adding it to sum
            {                                                   // With each sum increasing until it finishes adding all numbers
                sum = sum + i;
            }
            return sum;
        }

    }
}