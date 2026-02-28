using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class ProblemSolving
{
    #region  Problem 1 Read Name And Print It  
    static string ReadName()
    {
        string Name;
        Console.WriteLine("Please Enter Your Name ? ");
        Name = Console.ReadLine();

        return Name;
    }
    static void PrintName()
    {
        string Name = ReadName();

        Console.WriteLine($"Your Name Is : {Name} ");
    }
    #endregion

    #region    problem 2 Odd Or Even 
    enum OddOrEven { Odd = 1, Even = 2 };
    static int ReadPositiveNumber()
    {
        int Number;
        Console.WriteLine("Plase Enter A Positive Number ?");
         while(!int.TryParse(Console.ReadLine(), out Number) || Number < 0)
        {
            Console.WriteLine("-:( Plase Enter A Positive Number ?");
        }

        return Number;
    }
    static OddOrEven CheckNumber(int Number)
    {


        if (Number % 2 == 0)
            return OddOrEven.Even;
        else
            return OddOrEven.Odd;
    }
    static void PrintOddOrEven(int Result, OddOrEven oddOrEven)
    {

        Console.WriteLine($"Your Number {Result} Is {oddOrEven}");
    }
    #endregion

    #region  problem 3  Hire A Driver Case 1

    struct  stReadInfo
    {
        public short Age;
        public short DriverLicense;

    }
    static stReadInfo ReadInfo()
    {
        stReadInfo info = new stReadInfo();
        short Age;
        short DriverLicense;

        do
        {
            Console.WriteLine("Please Enter Your Age ?");
            Age = Convert.ToInt16(Console.ReadLine()) ;
        }while(Age < 0);

        do
        {
            Console.WriteLine("Do Your Have A Driver License ( Yes 1 : No 0 )?");
            DriverLicense = Convert.ToInt16(Console.ReadLine());

        }while(DriverLicense != 1 && DriverLicense != 0);
        

        info.Age = Age;
        info.DriverLicense = DriverLicense;
        return info;
    }
    static bool CheckInfo(stReadInfo info)
    {
        
        //if(info.Age >= 21 &&  info.DriverLicense == 1)

        //    return true ;
        //else
        //    return false ;

         return (info.Age > 21 && info.DriverLicense != 0);
    }
    static void PrintHiredOrRejectes(stReadInfo info)
    {
        if (CheckInfo(info))
            Console.WriteLine("You Are Hire :-)");
        else
            Console.WriteLine("You Are Rejected :-( ");

    }
    #endregion

    #region Problem 4 Hire A Driving Case 2
    struct stReadInfoCase2
    {
        public short Age;
        public short DrivingLicense;
        public string HasRecommend;

    }
    static stReadInfoCase2 ReadInfoCase2()
    {
        stReadInfoCase2 info  = new stReadInfoCase2();

        do
        {
            Console.WriteLine("Do You Have Recommend ?");
            info.HasRecommend = Convert.ToString(Console.ReadLine());
        } while (info.HasRecommend != "Yes" && info.HasRecommend != "No");

        if(info.HasRecommend == "Yes")
            return info;

        do
        {
            Console.WriteLine("Please Enter Your Age ?");
            info.Age = Convert.ToInt16(Console.ReadLine());
        } while (info.Age < 0);

        do
        {
            Console.WriteLine("Do You Have A Driving License ?");
            info.DrivingLicense = Convert.ToInt16(Console.ReadLine());
        }while(info.DrivingLicense != 1 && info.DrivingLicense != 0);

        return info;
    }
    static bool CheckInfoCase2(stReadInfoCase2 info)
    {
       if (info.HasRecommend == "Yes")
            return true;
       else
        {
            if (info.Age > 21 && info.DrivingLicense == 1)
                return true;
            else
                return false;

        }


    }
    static void PrintResultCase2(stReadInfoCase2 info)
    {
        if (CheckInfoCase2(info))
        {
            Console.WriteLine("You Are Hire :-) ");
        }
        else
            Console.WriteLine("You Are Rejected :-( ");
    }
    #endregion

    #region Problem 5 Full Name 

    struct stReadInfoName
    {
        public string FirstName;
        public string LastName;
    }
    static stReadInfoName ReadInfoName()
    {
       
        stReadInfoName info = new stReadInfoName();
        Console.WriteLine("Please Enter Your First Name ?");
        info.FirstName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Please Enter Your Last Name ?");
        info.LastName = Convert.ToString(Console.ReadLine());

        return info;
    }
    static string GetFullName(stReadInfoName info , bool Reversed)
    {
        string FullName = "";

        if(Reversed)
            FullName = info.LastName + " " + info.FirstName;
        else
           FullName = info.FirstName + " " + info.LastName;    

        return FullName;
    }
    static void PrintFullName(stReadInfoName info)
    {
        string fullName = GetFullName(info , true);
        Console.WriteLine($"Your Full Name Is : {fullName}");
    }
    #endregion

    #region Problem 6 Half Number
    static int ReadNumber()
    {
        int Number;
        Console.WriteLine("Plase Enter A Number ?");
        Number = Convert.ToInt32(Console.ReadLine());

        return Number;

    }
    static float HalfNumber(float number)
    {
        return(number / 2 );
    }
    static void PrintHalfNumber(int Number ,float Half)
    {
        
        Console.WriteLine($"Half Of The {Number} is {Half}");
    }
    #endregion

    #region Problrm 7 Pass Or Fail
    enum enPassOrFail { Pass = 1 , Fail = 0}
    static int ReadMark()
    {
        int Mark;
        do
        {
            Console.WriteLine("Please Enter Your Mark ?");
            Mark = Convert.ToInt32(Console.ReadLine());
        } while (Mark < 0 || Mark > 100);

        return Mark;
    }
    static enPassOrFail CheckMark(float Mark)
    {
        if (Mark  >= 50)
        {
            return enPassOrFail.Pass;
        }
        else
            return enPassOrFail.Fail;
    }

    static void PrintPassOrFail(int Mark , enPassOrFail Result)
    {
         
            Console.WriteLine($"Your Mark Is {Mark} You Are {Result}");
        
    }
    #endregion

    #region Problem 8 Sum Of 3 Number 

    static int[] ReadOf3Number()
    {
        int[] Number = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Please Inter Number {i + 1} ?");
            Number[i] = Convert.ToInt32(Console.ReadLine());
        }
        return Number;
    }
    static int SumOf3Number(int[] Number)
    {
        int sum = 0;
        for(int i = 0; i < Number.Length; i++)
        {
            sum += Number[i];
        }
      
        return sum;
    }
    static void PrintOf3Number(int[] Number , int Result)
    {
        Console.WriteLine($"The Sum Of ( {Number[0]} + {Number[1]} + {Number[2]} ) Is {Result}");
    }
    #endregion

    #region Problem 9 Average Of 3 Marks Case 1
     static float[] ReadOf3Marks()
    {
        float[] Marks = new float[3];
        for(int i = 0; i < 3;i++)
        {
            Console.WriteLine($"Plaese Enter Mark {i + 1} ?");
            Marks[i] = Convert.ToInt64(Console.ReadLine());
        }
        return Marks;
    }
    static float CalculatAverageOf3Marks(float[] Marks)
    {
        float Average = 0;
        for (int i = 0; i < Marks.Length; i++) 
        {
            Average += Marks[i];
        }
        return(Average/3);

    }
    static void PrintAverageOf3Marks(float[] Marks , float Average)
    {
        Console.WriteLine($"The Average Of {Marks[0]} + {Marks[1]} + {Marks[2]}  is {Average} ");
    }
    #endregion

    #region Problem 10 Average Of 3 Marks Case 2 Pass Or Fail 
    enum enAverageOf3MarksPassOrFail { Pass = 1 , Fail = 0}
    static enAverageOf3MarksPassOrFail CheckAverage(float Average)
    {
        if (Average >= 50)
            return enAverageOf3MarksPassOrFail.Pass;
        else
            return enAverageOf3MarksPassOrFail.Fail;
    }
    static void PrintAveragOf3MarksPassOrFail(float[] Marks , float Average , enAverageOf3MarksPassOrFail Resulte )
    {
        Console.WriteLine($"The Average Of {Marks[0]} + {Marks[1]} + {Marks[2]} = {Average} You Are {Resulte}");
    }
    #endregion

    #region Problem 11 Max Of 2 Number 
     
    static int[] Read2Number()
    {
        int[] Number = new int[2];
        for(int i = 0; i < 2 ; i++)
        {
            Console.WriteLine($"Please Enter Number {i + 1} ?");
            while(!int.TryParse( Console.ReadLine(), out Number[i] ))
            {
                Console.WriteLine($":-( Invalid Input Please Enter Number {i} ? )");
            }
        }
        return Number;
    }
    static int CheckMaxNumber(int[] Number)
    {
  
        return (Number[0] < Number[1]  ? Number[1] : Number[0]);
    }
    static void PrintMaxOf2Number(int[] Number , int Max)
    {
             Console.WriteLine ($"The Max Of  {Number[0]} , {Number[1]}   is {Max} ");
    }
    #endregion

    #region Problem 12  Max Of 3 Number 

    static int[] Read3Number()
    {
        int[] Number = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Please Enter Number {i + 1} ?");
            Number[i] = Convert.ToInt32(Console.ReadLine());
        }
        return Number;
    }
    static int CheckMaxOf3Number(int[] Number)
    {
         int max = Number[0];
        for (int i = 0; i < Number.Length; i++)
        {
            if (Number[i] > max)
            max = Number[i];
                
        }
        return max;
    }
    static void PrintMaxOf3Number(int[] Number, int Max)
    {
        Console.WriteLine($"The Max Of  {Number[0]} , {Number[1]}  , {Number[2]}  is {Max} ");
    }
    #endregion

    #region Problem 13 Swap Number 
    static int[] Read2NumberForSwap()
    {
        int[] Number = new int[2];

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Please Enter A Number {i + 1} ?");
            Number[i] = Convert.ToInt32 (Console.ReadLine());
        }

        return Number;
    }
    static int[] Swap2Number(int[] Number)
    {
       
        int[] Swap  = (int[])Number.Clone() ;
        int Temp;
        Temp = Swap[0];
        Swap[0] = Swap[1];
        Swap[1] = Temp;

        return Swap;

    }
    static void PrintSwap(int[] Number , int[] Swap)
    {
        Console.WriteLine($"Your Number Is {Number[0]} And {Number[1]} \n\nAftar Swap Is {Swap[0]} And {Swap[1]} ");
    }


    #endregion

    #region Problem 14 Rectangle Area   
    static float[] ReadRectangleArea()
    {
        float[] Number = new float[2];
        for(int i = 0; i < 2;i++)
        {
            if (i == 0)
                Console.WriteLine("Please Enter A Width Of Area ?");
            else
                Console.WriteLine("Please Enter A Heigth Of Area ?");

            Number[i] = Convert.ToSingle(Console.ReadLine());
        }
        return Number;
    }
    static float CalculetRectangleArea(float[] Number)
    {
        float Area = (Number[0] * Number[1]);
        return Area;
    }
    static void PrintRectangleArea(float[] Number , float Area)
    {
        Console.WriteLine($"The Rectangle Area For Width {Number[0]} And Heigth {Number[1]}  =  {Area}");
    }
    #endregion

    #region Problem 15 Circle Area Arbitrary Triangle
    static float[] ReadCircleAreaArbitraryTriangle()
    {
        float[] Number = new float[3];
        string[] Prompts = { "a", "b", "c" };
        for(int i = 0;i < 3;i++)
        {
            Console.WriteLine($"Please Enter A Circle Area {Prompts[i]}");
            Number[i] = Convert.ToInt64 (Console.ReadLine());
        }
        return Number;
    }
    static double CalculteCircleArea(float[] Number)
    {
        const double PI = 3.141;
        double a = Number[0];
        double b = Number[1];
        double c = Number[2];

        double P = (Number[0] + Number[1] + Number[2]) / 2;
        double T = (Number[0] * Number[1] * Number[2])/ (4 * Math.Sqrt ( P* (P-Number[0]) * (P-Number[1]) * (P-Number[2])));

        double Area = PI * Math.Pow(T, 2);
        return Area;

    }
    
    static void PrintCircleAreaArbitraryTriangle(float[] Number , double CircleArea)
    {
        Console.WriteLine($"The Circle Area Arbitrary Triangle a = {Number[0]} , b = {Number[1]} , c = {Number[2]} = {CircleArea} ");
    }
    #endregion

    #region Problem 16 Validate Age Case 1
   
    static int ReadAge()
    {
        int Age;
        bool IsValid;
        do
        {
            Console.WriteLine("Please Enter Your Age ?");

            IsValid = int.TryParse(Console.ReadLine(), out Age);

            if(!IsValid)
            {
                Console.WriteLine(":-(  Please Entar A Valid Age ( Number ) ?");
            }
          
        } while (!IsValid || Age <= 0);
        return Age;
    }
    static bool IsValidAge(int Age)
    {
        return (Age >= 18 && Age <= 45);
    }
    static void PrintResultValidOrInValid(int Age )
    {
        
        if(IsValidAge(Age))
        Console.WriteLine($"Your Age {Age} Is A Valid You :-)  ");
        else
        Console.WriteLine($"Your Age {Age} Is A Invalid :-( ");
    }
    #endregion

    #region Problem 17 Validate Age Case 2
    static short ReadAgeCase2()
    {

        short Age;
        bool IsValid;
        do
        {
            Console.WriteLine("Please ENter Your Age Between 18 and 45 ?");
            IsValid = short.TryParse(Console.ReadLine(), out Age);
            if (!IsValid || Age < 18 || Age > 45)
                Console.WriteLine("InValid Age :-( ");
        } while (!IsValid || Age < 18 || Age > 45);


        Console.WriteLine("Please ENter Your Age Between 18 and 45 ?");

        while (!short.TryParse(Console.ReadLine() , out Age) ||Age < 18 || Age > 45 )
        {
            Console.WriteLine("Please ENter Your Age Between 18 and 45 ?");
         
        }
        return Age;
    }
    #endregion

    #region Problem 18 Print Number From 1 To N
    static int ReadNumberForLoop()
    {
        int Number;

        Console.WriteLine("Please Enter A Number ?");

        while(!int.TryParse(Console.ReadLine(), out Number) || Number <= 0)
        {
            Console.WriteLine("Please Enter A Positive Number ");
        }
        return Number;
    }
    static void PrintResultForLoop(int Number)
    {
        Console.WriteLine("For Loop Statement ");
        for (int i = 1; i <= Number; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("While Loop Statement ");
        int j = 1;
        while (j <= Number)
        {
            Console.WriteLine(j);
            j++;
       
        }
        Console.WriteLine("Do While Loop Statement ");
        int k = 1;
        do
        {
            Console.WriteLine(k);
            k++;
        }while (k <= Number);
       
    }
    #endregion

    #region Problem 19 Sum Odd Number From 1 To N
    static void PrintSumOddNumber(int Number) 
    {
        Console.WriteLine("For Loop Statement ");
        int Sum = 0;
        for(int i = 1;i <= Number;i++)
        {
            if (i % 2 != 0)
            {
                Sum += i;
            }
          
        }
        Console.WriteLine(Sum);

        Console.WriteLine("While Loop Statement ");

        int j = 1;
        int SumWhile = 0;
        while(j <= Number)
        {
            if(j % 2 != 0)
            {
                SumWhile += j;
            }
            j++;
        }
        Console.WriteLine(SumWhile);

        Console.WriteLine("Do While Loop Statement ");
        int k = 1;
        int SumDoWhile = 0;
        do
        {
         if(k % 2 != 0)
            {
                SumDoWhile += k;
            }
         k++;
        }while (k <= Number);

               
        Console.WriteLine(SumDoWhile);
    }
    #endregion

    #region Problem 20 Factorial Of N 
    static void PrintFactorialOfN(int Number)
    {
        Console.WriteLine("For Loop Statement");
        int factorial = 1;
        for(int i = Number ; i >= 1; i--)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);

        Console.WriteLine("While Loop Statement");
        int j = 1;
        while(j >= Number)
        {
            factorial *= j;
            j--;
        }
        Console.WriteLine(factorial);

        Console.WriteLine("Do While Loop Statement");
        int k = 1;
        do
        {
            factorial *= k;
            k--;
        }while (k >= Number);

        Console.WriteLine(factorial);
    }
    #endregion

    #region Problem 21 Power  Of 2 : 3 : 4


    static int[] PowerOfNumber(int Number)
    {
        int[] Power= new  int  [3];
        int Result = Number;
        
         for(int i = 0; i < 3 ; i++)
        {
            Result  *= Number;
            Power[i] = Result;

        }
         return Power;
    }
    static void PrintPowerOf(int[] Power)
    {
        Console.WriteLine($"Power Of 1 = {Power[0]} \nPower Of 2 = {Power[1]} \nPower Of 3 = {Power[2]}");
    }

    #endregion

    #region Problem 22 Power Of Number
    static int[] ReadNumberForPower()
    {
        int[] Number = new int[2];
        string[] Prompts = { "Number", "Power" };

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Please enter A {Prompts[i]} ?");
            Number[i] = Convert.ToInt32 ( Console.ReadLine() );
        }
        return Number;
    }
    static int PowerNumberOfN(int[] Number)
    {
        int Power = 1;
       
        if (Number[1] == 0)
        {
           return  1;
        }
        for(int i = 0; i < Number[1]; i++)
        {
            Power *= Number[0];
        }

        return Power;
    }

    static void PrintPowerNumbeOfN(int[] Number , int Result)
    {
        Console.WriteLine($"The Number {Number[0]} of Power {Number[1]} = {Result} ");
    }

    #endregion

    #region  Problem 23 Grade A -> F 

    static int ReadGrade()
    {
        int Number;
        Console.WriteLine("Please Enter Your Grade ?");
        while (!int.TryParse(Console.ReadLine(), out Number) || Number <= 0 || Number >= 100) 
        {
            Console.WriteLine("-:( Please Enter A Valid Grade Number And Between ( 0 - 100 ) ?");
        }
        return Number;
    }
    static char CheckGrade(int Number)
    {
        // With If Else  
        if (Number >= 90)
            return 'A';
        else if (Number >= 80)
            return 'B';
        else if (Number >= 70)
            return 'C';
        else if (Number >= 60)
            return 'D';
        else if (Number >= 50)
            return 'E';
        else
            return 'F';

        // With Switch

        switch (Number / 10)
            {
                case 10:
                case 9:
                    return 'A';
                case 8:
                    return 'B';
                case 7:
                    return 'C';
                case 6:
                    return 'D';
                case 5:
                    return 'E';
                default:
                    return 'F';

            }


    }
    static void PrintGrade(int Number , char Characrar)
    {
        Console.WriteLine($"Your Grade Is {Number} You Are {Characrar}");
    }
    #endregion

    #region Problem 24 Commission Percentage
    static double GetCommissionPercentage(int Number)
    {
        int Percentage = 0;

        if (Number > 1000000)
            return (  0.01);
        else if (Number > 500000)
            return (0.02);
        else if (Number > 100000)
            return (0.03);
        else if (Number > 50000)
            return (Number % 0.05);
        else
            return (Number % 0);
    }
    static double CalculetPercentage(int Number , double Percentage)
    {
            return ( Percentage * Number);
    }
    static void PrintCommissionPercentage(int Number, double Commission , double TotaleSales) 
    {
        Console.WriteLine($"Your Precentage Is {Number} Your Commission Is {Commission} Totale Sales = {TotaleSales}");
    }
    #endregion

    #region Problem 25 Piggy Bank Calculator
    static int[] ReadMoney()
    {
        int[] Money = new int[5];
        string[] Prompts = { "Peinnies", "Nickels", "Dimes", "Quarters", "Dollars" };
      
        for(int i = 0; i < Money.Length; i++)
        {
            Console.WriteLine($"How Much Do You Have {Prompts[i]}");
            Money[i] = Convert.ToInt32(Console.ReadLine());
        }
        return Money;
    }
    static float CalculetPenny(int[] Number)
    {
         int TotalePiennies = Number[0] * 1 + Number[1] * 5 + Number[2] * 10 + Number[3] * 25 + Number[4] *100;

        return TotalePiennies ;
    }

    static void PrintResultPiggyBank(float Penny)
    {
        Console.WriteLine($"You Have {Penny} Pennies \nAnd Have {Penny / 100} Dollars");
    }
    #endregion

    #region Problem 26 Simple Calculator  Salution 1

    struct  stInfoForCalculator
    {
      public int[] Number ;
     

      public  string OpertionType;
    }
    static stInfoForCalculator ReadInfoForCalculator()
    {
        stInfoForCalculator Info;

        Info.Number = new int[2];
  
        for(int i =0; i < Info.Number.Length; i++)
        {
            Console.WriteLine($"Please Enter Number {i + 1} ?");

            while(!int.TryParse(Console.ReadLine(), out Info.Number[i]))
            {
                Console.WriteLine($"Invalid :-( Please Enter Number {i + 1} ?");
            }

            
        }

        do
        {
            Console.WriteLine("Please Enter Operation Type ( * , / , + , - ) ?");
            Info.OpertionType = Convert.ToString(Console.ReadLine());

        } while (Info.OpertionType != "*" && Info.OpertionType != "/" && Info.OpertionType != "+" && Info.OpertionType != "-");

        return Info;

    }
    static float CalculateInfo(stInfoForCalculator Info)
    {
        if (Info.OpertionType == "*")
            return Info.Number[0] * Info.Number[1];
        else if (Info.OpertionType == "/")
        {
            while (Info.Number[1] == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero. Please enter Number 2 again:");

                while (!int.TryParse(Console.ReadLine(), out Info.Number[1]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }
            }


            return (float)Info.Number[0] / Info.Number[1];
        }

        else if (Info.OpertionType == "+")
            return Info.Number[0] + Info.Number[1];
        else
            return Info.Number[0] - Info.Number[1];

    }
    static void PrintResultSimpleCalculator(stInfoForCalculator Info , float Result)
    {
        Console.WriteLine($"Result = {Info.Number[0]} {Info.OpertionType} {Info.Number[1]} = {Result}");
    }
    #endregion

    #region Problem 26 Simple Calculator Salution 2 
    enum enOpertionType { Addition = 1 , Subtraction  =  2 , Multiplication =  3  , Division = 4}
    static enOpertionType ReadOprationType()
    {
        string Operation = "";

       
       Console.WriteLine("Please Enter Operation Type ( * , / , + , - ) ?");
        Operation = Console.ReadLine();

        while (Operation != "*" &&  Operation != "/" && Operation != "+" && Operation != "-")
        {
          

            Console.WriteLine(":-( Invalid Input Please Enter Operation Type ( * , / , + , - ) ?");

            Operation = Console.ReadLine();
        }

        if(Operation == "*") 
            return enOpertionType.Multiplication;
        else if(Operation == "/")
            return enOpertionType.Division;
        else if(Operation == "+")
            return enOpertionType.Addition;
        else 
            return enOpertionType.Subtraction;
 
    }

    static float Calculate2NumberSimple(int[] Number , enOpertionType Operation)
    {

        switch (Operation)
        {
            case enOpertionType.Multiplication:
                return Number[0] * Number[1];
            case enOpertionType.Division:
                while (Number[1] == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero. Please enter Number 2 again:");

                    while (!int.TryParse(Console.ReadLine(), out Number[1]))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number:");
                    }
                }

                return (float)Number[0] / Number[1];
            case enOpertionType.Addition:
                return Number[0] + Number[1];
            case enOpertionType.Subtraction:

                return Number[0] - Number[1];
            default:
                throw new Exception("Invalid Operation");
        }
    }
    static void PrintResultSimpleCalculatorSalution2(enOpertionType OpertionType, int[] Number , float Result)
    {
        Console.WriteLine($"Result = {Number[0]} {OpertionType} {Number[1]} = {Result}");
    }
    #endregion

    #region  Problem 27 Sum Number Until You Say No
    static List<int> ReadNumberUntilNo()
    {
        List<int> Numbers = new List<int>();
        string input = "";
        int TempNum = 0;
      

        while (true) 
        {
            Console.WriteLine($"Please Enter Number {Numbers.Count + 1} (or type 'No' to stop):");

            input = Console.ReadLine();


            if (input.ToLower() == "no")
            {
                
                break;
            }

          

            while (!int.TryParse(input, out TempNum))
            {
                Console.WriteLine($":-( Invalid input. Please enter a valid number for Number {Numbers.Count + 1} (or 'No' to stop):");
               
                input = Console.ReadLine();

                if (input.ToLower() == "no")
                {
                    return Numbers;
                }
            }
      
            
                Numbers.Add(TempNum);
           
           
        }


     return Numbers;


    }
    static int SumNumberUntilNo(List<int> Numbers)
    {

        int count = 0;
        int sum = 0;

        for (int i = 0; i < Numbers.Count; i++)
        {
            sum += Numbers[i];
            count++;
        }

        return sum;
    }

    static void PrintSumNumberUntilNo(List<int>  numbers , int sum)
    {
         Console.WriteLine($"You Are Enter {numbers.Count} Numbers The Sum Of This Number Is {sum}");
    }
    #endregion

    #region  Problem 28 Number Is Prime Or Not Prime 
    enum enPrimeOrNotPrime { Prime = 1 , NotPrime = 0 }
    static enPrimeOrNotPrime CheckNumberPrimeOrNotPrime(double Number)
    {
       
        double M = Math.Round(Number / 2);
        for (int i = 2; i <= M; i++)
        {
            if (Number % i == 0)
                return enPrimeOrNotPrime.NotPrime;
        }
            return enPrimeOrNotPrime.Prime;
       
           
        
    }
    static void PrintIsPrimeOrNotPrime(double Number , enPrimeOrNotPrime NumberIs)
    {
        Console.WriteLine($"Your Number {Number} is {NumberIs}");
    }
    #endregion

    #region  ATM PIN
    static int ReadPINCode()
    {

        string InputLength ;
        int TempNumber;
        Console.WriteLine("Please Enter PIN Code ?");
     

        while (true)
        {
            InputLength = Console.ReadLine();

          
            if(InputLength.Length == 4 && int.TryParse(InputLength ,out TempNumber))
            {
              return TempNumber;  
            }
            else
            
                Console.WriteLine(":-( Wrong Pin Code Please Enter 4 Number ?");
         
        }

       
        return TempNumber;
    }

    static void PrintAmount(int Number)
    {
        
        if (Number == 1234)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your Account balance is 7500 ");
        }
        else
        {
          
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Wrong PIN Code");
        }
        Console.ResetColor();
    }
    #endregion
    static void Main(string[] Args)
    {

        // Problem 1 Read Name And Print

        //PrintName();

        // Problem 2 Odd Or Even 

        //int Number = ReadPositiveNumber();
        //OddOrEven Result = CheckNumber(Number);
        //PrintOddOrEven(Number, Result);


        // Problem 3 Hire A Driver Case 1 

        //stReadInfo Rusult = ReadInfo();
        //PrintHiredOrRejectes(Rusult);

        // Problem 4 Hire A Driver Case 2

        //stReadInfoCase2 Rusult2 = ReadInfoCase2();

        // PrintResultCase2(Rusult2);


        // Problem 5 Get Full Name 
        //stReadInfoName info = ReadInfoName();
        //PrintFullName(info);

        // Problem 6 Half Number 

        //int Number = ReadNumber();
        //float Half = HalfNumber(Number);
        //PrintHalfNumber(Number , Half);


        // Problem 7 Pass Or Fail 

        //int Mark = ReadMark();
        //enPassOrFail Result  = CheckMark(Mark);
        //PrintPassOrFail(Mark, Result);

        //Problem 8 Sum Of 3 Number 

        //int[] Number = new int[3];
        //Number = ReadOf3Number();
        //int Sum = SumOf3Number(Number);
        //PrintOf3Number(Number , Sum);

        //Problem 9 Average Of 3 Marks Case 1

        //float[] Marks = new float[3];
        //Marks = ReadOf3Marks();
        //float Average = CalculatAverageOf3Marks(Marks);
        //PrintAverageOf3Marks(Marks , Average);

        //Problem 10 Average Of 3 Marks Case 2 Pass Or Fail 

        //float[] Marks = new float[3];
        //Marks = ReadOf3Marks();
        //float Average = CalculatAverageOf3Marks(Marks);
        //enAverageOf3MarksPassOrFail Result = CheckAverage(Average);
        //PrintAveragOf3MarksPassOrFail(Marks, Average, Result);

        //Problem 11 Max Of 2 Number 

        //int[] Number = new int[2];
        //Number = Read2Number();
        //int Max = CheckMaxNumber(Number);
        //PrintMaxOf2Number (Number, Max);


        //Problem 12 Max Of 2 Number 

        //int[] Number = new int[3];
        //Number = Read3Number();
        //int Max = CheckMaxOf3Number (Number);
        //PrintMaxOf3Number(Number, Max);

        //Problem 13 Swap 2 Number 

        //int[] Number = new int[2];
        //Number = Read2NumberForSwap();
        //int[] Swap = Swap2Number(Number);
        //PrintSwap(Number, Swap);

        //Problem 14 Rectangle Area 

        //float[] Number = new float[2];
        //Number = ReadRectangleArea();
        //float Area = CalculetRectangleArea(Number);
        //PrintRectangleArea(Number, Area);

        //Problem 15 Circle Area Arbitrary Triangle

        //float[] Number = new float[3];
        //Number = ReadCircleAreaArbitraryTriangle();
        //double Result = CalculteCircleArea(Number);
        //PrintCircleAreaArbitraryTriangle(Number , Result);

        //Problem 16 Validate Age Case 1 

        //int Age = ReadAge();
        //PrintResultValidOrInValid (Age);

        //Problem 17 Validate Age Case 1 

        //short Age = ReadAgeCase2();

        //Problem 18 Print Number From 1 To N

        //int Number = ReadNumberForLoop();
        //PrintResultForLoop(Number);

        //Problem 19 Print Sum Odd Number From 1 To N

        //int Number = ReadNumberForLoop();
        //PrintSumOddNumber (Number);

        //Problem 20 Factorial Of N

        //int Number = ReadNumberForLoop();

        //PrintFactorialOfN (Number);

        //Problem 21 Power Of  2 : 2 : 3 

        //int Number = ReadPositiveNumber();
        //int[] Power = PowerOfNumber(Number);
        //PrintPowerOf(Power);

        //Problem 22 Power Number Of N 

        //int[] Number = ReadNumberForPower();
        //int Result = PowerNumberOfN(Number);
        //PrintPowerNumbeOfN(Number , Result);

        //Problem 23 Check Grade

        //int Number = ReadGrade();
        //char Characrar = CheckGrade(Number);
        //PrintGrade(Number , Characrar);

        //Problem 24 Commission Percentage 

        //int Number = ReadPositiveNumber();
        //double precentage = GetCommissionPercentage(Number);
        //double TotaleSales = CalculetPercentage(Number, precentage);
        //PrintCommissionPercentage(Number, precentage, TotaleSales);

        //Problem 25 Piggy Bank Calculator 

        //int[] Money = ReadMoney();
        //float Penny = CalculetPenny(Money);
        //PrintResultPiggyBank(Penny);

        //Problem 26 Simple Calculator Salution 1

        //stInfoForCalculator Info = new stInfoForCalculator();

        //Info = ReadInfoForCalculator();
        //float Result = CalculateInfo(Info);
        //PrintResultSimpleCalculator(Info, Result);

        //Problem 26 Simple Calculator Salution 2

        //int[] Number = new int[2];
        //Number = Read2Number();
        //enOpertionType OpertionType = new enOpertionType();
        //OpertionType = ReadOprationType();
        //float Result  = Calculate2NumberSimple(Number , OpertionType);
        //PrintResultSimpleCalculatorSalution2(OpertionType, Number, Result);


        //Problem 27  Sum Number Until You Say No
       
        //List<int> numbers = new List<int>();
        //numbers = ReadNumberUntilNo();
        //int sum = SumNumberUntilNo(numbers);
        //PrintSumNumberUntilNo(numbers , sum);

        //Problem 28 Number Is Prime Or Not Prime 
        //int Number = ReadPositiveNumber();
        //enPrimeOrNotPrime NumberIs = CheckNumberPrimeOrNotPrime (Number);
        //PrintIsPrimeOrNotPrime(Number , NumberIs);

        //Problem 29 ATM PIN Code

        int Number = ReadPINCode();
        PrintAmount(Number);
       

    }
}