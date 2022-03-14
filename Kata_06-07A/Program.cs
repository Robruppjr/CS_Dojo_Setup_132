//Ask the user "What is your age"
System.Console.WriteLine("What is your age?");
//Store the user input in a variable 'age'
int age = int.Parse(Console.ReadLine());

//Use if statements to determine if the userInput is 'of age' to drink
//if age < 5 && age >=0 -> print "I'm calling your parents!"
if( age < 5 && age >=0 ) 
{
    System.Console.WriteLine("I'm calling your");
}
//else if age < 10 -> print "Come on? are you serious?"
else if (age < 10 ) 
{ 
System.Console.WriteLine("Come on? are you serious?");
}
//else if age < 18 -> print "Sorry you are too young to drink, come back in three years!"
else if (age < 18)
{
    System.Console.WriteLine("Sorry you are too young to drin, come back in three years!");
}
//else if if age >= 21 -> print "Hawdy, What can I get you to drink!"
else if (age >= 21)
{
    System.Console.WriteLine("Hawdy, What can I get you to drink!");
}
//else -> print "Invalid Option, please try again."
else 
{
    System.Console.WriteLine("Ivalid Option, please try again.");
}

//use a terinary operator to check if a persons age using the age variable above 
//to check if the person is a child or not   
//so if a persons age is greater than 12 the he/she is not a child, else 
//the person is a child 

string isAChildOrNot = age >= 12 ? "You are not a child." : "You are a child";
System.Console.WriteLine(isAChildOrNot);


//Create an 'Array of int' that can hold a total of 10 items
int[] ArrayOfInt = new int[10];
//Create a 'decimal' Array that can hold 5 names
decimal[] ArrayOfDecimal = new decimal[5];
//Create a 'string' Array that can hold 5 names
string[] ArrayOfString = new string[5];
//Create a 'bool' Array that can hold 5 names
bool[] ArrayOfBool = new bool [5];


//Create a 'List<int>' childAges ,that can hold a total of 5 times
List<int> childAges = new List<int>(5);
//Create a 'List<decimal>' grades ,that can hold a total of 5 times
List<decimal> grades = new List<decimal>(5);
//Create a 'List<string>' teacherNames ,Array that can hold 5 names
List<string> teacherNames = new List<string>(5);

//while loop -> while loop through the variable childAges, grades, and teacherNames

//for loop -> for loop through the variable childAges, grades, and teacherNames

//foreach loop -> foreach through the variable childAges, grades, and teacherNames
foreach (int ageOfChild in childAges)
{
    System.Console.WriteLine(ageOfChild);
}
foreach (decimal grade in grades)
{
    System.Console.WriteLine(grade);
}
foreach (string teacher in teacherNames)
{
    System.Console.WriteLine(teacher);
}
//do while loop -> do while loop through the variable childAges, grades, and teacherNames