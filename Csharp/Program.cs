
//variable
string characterName = "Sid";
int characterAge;
characterAge = 25;
Console.WriteLine("There was a man named " + characterName);
Console.WriteLine("He was " + characterAge + " years old");
characterName = "johnathon";
Console.WriteLine("He liked his name " + characterName);
Console.WriteLine("He was sad about his age being " + characterAge);

Console.WriteLine("this is me \n sidhant");

//string operations concat,length,touppercase lowercase
string phrase = "this is my first concat" + " of the string";
Console.WriteLine(phrase);
Console.WriteLine(phrase.Length);
Console.WriteLine(phrase.ToUpper());
Console.WriteLine(phrase[12]);
Console.WriteLine(phrase.Substring(12, 3));

//numbers
Console.WriteLine(5 + 6);
int num = 7;
num++;
Console.WriteLine(num);
Console.WriteLine(Math.Pow(3.5, 2));
Console.WriteLine(Math.Max(3.5, 2));
Console.WriteLine(Math.Sqrt(36));
Console.WriteLine(Math.Min(4, 5));

//getting user inputs
Console.Write("Enter your name ");
string name = Console.ReadLine();
Console.Write("Enter your age ");
string age = Console.ReadLine();
Console.WriteLine("Hello " + name + " your age is " + age);
Console.ReadLine();

//simple calculator
Console.Write("enter a number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter another number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num1 + num2);

//madlib
string color, pluralNoun, celebrity;
Console.Write("Enter a color");
color = Console.ReadLine();

Console.Write("Enter a pluralNoun");
pluralNoun = Console.ReadLine();

Console.Write("Enter a celebrity");
celebrity = Console.ReadLine();

Console.WriteLine("Roses are " + color);
Console.WriteLine(pluralNoun +" are blue ");
Console.WriteLine("I love " + celebrity);
Console.ReadLine();

//arrays
int[] showNumbers = {2,4,6,8,13,56,34,66,88 };
Console.WriteLine(showNumbers[5]);
