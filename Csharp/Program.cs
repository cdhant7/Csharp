
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