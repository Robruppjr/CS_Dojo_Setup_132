//-variables
// make a variable type int 'dogAge', set it equal to 12
// make a variable type string 'dogName' , set it equal to "Rover"
// make a variable type string 'ownerName', set it equal to "Steve"
// make a variable type decimal 'dogPrice', set it equal to $5000
// make a variable type bool 'isPapered', set it equal to true

int dogAge = 12;
string dogName = "Rover"; 
string ownerName = "Steve";
decimal dogPrice = 5000m;
bool isPapered = true;

// -types
// make a variable type DateTime 'dogBirthDay', and set the values equal to (2010,11,10) //hint use the 'new' key word after the =

DateTime dogBirthDay = new DateTime(2010,11,10);

// make a enum of type DogBreed {American_Bully,German_Shepard,Doberman,two more of whatever breed that you want}(this should be in a different file)



// make a variable type DogBreed 'DogBreed' and assign the value DogBreed.German_Shepard

// -operators
// make a variable type int 'employees', set its value to 20

// increment the value of employees by 1.
// Console.WriteLine("The amt of employees we have is" + employees);

// decrement the value of employees by 5.
// Console.WriteLine("The amt of employees we have is" + employees);

// make a variable of type int 'ValueA', set it equal to 20.
// make a variable of type int 'ValueB', set it equal to 5.

// make a variable of type int 'addition', set it equal to ValueA + ValueB
// Console.WriteLine("addition equals:" + addition);

// make a variable of type int 'subtraction', set it equal to ValueA - ValueB
// Console.WriteLine("subtraction equals:" + subtraction);

// make a variable of type int 'multiplication' , set it equal to ValueA * ValueB
// Console.WriteLine("multiplication equals:" + multiplication);

// make a variable of type int 'division', set it equal to ValueA / ValueB
// Console.WriteLine("division equals:" + division);

// make a variable of type int 'modulus', set it equal to ValueA % ValueB
// Console.WriteLine("modulus equals:" + modulus");

// set 'ValueA', equal to 80.
// set 'ValueB', equal to 3.
// set 'modulus', equal to ValueA % ValueB
// Console.WriteLine("modulus equals:" + modulus);

// -strings

// make a variable of type string 'thisDogBelongsTo' , set it equal to "This dog belongs to: ";
// make a variable of type string 'concat01', set it equal to thisDogBelogsTo + dogOwner;
// Console.WriteLine(concat01);

// make a variable of type string 'thisDogsBirthdayIs' , set it equal to "This dogs birthday is: 11/10/2010";
// make a variable of type string 'concat02', set it equal to thisDogAgeIs + dogAge;
// Console.WriteLine(concat02);

// make a variable of type string 'iBoughtTheDogFor' , set it equal to "I bought the dog for ";
// make a variable of type string 'composite01', set it equal to string.Format("{0},{1}",iBoughtTheDogFor,dogPrice);
// Console.WriteLine(composite01);

// Using string interpolation
// make the Console.WriteLine say
// "Steve, bought the dog for 5000. The dog Rover's, birthday is !"



// -Booleans
// bool isGreaterThan =20>20;
// bool isGreaterThanOrEqualTo = 20>=20;
// Console.WriteLine($"20 > 20 is {isGreaterThan}, and 20 >= 20 is {isGreaterThanOrEqualTo}");

// bool isLessThan = 50 < 50;
// bool isLessThanOrEqualTo = 50 <= 50;
// Console.WriteLine($"50 < 50 is {isLessThan}, while 50 <= 50 is {isLessThanOrEqualTo}");

// bool equality = 97 == 9;
// bool inequality = 97 !=9;
// Console.WriteLine($"97 == 9 and 97 != 9 are {equality} and {inequality}, respectively.");