using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {
        static void Number1()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator \n");

            InputAndCalculation();
            bool shouldContinue = true;
            while (shouldContinue)
            {
                Console.Write("Continue? y/n: ");
                string choiceToContinue = Console.ReadLine().ToLower();

                switch (choiceToContinue)
                {
                    case "y":
                        InputAndCalculation();
                        break;
                    case "n":
                        shouldContinue = false;
                        break;

                    default:
                        Console.WriteLine(choiceToContinue);
                        break;
                }
            }

            static void InputAndCalculation()
            {
                Console.Write("Enter length: ");
                decimal lengthOfRectangle = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter width: ");
                decimal widthOfRectangle = Convert.ToDecimal(Console.ReadLine());

                decimal areaOfRectangle = lengthOfRectangle * widthOfRectangle;
                Console.WriteLine("Area: {0}", areaOfRectangle);
                decimal perimeterOfRectangle = (2 * widthOfRectangle) + (2 * lengthOfRectangle);
                Console.WriteLine("Perimeter: {0} \n", perimeterOfRectangle);
            }
        }

        static void Number2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator \n");

            ConvertGradeToLetter();

            bool continueToInput = true;
            while (continueToInput)
            {
                Console.Write("Continue? (y/n): ");
                string choiceToContinue = Console.ReadLine().ToLower();

                switch (choiceToContinue)
                {
                    case "y":
                        ConvertGradeToLetter();
                        break;

                    case "n":
                        continueToInput = false;
                        break;

                    default:
                        Console.WriteLine(choiceToContinue);
                        break;
                }
            }

            static void ConvertGradeToLetter()
            {
                Console.Write("Enter numerical grade: ");
                int numericalGrade = Convert.ToInt32(Console.ReadLine());

                if (numericalGrade >= 0 && numericalGrade < 60)
                {
                    Console.WriteLine("Letter Grade: F \n");
                }
                else if (numericalGrade >= 60 && numericalGrade <= 66)
                {
                    Console.WriteLine("Letter Grade: D \n");
                }
                else if (numericalGrade >= 67 && numericalGrade <= 79)
                {
                    Console.WriteLine("Letter Grade: C \n");
                }
                else if (numericalGrade >= 80 && numericalGrade <= 87)
                {
                    Console.WriteLine("Letter Grade: B \n");
                }
                else if (numericalGrade >= 88 && numericalGrade <= 100)
                {
                    Console.WriteLine("Letter Grade: A \n");
                }
                else
                {
                    Console.WriteLine("Please Enter Numerical Grade from 0 to 100 \n");
                }
            }

        }

        static void Number3()
        {
            Console.WriteLine("Welcome to the Download Time Estimator \n\n" +
                "This program calculates how long it will take to download a file with a 56k analog modem. \n");

            DownloadTimeEstimator();

            bool continueInputFileSize = true;
            while (continueInputFileSize)
            {
                Console.Write("Continue? (y/n): ");
                string choiceToContinue = Console.ReadLine().ToLower();

                switch (choiceToContinue)
                {
                    case "y":
                        DownloadTimeEstimator();
                        break;

                    case "n":
                        continueInputFileSize = false;
                        break;

                    default:
                        Console.WriteLine(choiceToContinue);
                        break;
                }
            }

            static void DownloadTimeEstimator ()
            {
                Console.Write("Enter a file size (MB): ");
                decimal fileSize = Convert.ToDecimal(Console.ReadLine());

                decimal inputConversionToKb = fileSize * 1024;

                decimal dataTransferRate = 5.2M;
                decimal timeInSeconds = inputConversionToKb / dataTransferRate;

                int convertedTimeInSeconds = decimal.ToInt32(timeInSeconds);

                TimeSpan unitOfTime = TimeSpan.FromSeconds(convertedTimeInSeconds);
                string timeToDownload = string.Format("A \"56k\" modem will take {0} hours {1} minutes {2} seconds \n",
                    unitOfTime.Hours, unitOfTime.Minutes, unitOfTime.Seconds);

                Console.WriteLine(timeToDownload);
            }
        }

        static void Number4()
        {
            Console.Write("Enter square size: ");
            int sideLength = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= sideLength; row++)
            {
                for (int col = 1; col <= sideLength; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Number1();
            Number2();
            Number3();
            Number4();
        }
    }
}
