// Thuan (Trae) Tran ID: 113437456
// MIS 3033 HW 1 Task 3

/*
  Create an application that asks the user for their exam score, add their input to an 
accumulator and then ask the user if they have another score to enter.  If they do, ask 
for the exam score and repeat the process until they say no.  Make sure that their 
answer is case insensitive (e.g. they can say Yes or yes and your code treats it the 
same). Once they say no, calculate the average of all of the exam scores based upon 
your accumulator and your counting variable.
Make sure that you use some sort of Loop, an accumulating variable (to keep track of 
the total exam scores), and a counting variable (to keep track of the number of scores 
they entered).

 */


int count = 0; // initialized counter
double sum = 0; // initialized accumulator 

string message = string.Format("Will you enter your exam score?"); // initial message prep
Console.WriteLine(message); // print out yes or no prompt
Console.WriteLine("Answer with yes or no");

string userInput = Console.ReadLine(); // user input


if (userInput == "yes" || userInput == "Yes") // initial question check
{

    while (userInput == "yes" || userInput == "Yes") // while user answers Yes or yes
    {

        Console.WriteLine("Enter exam score");
        double examScoreInput = Convert.ToDouble(Console.ReadLine()); // string input to double
        sum = sum + examScoreInput; // accumulator 
        count++; // counter
        Console.WriteLine("Would you like to add another exam score?"); // repeating message if necessary
        userInput = Console.ReadLine();
        
    } // breaks when user doesn't say yes or Yes

}
else if (userInput == "no" || userInput == "No") // initial question check
{
    Console.WriteLine("You said no");
    Console.WriteLine("Your average will not be calculated");
}
else // initial question check
{
    Console.WriteLine("You said something weird, no average will be calculated."); 
}

double average = sum / count;
Console.WriteLine($"Your average is {average/100:p2}"); // result for average

