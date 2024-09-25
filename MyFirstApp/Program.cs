// This is comment to my code

//Rakendus küsib kasutajal sisestada tema nime
//Rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //Output
//string=sõne
string userName;

userName = Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!"); //Output

//string interpolation
Console.WriteLine($"Hello, {userName} !"); //Output