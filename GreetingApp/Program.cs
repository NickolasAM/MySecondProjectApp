
//Welcome User To App
Console.WriteLine("Welcome to the Greeting Application");
Console.WriteLine("This application was built by Nicko Marquez");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();


//Ask for First Name
Console.WriteLine("What is your full name: ");
string firstName;                       //camel casing (first letter lowercse, industry standard way at appraoching VARIABLE    `  naming

firstName = Console.ReadLine();

string lastName;
lastName = Console.ReadLine();

//Greet user by name
Console.WriteLine();
Console.WriteLine("Hello " + firstName + "I see your last name is" + lastName);

Console.WriteLine("Thank you for using my application.");
Console.ReadLine();