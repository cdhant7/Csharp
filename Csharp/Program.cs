//day1
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

//methods in c#
sayHI("Sid",12);
sayHI("John",20);
sayHI("Mike",65);
static void sayHI(string name , int age)
{
    Console.WriteLine("hello " +name + " your age is " + age);
}

int cubedNumber = cube(5);
Console.WriteLine(cubedNumber);
static int cube(int num)
{
    int result = num * num * num;
    return result;
}

//day2
//int x = 30;
//int y = 40;
//if (x > y)
//{
//    Console.WriteLine("x is greater");
//}
//else
//{
//    Console.WriteLine("y is greater");
//}


//Console.WriteLine("enter a number");
//int time=Convert.ToInt32 (Console.ReadLine());


//if (time < 12)
//{
//    Console.WriteLine("Good morning");
//}
//else if (time < 17)
//{
//    Console.WriteLine("Good afternoon");
//}
//else if(time < 21)
//{
//    Console.WriteLine("Good evening");
//}
//else
//{
//    Console.WriteLine("Good Night");
//}



//short hand ifelse

//int time = 10;
//string result = (time < 18) ? "Good day" : "Good evening";
//Console.WriteLine(result);


//switch statement
//Console.WriteLine("Enter the number of month");
//int month=Convert.ToInt32(Console.ReadLine());

//switch (month)
//{
//    case 1:
//        Console.WriteLine("January");
//        break;
//        case 2: Console.WriteLine("february");
//        break;
//        case 3: Console.WriteLine("March");
//        break;
//        case 4: Console.WriteLine("april");
//        break;
//        case 5: Console.WriteLine("May");
//        break;
//        case 6: Console.WriteLine("June");
//        break;
//        case 7: Console.WriteLine("JUly");
//        break;
//        case 8: Console.WriteLine("August");
//        break;
//        case 9:Console.WriteLine("September");
//        break;
//        case 10: Console.WriteLine("October");
//        break;
//        case 11: Console.WriteLine("November");
//        break;
//        case 12: Console.WriteLine("december");
//        break;

//}

//dowhile
//int i = 3;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i <= 10);

//nested for loop 
//for(int i = 1; i <= 3; i++)
//{
//    Console.WriteLine("Sidhant" + i);

//    for(int j = 1; j <= 5; j++)
//    {
//        Console.WriteLine("Sid" + j);
//    }
//}

//break and continue
//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}

//if else using methods
//Console.WriteLine(GetMax(10,18,14));
//static int GetMax(int num1, int num2,int num3)
//{
//    int result;
//    if(num1 >= num2 && num1>=num3)
//    {
//        result = num1 ;
//    }
//     else if(num2>=num1 && num2>=num3)
//    {
//        result = num2;
//    }
//    else {
//        result = num3;
//    }
//    return result;
//}

//calculator
//Console.Write("enter a number ");
//double num1=Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter operator ");
//string op=Console.ReadLine();   

//Console.Write("enter a number ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//if (op=="+")
//{
//    Console.WriteLine(num1+num2);
//}
//else if(op=="-")
//{
//    Console.WriteLine(num1-num2);
//}
//else if (op == "*")
//{
//    Console.WriteLine(num1*num2);
//}
//else if (op == "/")
//{
//    Console.WriteLine(num1/num2);
//}
//else
//{
//    Console.WriteLine("Invalid");
//}

//method overloading

//static int sumMethodInt(int x,int y)
//{
//    return x + y;
//}
//static double sumMethodDouble(double x,double y)
//{
//    return x + y;
//}  

//{
//    int mynum1 = sumMethodInt(5, 5);
//    double mynum2=sumMethodDouble(5.5, 5.5);
//    Console.WriteLine("int: " + mynum1);
//    Console.WriteLine("Double: " +  mynum2);

//}

//day 3
//guessing game

//string secretWord = "Sidhant";
//string guess = "";
//int guessCount = 0;
//int guessLimit = 3;
//bool outOfGuesses = false;
//while (guess != secretWord && !outOfGuesses)
//{
//    if (guessCount < guessLimit)
//    {
//        Console.Write("Enter a guess \n");
//        guess = Console.ReadLine();
//        guessCount++;
//    }
//    else
//    {
//        outOfGuesses = true;
//    }
//}
//    if (outOfGuesses)
//    {
//        Console.Write(" You Lose!!");
//    }
//    else
//    {
//        Console.Write(" You won!!");
//    }

//exponent method

//Console.WriteLine(GetPow(3, 5));
//static int GetPow(int baseNum,int powNum)
//{
//    int result = 1;
//    for (int i=0;i<powNum;i++)
//    {
//        result=result*baseNum;  
//    }
//    return result;
//}

//2D array
//int[,] numbers =  //[,] indicates csharp that it is 2d array
//{
//    {1,2 },
//    {3,4 },
//    {5,6 }
//};

//Console.WriteLine(numbers[0,1]);


//exception handling
try
{
    Console.Write("Enter a number\n");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter another number\n");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}
catch (DivideByZeroException e)  //we can specify type of exception or can generally define all sorts of exception
{
    Console.WriteLine(e.Message);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}

