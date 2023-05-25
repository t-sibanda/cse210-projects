using System;

class LetterGradeCalculator
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage.
        Console.WriteLine("What is your grade percentage? ");
        float gradePercentage = float.Parse(Console.ReadLine());

        // Write a series of if-elif-else statements to print out the appropriate letter grade.
        string letterGrade = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.
        bool passed = gradePercentage >= 70;
        if (passed)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do it next time.");
        }

        // Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
        string sign = "";
        if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }

        Console.WriteLine("Your letter grade is {0}{1}", letterGrade, sign);

        // Stretch Challenge

        // Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. For each grade, you'll know it is a "+" if the last digit is >= 7. You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.

        // After your logic to determine the grade letter, add another section to determine the sign. Save this sign into a variable. Then, display both the grade letter and the sign in one print statement.
        if (letterGrade == "A" && sign == "+")
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else
        {
            Console.WriteLine("Your letter grade is {0}{1}", letterGrade, sign);
        }

        // Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.
        if (letterGrade == "F")
        {
            Console.WriteLine("Your letter grade is F.");
        }
        else
        {
            Console.WriteLine("Your letter grade is {0}{1}", letterGrade, sign);
        }
    }
}