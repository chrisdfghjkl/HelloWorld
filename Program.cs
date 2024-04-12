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

//Watchtower challenge-- create app that allows user to enter x & y coordinate
//and return a direction
string direction = "";
Console.WriteLine("Enemy X coordinate:");
string xInput = Console.ReadLine();
Console.WriteLine("Enemy Y coordinate:");
string yInput = Console.ReadLine();

double xNum = double.Parse(xInput);
double yNum = double.Parse(yInput);

if (yNum > 0)
{
    if (xNum < 0) direction = "northwest";
    else if (xNum == 0) direction = "north";
    else if (xNum > 0) direction = "northeast";
}
else if (yNum == 0)
{
    if (xNum < 0) direction = "west";
    else if (xNum == 0) direction = "here";
    else if (xNum > 0) direction = "east";
}
else if (yNum < 0)
{
    if (xNum < 0) direction = "southwest";
    else if (xNum == 0) direction = "south";
    else if (xNum > 0) direction = "southeast";
}

string towerReport = direction == "here" ? "The enemy is here!" : $"The enemy is to the {direction}!";
Console.WriteLine(towerReport);

Console.WriteLine("The following items are available:");
Console.WriteLine($"1 – {"Rope",20}");
Console.WriteLine($"2 – {"Torches",20}");
Console.WriteLine($"3 – {"Climbing Equipment",20}");
Console.WriteLine($"4 – {"Clean Water",20}");
Console.WriteLine($"5 – {"Machete",20}");
Console.WriteLine($"6 – {"Canoe",20}");
Console.WriteLine($"7 – {"Food Supplies",20}");
Console.Write("What number do you want to see the price of? ");
int input = int.Parse(Console.ReadLine());
int gold = 0;

if (input == 1) { gold = 10;}
else if (input == 2) { gold = 15;}
else if (input == 3) { gold = 25;}
else if (input == 4) { gold = 1;}
else if (input == 5) { gold = 20;}
else if (input == 6) { gold = 200;}
else if (input == 7) { gold = 1;}


Console.Write("Enter your name: ");
string name = Console.ReadLine();

if (name == "Chris") gold = gold / 2;

string priceCheck;

priceCheck = input switch
{
    1 => $"Rope costs {gold} gold",
    2 => $"Torches cost {gold} gold",
    3 => $"Climbing Equipment costs {gold} gold",
    4 => $"Clean Water costs {gold} gold",
    5 => $"Machetes cost {gold} gold",
    6 => $"Canoes cost {gold} gold",
    7 => $"Food Supplies cost {gold} gold",
    _ => "Invalid selection"
};

Console.WriteLine(priceCheck);


while (true)
{
    Console.Write("Think of a number: ");
    string input = Console.ReadLine();

    if (input == "quit" || input == "exit")
    {
        break;
    }

    int number = int.Parse(input);

    if (number == 12)
    {
        Console.WriteLine("Pick a different number please.");
        continue;
    }

    Console.WriteLine($"{number} is a great choice! It's one less than {number + 1}");
}


int totalRows = 5;
int totalColumns = 10;
for (int currentRow = 1; currentRow <= totalRows; currentRow++)
{
    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
        Console.Write("*");
    Console.WriteLine();
}

while (true)
{
    Console.Write("User 1-- Enter a number between 0 and 100: ");
    string input = Console.ReadLine();
    
    if (input == "quit" || input == "exit")
    {
        Console.WriteLine("Quitting...");
        break;
    }

    int number = int.Parse(input);

    if (number < 0 || number > 100)
    {
        Console.WriteLine("Please choose a different number");
        continue;
    }
    Console.Clear();
    Console.WriteLine("User 2-- Guess the number");
    while (true)
    {
        Console.Write("What is your next Guess? ");
    
        int guess = int.Parse(Console.ReadLine());

        if (guess < number)
        {
            Console.WriteLine($"{guess} is too low.");
            continue;
        }

        if (guess > number)
        {
            Console.WriteLine($"{guess} is too high.");
            continue;
        }

        if (guess == number)
        {
            Console.WriteLine("Correct!");
            Console.WriteLine("Closing...");
            break;
        }
    }

    break;
}


for (int currentTurn = 1; currentTurn <= 100; currentTurn++)
{
    if (currentTurn % 3 == 0 && currentTurn % 5 == 0)
    {
        Console.WriteLine($"{currentTurn}: Combo Blast!");
    } 
    else if (currentTurn % 3 == 0)
    {
        Console.WriteLine($"{currentTurn}: Fire");
    }
    else if (currentTurn % 5 == 0)
    {
        Console.WriteLine($"{currentTurn}: Electric");
    }
    else
    {
        Console.WriteLine($"{currentTurn}: Normal");
    }
}
*/
