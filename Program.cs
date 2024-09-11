
// <------------------- INTEGERS  ------------------->
int age = 22;
int newAge;
newAge = age + 1;
Console.WriteLine(age);
Console.WriteLine(newAge);



// <------------------- STRINGS  ------------------->
String address = "Karachi sindh paksitan";
Console.WriteLine(address);
string firstName = "Hassaan";
string lastName = "Ali";

string fullname = firstName + " " + lastName;
Console.WriteLine(firstName);
Console.WriteLine(lastName);
Console.WriteLine(fullname);

int a = 1;
int b = 2;
int sum = a + b;
int mul = a * b;
int sub = a + b;

// <------------------- STRING AND NUMBER CONCATENATION  ------------------->
Console.WriteLine($"Sum = {sum}, mul = {mul}, sub = {sub}");

// < ------------------- DIFFERENT APPROACH OF CONCATENATION OLD METHOD ------------------->
Console.WriteLine("a + b = {0}, a - b = {1}, a * b = {2}", (a+b), (a-b),(a*b));


//// <------------------- DOUBLE SHORT MEMOERY DATATYPE  ------------------->
//double dec = 1.4;
//Console.WriteLine($"Decimal Values: {dec}");

//// <------------------- FLOATING LONG MEMOERY DATATYPE  ------------------->
//float floatValue = 34.2323232323f;
//Console.WriteLine(floatValue);


// <------------------- TAKING STRING AND STORING IN THE VARIABLE ------------------->
string name;

Console.Write("Enter your Name: ");
name = Console.ReadLine();

Console.WriteLine($"User name is: {name}");

// <------------------- TAKING INT NUMBER STORING IN THE VARIABLE ------------------->

int userAge;
Console.Write("Enter your Age: ");
// <------------------- ReadLine() ureturn String by default we can use parsing method to parse in any of our required variable ------------------->
userAge = int.Parse(Console.ReadLine()!);

Console.WriteLine($"User age is: {userAge}");

