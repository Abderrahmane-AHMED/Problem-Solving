using System.Collections.Concurrent;
using System.ComponentModel.Design;
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
        do
        {
            Console.WriteLine("Plase Enter A Positive Number ?");
            Number = Convert.ToInt32(Console.ReadLine());

        } while (Number < 0);
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

    static int ReadOf3Number()
    {
        int[] Number = new int[3];

        for (int i = 0; i < Number.Length; i++)
        {
            Console.WriteLine($"Please Inter Number {i + 1} ?");
            Number[i] = Convert.ToInt32(Console.ReadLine());
        }
        return Number.Length;
    }
    static int SumOf3Number(int Number)
    {
        return Number++;
    }
    static void PrintOf3Number(int Number)
    {
        Console.WriteLine($"The Sum Of 3 Number Is {Number}");
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

    }
}