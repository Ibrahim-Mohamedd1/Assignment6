using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6
{
    internal class Program
    {
        #region Problem 1
        #region Passing by value
        //public static void Swap(int x , int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        #region Passing by Reference
        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        #endregion
        #region Problem 2
        #region passing by value
        //public static int SumArray(int[] Arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //        sum += Arr[i];
        //    return sum;
        //}
        #endregion
        #region passing by Reference
        //public static int SumArray(ref int[] Arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //        sum += Arr[i];
        //    return sum;
        //}
        #endregion
        #endregion
        #region problem 3
        //public static void SumDif(int x , int y , out int Sum, out int Dif)
        //{
        //    Sum = x + y;
        //    Dif = x - y;
        //}
        #endregion
        #region Problem 4
        //public static int CalcSum_individual_digits(ref int x)
        //{
        //    int sum = 0;
        //    while(x > 0)
        //    {
        //        sum += x % 10;
        //        x /= 10;
        //    }
        //    return sum;
        //}
        #endregion
        #region Problem 5
        //public static bool IsPrime(ref int x)
        //{
        //    if (x <= 1)
        //        return false;

        //    for (int i = 2; i < x; i++)
        //    {
        //        if (x % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
        #endregion
        #region Problem 6
        //public static void MinMaxArray(int[] Arr , ref int Max , ref int Min)
        //{
        //    Min = Arr[0];
        //    Max = Arr[0];

        //    for (int i = 1; i < Arr.Length; i++)
        //    {
        //        if (Arr[i] < Min)
        //            Min = Arr[i];

        //        if (Arr[i] > Max)
        //            Max = Arr[i];
        //    }

        //}
        #endregion
        #region Problem 7
        //public static void calculate_the_factoria(ref int x)
        //{
        //    int factorial = 1;
        //    for(int i = x; i >=1; i--)
        //    {
        //        factorial *= i;
        //    }
        //    x = factorial;
        //}
        #endregion
        #region Problem 8
        //public static string ChangeChar(string sentence , char x )
        //{
        //    char[] letters = sentence.ToCharArray();
        //    letters[0] = x;
        //    return new string(letters);
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Problem 1
            #region Passing by value Call
            //int A = 9; int B = 4;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Console.WriteLine("________________________");
            //Swap(A, B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            ////the method do the changes inside the swap stack fram while not affecting the main stack frame
            #endregion
            #region Passing by Reference call
            //int A = 9; int B = 4;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Console.WriteLine("________________________");
            //Swap(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            ////The method do the changes in the main stack fram becouse of the ref that assign the parameters in the main stack the frame
            #endregion
            #endregion
            #region Problem 2
            #region passing by value call
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            ////Makes every variable alone work on the method and the main method
            #endregion
            #region passing by Reference call
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            ////work on the main method by assiging the variable in the SumArray method to the main method
            #endregion
            #endregion
            #region Problem 3 call
            //Console.WriteLine("Enter first Number");
            //int A = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Secound Number");
            //int B = Convert.ToInt32(Console.ReadLine());
            //int SumResult , DifResult;
            //SumDif(A, B, out SumResult, out DifResult);
            //Console.WriteLine($"SumResult : {SumResult}");
            //Console.WriteLine($"DifResult : {DifResult}");
            #endregion
            #region Problem 4 call
            //Console.WriteLine("Enter a Number");
            //int A = Convert.ToInt32(Console.ReadLine());
            //int Sumresult = CalcSum_individual_digits(ref A);
            //Console.WriteLine(Sumresult);
            #endregion
            #region Problem 5 call
            //Console.WriteLine("Enter a Number");
            //int A = Convert.ToInt32(Console.ReadLine());
            //bool Result = IsPrime(ref A);
            //Console.WriteLine($"This Number is {Result} Prime Number");
            #endregion
            #region Problem 6 call
            //int[] numbers = { 1, 3, 4, 9, 7 };

            //int Min = 0;
            //int Max = 0;

            //MinMaxArray(numbers, ref Max, ref Min);
            //Console.WriteLine($"Minimum = {Min}, Maximum = {Max}");
            #endregion
            #region Problem 7 call
            //Console.WriteLine("Enter a Number to Get the Factorial");
            //int A = Convert.ToInt32(Console.ReadLine());
            //calculate_the_factoria(ref A);
            //Console.WriteLine($"Factorial = {A}");
            #endregion
            #region Problem 8 call
            //Console.Write("Enter a Word : ");
            //string word = Console.ReadLine();
            //string result = ChangeChar(word, 'x');
            //Console.WriteLine(result);
            #endregion
        }
    }
}
