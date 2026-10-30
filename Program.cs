/*
* Name: Desmond Goldberg
* Course: CSCI 1250, Section 002
* Assignment: Lab 06, Three Short Problems
* Date: October 23 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

// Outside loops
int userChoice = 0;
Random rng = new Random(4000);

// Menu Loop
// do while: Allows the user to select multiple options until they choose to quit
do
{
  userChoice = 0;
Console.WriteLine("\n=== CSCI 1250 Lab 06 ===\n1. The Grade Checker\n2. The Dice Table\n3. The Score Report\n4. All three\n5. Quit");


// while: The program needs a way to continue prompting until the user inputs an acceptable choice
while (userChoice < 1 || userChoice > 5)
{
  Console.WriteLine("Choose 1 through 5");
  userChoice = Convert.ToInt32(Console.ReadLine());
}

// The Grade Checker
if (userChoice == 1 || userChoice == 4)
{
Console.WriteLine("=== Exercise 1: The Grade Checker ===\n\nWhat is your score?");
int score = 0;
score = Convert.ToInt32(Console.ReadLine());
string grade;

// while: The program needs a way to continue prompting until the user inputs an acceptable score
while (score < 0 || score > 100)
 {
    {
      Console.WriteLine("Invalid score, please try again.");
      score = Convert.ToInt32(Console.ReadLine());
    }
  }






if (score >= 90)
    {
      grade = "an A";
      Console.WriteLine($"{score} earns {grade}.");
    }

else if (score >= 80)
    {
      grade = "a B";
      Console.WriteLine($"{score} earns {grade}.");
    }

else if (score >= 70)
    {
      grade = "a C";
      Console.WriteLine($"{score} earns {grade}.");
    }

else if (score >= 60)
    {
      grade = "a D";
      Console.WriteLine($"{score} earns {grade}.");
    }

else if (score < 60)
    {
      grade = "an F";
      Console.WriteLine($"{score} earns {grade}.");
    }


}

// The Dice Table
if (userChoice == 2 || userChoice == 4)
{

Console.WriteLine("=== Exercise 2: The Dice Table ===\n\nWould you like to roll? Y for Yes and N for no");
string playerChoice;
int roleNumber = 0;
int winCount = 0;
string result;

// do while: Makes sure the program only rolls when the player actually chooses yes
do
{

  playerChoice = Console.ReadLine();

  // while: Propmts the player when they input an invalid character
  while (playerChoice != "Y" && playerChoice != "y" && playerChoice != "N" && playerChoice != "n")
    {
      Console.WriteLine("Please choose either Y or N.");
      playerChoice = Console.ReadLine();
    }

int die1 = rng.Next(1, 7);
int die2 = rng.Next(1, 7);
result = "";

if (playerChoice == "Y" || playerChoice == "y")
{
if (die1 + die2 == 7 || die1 + die2 == 11)
    {
      winCount++;
      result = "A Winner.";
    }

if (die1 == 1 && die2 == 1)
        {
          result = "Snake Eyes.";
        }

if (die1 == die2 && die1 != 1 && die2 !=1)
        {
          result = "Doubles!";
        }
}

if (playerChoice == "Y" || playerChoice == "y")
{
  roleNumber++;
Console.WriteLine($"Role {roleNumber}: {die1} and {die2}, total {die1 + die2}. {result}\nRoll again? (y/n)");
}

// while: Ensures the program only roles if the player input yes
} while (playerChoice == "Y" || playerChoice == "y");

Console.WriteLine($"You rolled {roleNumber} times and won {winCount}.");
}

// The Score Report
if (userChoice == 3 || userChoice == 4)
{
  Console.WriteLine("=== Exercise 3: The Score Report ===\n");
int[] scores = new int[5];

// for: Allows the program to prompt and receive input several times in a single loop
for (int i = 0; i < scores.Length; i++)
    {
      Console.WriteLine($"What is score {i + 1}?");
      scores[i] = Convert.ToInt32(Console.ReadLine());
    }
int total = 0;
int highestScore = 0;
int passingScore = 0;

// foreach: Allows the program to read through each of the inputs and perform the programmed calculations
foreach (int s in scores)
    {
     total += s;
     
     if (s > highestScore)
      {
        highestScore = s;
      }

      if (s >= 60)
      {
        passingScore++;
      } 
    }

double average = (double)total / scores.Length;

Console.WriteLine($"=== Exercise 3: The Score Report ===\nScore 1: {scores[0]}\nScore 2: {scores[1]}\nScore 3: {scores[2]}\nScore 4: {scores[3]}\nScore 5: {scores[4]}");
Console.WriteLine($"\nScores entered: {scores.Length}\nTotal: {total}\nAverage: {average}\nHighest: {highestScore}\nPassing {passingScore} out of {scores.Length}");














}
} while (userChoice != 5);

Console.WriteLine("Goodbye.");
