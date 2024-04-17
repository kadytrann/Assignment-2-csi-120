using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Text;

namespace Assignment_2
{
    // Kady Tran
    // 4/16/2024
    internal class Program
    {
        static void Main(string[] args)
        {
            Question1();
            Question2();
            Question3();
            Question4();
            Question5();
            Question6();
            Question7();

        } // End of main

        public static void Question1()
        {

            /* 1. Write a program that prompts the user to input five decimal numbers.  Your program should do the following:

            a. Prompts the user to input five decimal numbers. 
            b. Prints the five decimal numbers. 
            c. Add the five decimal numbers.
            d. Print the sum and the average of the five decimals. Calculating the sum and the average are two separate calculations.
            */

            // Label question 1

            Console.WriteLine("Question 1: ");

            // Asking user to input five decimal numbers
            Console.Write("Please enter decimal numbers for number 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter decimal numbers for number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter decimal numbers for number 3: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("Please enter decimal numbers for number 4: ");
            double num4 = double.Parse(Console.ReadLine());

            Console.Write("Please enter decimal numbers for number 5: ");
            double num5 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);
            Console.WriteLine("Number 3: " + num3);
            Console.WriteLine("Number 4: " + num4);
            Console.WriteLine("Number 5: " + num5);

            double sumOfDecimalNumbers = num1 + num2 + num3 + num4 + num5;
            double numberFive = 5;
            double average = sumOfDecimalNumbers / numberFive;
            Console.WriteLine("The sum of the five decimal numbers is: " + sumOfDecimalNumbers);
            Console.WriteLine("The average of the five decimals is: " + average);
        } 
        
        public static void Question2()
        {
            Console.WriteLine(""); // This is for space
            // 2. Write a program that prompts the capacity, in gallons, of an automobile fuel tank and the miles per gallon the automobile can be driven. The program outputs the number of miles the automobile can be driven without refueling.

            Console.WriteLine("Question 2: ");

            // Asking user for capacity of their fuel tank
            Console.Write("Enter the Capacity of your Fuel Tank: ");
            double fuelTank = double.Parse(Console.ReadLine());
            // Asking user for their MPG
            Console.Write("Enter your MPG: ");
            double mpg = double.Parse(Console.ReadLine());

            // Calculation = capacity * mpg
             double milesWithoutRefueling = fuelTank * mpg;

            // Output the number of miles the automobile can be driven without refueling
            Console.WriteLine("The number of miles your automobile can be driven without refueling is: " + milesWithoutRefueling);

        } // End of Question2()

        public static void Question3()
        {
            Console.WriteLine(""); // This is for space
            Console.WriteLine("Question 3: ");
            // 3. Write a  program that prompts the user to input the elapsed time for an event in seconds. The program then outputs the elapsed time in hours, minutes, and seconds. (For example, if the elapsed time is 9630 seconds, then the output is 2:40:30.)

            // Asking user for an elapsed time
            int seconds = 0;
            Console.Write("Please enter an elapsed time (ex. 9630 seconds): ");
            string userTimeInput = Console.ReadLine();
            seconds = int.Parse(userTimeInput);

            // Converting to hour
            int secondsInHour = 3600;
            int hours = seconds / secondsInHour;

            // Converting to minutes
            int convertedToMinutes = seconds / 60;
            int secondsInMinute = 60;

            // Remaining seconds into minutes
           int minutes = convertedToMinutes %= secondsInMinute;

            // Remaining seconds
            int second = seconds %= minutes;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");

        } // End of question3()

        public static void Question4()
        {
            Console.WriteLine(""); // This is for space
            Console.WriteLine("Question 4: ");
            // 4. Write a  program that prompts the user to input the elapsed time for an event in hours, minutes, and seconds. The program then outputs the elapsed time in seconds.
            
            // asking for hours
            Console.Write("Please enter the amount of hours: ");
            int hour = 0;
            string hours = Console.ReadLine();
            hour = int.Parse(hours);

            // asking for minutes
            Console.Write("Please enter the amount of minutes: ");
            int minute = 0;
            string minutes = Console.ReadLine();
            minute = int.Parse(minutes);

            // asking for seconds
            Console.Write("Please enter the amount of seconds: ");
            int second = 0;
            string seconds = Console.ReadLine();
            second = int.Parse(seconds);

            // Calculation
            // Seconds in an hour
            int elapsedHour = hour * 3600;
            // Seconds in a minute
            int elapsedMinute = minute * 60;
            // Adding altogether
            int elapsedTime = elapsedHour + elapsedMinute + second;

            // Output
            Console.WriteLine("The elapsed time in seconds: " + elapsedTime);


        }// End of question4

        public static void Question5()
        {
            Console.WriteLine(""); // This is for space
            Console.WriteLine("Question 5: ");
            // 5. To make a profit, a local store marks up the prices of its items by a certain percentage. Write a program that reads the original price of the item sold, the percentage of the marked-up price, and the sales tax rate. The program then outputs the original price of the item, the percentage of the mark-up, the store’s selling price of the item, the sales tax rate, the sales tax, and the final price of the item. (The final price of the item is the selling price plus the sales tax.)

            // Asking user the original price of the item sold
            Console.Write("Original price of the item sold: ");
            double priceOfItemSold = double.Parse(Console.ReadLine());

            // Asking user the percentage of the marked-up price
            Console.Write("Percentage of the marked-up price: ");
            double percentageMarkedUp = double.Parse(Console.ReadLine());

            // Asking user the sales tax rate
            Console.Write("Sales tax rate: ");
            double salesTaxRate = double.Parse(Console.ReadLine());

            // Calculation
            // This is original price of item with percentage of the marked-up price
            double markedUpAdditionalPrice = priceOfItemSold * percentageMarkedUp;
            double sellingPriceOfTheItem = markedUpAdditionalPrice + priceOfItemSold;

            // This is the sales tax rate calculation to find out the sales tax for the item sold
            double salesTaxForSellingPriceOfTheItem = Math.Round(salesTaxRate * sellingPriceOfTheItem, 2);

            // Finding out the final price of the item
            double finalPriceOfItem = sellingPriceOfTheItem + salesTaxForSellingPriceOfTheItem;


            // Output
            Console.WriteLine(""); // This is for space
            Console.WriteLine("Receipt Details");
            Console.WriteLine("Original price of the item: " + priceOfItemSold.ToString("c"));
            Console.WriteLine("Percentage of the mark-up: " + percentageMarkedUp.ToString("p"));
            Console.WriteLine("The store's selling price of the item: " + sellingPriceOfTheItem.ToString("c"));
            Console.WriteLine("Sales tax rate: " + salesTaxRate.ToString("p"));
            Console.WriteLine("Sales tax: " + salesTaxForSellingPriceOfTheItem.ToString("c"));
            Console.WriteLine("Final price of the item: " + finalPriceOfItem.ToString("c"));

        } // Question5()

        public static void Question6()
        {
            //6.Write a program that prompts the user to input a length expressed in centimeters.The program should then convert the length to inches(to the nearest inch) and output the length expressed in yards, feet, and inches, in that order. For example, suppose the input for centimeters is 312. To the nearest inch, 312 centimeters is equal to 123 inches. 123 inches would thus be output as:
            Console.WriteLine(""); // This is for space
            Console.WriteLine("Question 6: ");

            // 1. Ask user for lengeth in centimeters.
            int centimeters = 0;
            try
            {
                Console.Write("Enter a length in centimeters: ");
                string userInput = Console.ReadLine();
                centimeters = int.Parse(userInput);

                // 1b. Wrap in a try / catch
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }

            // 2. Convert users length to inches
            double convertedToInches = Math.Round(centimeters / 2.54);


            // 3. Convert to yards, feet, and inches
            int inchesInYard = 36;
            // Getting whole number of yards
            int yards = (int)convertedToInches / inchesInYard;

            // Getting remaining inches
            convertedToInches %= inchesInYard;

            // Getting the inches
            int inchesInFoot = 12;
            int feet = (int)convertedToInches / inchesInFoot;

            // Get remaining inches
            convertedToInches %= inchesInFoot;
            int inches = (int)convertedToInches;

            // 3 yard(s), 1 feet (foot), and 3 inch(es).
            Console.WriteLine($"{yards} yard(s), {feet} feet (foot), and {inches} inch(es)");

        } // Question 6

        public static void Question7()
        {
            Console.WriteLine(""); // This is for space
            Console.WriteLine("Question 7: ");
            // 7. A milk carton can hold 3.78 liters of milk. Each morning, a dairy farm ships cartons of milk to a local grocery store. The cost of producing one liter of milk is $0.38, and the profit of each carton of milk is $0.27. Write a program that does the following:

            //a.Prompts the user to enter the total amount of milk produced in the morning.DONE

            //b.Outputs the number of milk cartons needed to hold milk. (Round your answer to the nearest integer.) DONE

            //c.Outputs the cost of producing milk.

            // d.Outputs the profit for producing milk.

            // Prompts the user to enter the total amount of milk produced in the morning.
            Console.Write("Enter the total amount of milk produced in the morning (in liters): ");
            double userAmountOfMilk = double.Parse(Console.ReadLine());

            // Outputs the number of milk cartons needed to hold milk. (Round your answer to the nearest integer.)
            double milkCarton = 3.78;
            int numberOfMilkCartonsToHoldMilk = (int)Math.Round(userAmountOfMilk / milkCarton);
            Console.WriteLine("The number of milk cartons needed to hold milk: " + numberOfMilkCartonsToHoldMilk);

            // Outputs the cost of producing milk.
            double costOfProduction = 0.38;
            double costLiterProduction = userAmountOfMilk * costOfProduction;
            Console.WriteLine("The cost of producing milk ($0.38 per 1 liter): " + costLiterProduction.ToString("c"));

            // Outputs the profit for producing milk.
            double profitOfEachCarton = 0.27;
            double profitOfProduction = profitOfEachCarton * numberOfMilkCartonsToHoldMilk;
            Console.WriteLine("The profit of producing milk ($0.27 per 1 carton): " + profitOfProduction.ToString("c"));

        } // End of question 7


    } // End of class
}
