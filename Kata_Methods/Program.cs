using System;

Console.Clear();
Console.WriteLine("--Welcome to Wallys Job Application App---");

//Ask the user for their name:
Console.WriteLine("Please Enter your Name: ");

//store the value w/n a variable
string? userName = Console.ReadLine();

//ask the user for their address
Console.WriteLine("Please Enter your Address: ");
string? userAddress = Console.ReadLine();

//ask for the users phone number
System.Console.WriteLine("Please Enter your Phone Number: ");
string? userPhoneNumber = CheckPhoneNumberLength(Console.ReadLine());//make method that checks if the phoneNumber length is correct

//make a method called 'DisplayApplicantDetails' that takes in a 'string userName'
//string 'userAddress', and 'string userPhoneNumber'
void DisplayApplicantDetails(string userName, string userAddress, string userPhoneNumber)
{
    Console.Clear();
    System.Console.WriteLine("--Applicant Data--");
    System.Console.WriteLine($" UserName: {userName}\n UserAddress: {userAddress}\n UserPhoneNumber: {userPhoneNumber}\n");
    System.Console.WriteLine("-------------------------------------------------------------");
}

DisplayApplicantDetails(userName, userAddress, userPhoneNumber);

string CheckPhoneNumberLength(string userInputPhoneNumber)
{
    if (userInputPhoneNumber.Length != 12)
    {
        System.Console.WriteLine("Sorry Please Try again. Press Any Key to continue.");
        Console.ReadKey();
        Console.Clear();

        //ask the user again for their phone number
        Console.WriteLine("Please Enter your Phone Number.");

        //this is a simple form of recursion -> a method calling itself
        string value = CheckPhoneNumberLength(Console.ReadLine());
        if (value.Length == 12)
        {
            return value;
        }
    }
    else if (userInputPhoneNumber.Length == 12)
    {
        return userInputPhoneNumber;
    }
    return null;
}