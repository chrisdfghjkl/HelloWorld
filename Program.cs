/*
// create a program that lets a user enter a number of daily eggs
// calculate how many can be evenly divided between 4 people + the remainder given to duckbear

Console.WriteLine("How many eggs collected today?");
string dailyEggsInput = Console.ReadLine();

int dailyEggs = int.Parse(dailyEggsInput);

int sisterEggs = dailyEggs / 4;
int duckBearEggs = dailyEggs % 4;

Console.WriteLine("Each sister receives " + sisterEggs + " eggs, and the remaining " + duckBearEggs + " eggs are for duckbear");
*/

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




