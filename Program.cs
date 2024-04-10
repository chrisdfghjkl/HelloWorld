/*
// create a program that lets a user enter a number of daily eggs
// calculate how many can be evenly divided between 4 people + the remainder given to duckbear

Console.WriteLine("How many eggs collected today?");
string dailyEggsInput = Console.ReadLine();

int dailyEggs = int.Parse(dailyEggsInput);

int sisterEggs = dailyEggs / 4;
int duckBearEggs = dailyEggs % 4;

Console.WriteLine("Each sister receives " + sisterEggs + " eggs, and the remaining " + duckBearEggs + " eggs are for duckbear");


//create a application that lets a user enter assortment of property: provinces, duchies, and estates.
//each property type adheres to point system - provinces - 6pt, duchies - 3pt, and estates - 1pt
//application should take 3 strings, convert them to numbers, add and return total

//------Take user input
Console.WriteLine("How many estates do you have?");
string estateInput = Console.ReadLine();
Console.WriteLine("How many duchies do you have?");
string duchyInput = Console.ReadLine();
Console.WriteLine("How many provinces do you have?");
string provinceInput = Console.ReadLine();

//------Convert user input to number - int since you can't own partial property - anc calculate score
int estateScore = int.Parse(estateInput) * 1;
int duchyScore = int.Parse(duchyInput) * 3;
int provinceScore = int.Parse(provinceInput) * 6;

//------Calc total holding score
int holdingScore = estateScore + duchyScore + provinceScore;

Console.WriteLine("You have a holding score of " + holdingScore + "!");

//create app that takes in target row and column, and computes where to place neighboring
//squad members on grid and displays them per challenge directions (alignment, color, result beep)
//Result format:

//Target Row? 6
// Target Column? 5
// Deploy to:
// (6, 4)
// (5, 5)
// (6, 6)
// (7, 5)
Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
string rowInput = Console.ReadLine();
Console.Write("Target Column? ");
string columnInput = Console.ReadLine();

int rowNum = int.Parse(rowInput);
int columnNum = int.Parse(columnInput);

Console.Beep();
Console.WriteLine("Deploy to:");
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"({rowNum}, {columnNum - 1})");
Console.WriteLine($"({rowNum - 1}, {columnNum})");
Console.WriteLine($"({rowNum}, {columnNum + 1})");
Console.WriteLine($"({rowNum + 1}, {columnNum})");

Console.WriteLine("Enter score: ");
string scoreText = Console.ReadLine();

int score = int.Parse(scoreText);

if (score == 100)
{
    Console.WriteLine("A+ Wow Congrats!");
}
else if (score == 99)
{
    Console.WriteLine("So close!");
}
else if (score == 50)
{
    Console.WriteLine("Pretty bad!");
}
else
{
    Console.WriteLine("Try again");
}

//Clocktower challenge -- create a program that takes in a number
//and returns 'tick' if even and 'tock' if odd

Console.WriteLine("Enter swing number:");
string input = Console.ReadLine();
int swing = int.Parse(input);

if (swing % 2 == 0)
{
    Console.WriteLine("Tick!");
}
else
{
    Console.WriteLine("Tock!");
}

//Ternary operator in c#:
Console.WriteLine("What is your score?");
string input = Console.ReadLine();
int score = int.Parse(input);
string textToDisplay = score > 70 ? "You passed!" : "You failed :(";
Console.WriteLine(textToDisplay);
*/
