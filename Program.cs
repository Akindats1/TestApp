using System;


namespace TestApp

{ class Program
    {
        static void Main(string[] args)
        { 
            

             Console. WriteLine ("Enter firstname:" );


             string firstName = Console.ReadLine ();
            
             Console. WriteLine ("Enter lastname:");

             string lastName = Console.ReadLine ();
             
             Console. WriteLine ("Enter Age:");

             int age = Convert.ToInt16(Console.ReadLine ());

             Console. WriteLine ("Enter favorite color:");

             string favoriteColor = Console.ReadLine ();

             Console. WriteLine ("Enter favorite food:");

             string favoriteFood = Console.ReadLine ();

             Console. WriteLine ("Enter state of origin:");

             string stateOfOrigin = Console.ReadLine ();

             string result1 = ($"My name is {firstName} {lastName} from {stateOfOrigin}.\nI am  {age} years old.\nMy favorite food is {favoriteFood} and my favorite color is {favoriteColor}.");

             Console.WriteLine(result1);

             Console.WriteLine($"Thanks for your details {firstName} {lastName}");

             Console.WriteLine("Thanks for your \"feedback\"");

             Console.WriteLine("Enter Your Account Number: ");

             int accountNumber = Convert.ToInt32(Console.ReadLine()); 
             
             Console.WriteLine("Enter Your Bank name: ");
            
             string bankName = Console.ReadLine ();

             Console.WriteLine("Enter Your transfer amount: ");
             int transferAmount = Convert.ToInt32(Console.ReadLine());

             string myDouble = "24.55";
             double num2 = Convert.ToDouble(myDouble);
             int myInt = (int)num2;
             
             Console.WriteLine(num2);
             Console.WriteLine(myInt);


              double radius = (150 - 142 )/ 3;
             double areaOfCirle = Math.PI * radius * radius;
             double perimeter = 2 * Math.PI * radius;
             Console.WriteLine(areaOfCirle);
             Console.WriteLine(perimeter);

             int x = 12;
              x--;
              Console.WriteLine((x > 3 && x <= 12));


             int num1 = 0;
             int num2 = 0;
             //Display title as the Console C# calculator
             Console.WriteLine("\tConsole Calculator in C#");
             Console.WriteLine("\t----------------------------");

             // Ask user to input the first number
             Console.WriteLine("Input first number: \nand then press Enter");
             num1 = int.Parse(Console.ReadLine());

             //Ask user to input the second number 
             Console.WriteLine("Input second number: \nand then press Enter");
             num2 = int.Parse(Console.ReadLine());

             // Ask user to choose an option.
                Console.WriteLine("Choose an option from the following list: ");
                Console.WriteLine("\tA - Add ");
                Console.WriteLine("\tS - Subtract  ");
                Console.WriteLine("\tM - Multiply ");
                Console.WriteLine("\tD - Divide ");
                Console.WriteLine("\tR - Remainder");
                Console.WriteLine("Your Option? ");
                string action = Console.ReadLine();

              //Use a switch statement to do the math

             switch (action)
             {
                case "A" :
                Console.WriteLine($"Your result : {num1} + {num2} = {num1 + num2}");
                break;
                
                case "S" :
                Console.WriteLine($"Your result : {num1} - {num2} = {num1 - num2}");
                break;
                
                case "M" :
                Console.WriteLine($"Your result : {num1} * {num2} = {num1 * num2}");
                break;
                
                case "D" :
                Console.WriteLine($"Your result : {num1} / {num2} = {num1 / num2}");
                break;

                case "R" :
                Console.WriteLine($"Your result : {num1} % {num2} = {num1 % num2}");
                break;

                default :
                Console.WriteLine("Invalid input!");
                break;
            
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app....");
            Console.ReadKey();*/




          // Question 1

          /*Console.WriteLine("------------- Question 1 -----------");
          Console.WriteLine("Enter your first word :");
          string firstWord = Console.ReadLine();
          int firstWordLength = firstWord.Length;
          Console.WriteLine("Enter your second word :");
          string secondWord = Console.ReadLine();
          int secondWordLength = secondWord.Length;
          int bothWordLength = firstWordLength + secondWordLength;
          int result = (bothWordLength > 20) ? bothWordLength * 3 : bothWordLength + 20;
          Console.WriteLine(result);
          Console.WriteLine();


           Console.WriteLine("----------Question 2-----------------");
           decimal costPrice = 200.876m;
           decimal sellingPrice = 255.425m;
           decimal profit = sellingPrice - costPrice;
           Console.WriteLine($"The Selling price - the cost price is : ${profit}");
           Console.WriteLine($"The profit is ${Math.Round(profit , 2)}");
           Console.WriteLine();


           
           Console.WriteLine("----------Question 3-----------------");
           string word = Console.ReadLine();
           int index = word.IndexOf( word[2]);
           int wordLength = word.Length;
           int newLength = index + wordLength;
           char newResult = (char)newLength;

           Console.WriteLine($"The third character in {word} is : {word[2]}");
           Console.WriteLine($"The length of the {word} is : {wordLength}");
           Console.WriteLine($"The index of the third character is {index}\nThe value added to the string is {wordLength} and the addition is {newLength} and the conversion to character is {newResult}");
           Console.WriteLine();

            Console.WriteLine("----------Question 4-----------------");
            Console.Write("Input your first number:");
            int firstInput = int.Parse(Console.ReadLine());
            Console.Write("Input your second number:");
            int secondInput = int.Parse(Console.ReadLine());
            int greaterNumber = Math.Max(firstInput , secondInput);
            Console.WriteLine($"The greater number is : {greaterNumber}");


            Console.WriteLine("----------Question 5-----------------");
            int sum = 0;
            int i = 0;

            while (i <= 4)
            {
                Console.Write("Please enter an integer:");
                string input = Console.ReadLine();
                int x;
                bool isInteger = int.TryParse(input , out x);

                if (!isInteger)
                {
                    i--;
                    Console.Write("Invalid input! ");
                }
                sum += x;
                i++;
            }
            
            Console.WriteLine($"The sum of the integers are: {sum} ");
            Console.WriteLine();

            
            Console.WriteLine("----------Question 6-----------------");
            const int constantValue = 5;
            Console.Write("Enter first number");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter second number");
            int numberTwo = int.Parse(Console.ReadLine());
            int solution = numberOne + numberTwo - constantValue;
            Console.WriteLine("Enter the correct answer:");
            int correctAnswer = int.Parse(Console.ReadLine());

            string printResult = (correctAnswer == solution) ? "Correct Answer!" : $"Wrong Answer! The correct answer is {solution}";
            Console.WriteLine(printResult);
            Console.WriteLine();

             Console.WriteLine("----------Question 7-----------------");
              Console.WriteLine("Enter a number:");
           int number = int.Parse(Console.ReadLine());
           switch (number)
          {
            case 0:
            Console.WriteLine("Zero");
            break;
            case 1:
            Console.WriteLine("One");
            break;
            case 2:
            Console.WriteLine("Two");
            break;
            case 3:
            Console.WriteLine("Three");
            break;
            case 4:
            Console.WriteLine("Four");
            break;
            case 5:
            Console.WriteLine("Five");
            break;
            case 6:
            Console.WriteLine("Six");
            break;
            case 7:
            Console.WriteLine("Seven");
            break;
            case 8:
            Console.WriteLine("Eight");
            break;
            case 9:
            Console.WriteLine("Nine");
            break;
            default:
            Console.WriteLine("Invalid input!");
            break;*/ 
          



          }

        }   
    }
}

    

    