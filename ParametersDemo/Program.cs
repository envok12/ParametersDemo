using System;

namespace ParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass by value #2
            /*  Console.WriteLine("Pass by value test:");
              int testVal1 = 1;
              Console.WriteLine("Original value {0}", testVal1);
              Test(testVal1);
              Console.WriteLine("Returned value: {0}", testVal1);
            */

            //Pass in a reference type #3
            /* Console.WriteLine("\nPass in a reference type test:");
             int[] testArray = { 1, 1, 1 };
             Console.WriteLine("Original value: {0}", testArray[0]); //Prints 1
             TestArray(testArray); //Calls TestArray method
             Console.WriteLine("Returned value: {0}", testArray[0]);
            */

            //Out parameter test #4
            /*Console.WriteLine("\nOut Parameter Test:");
            int testVal2;
           // Console.WriteLine("Original value: {0}", testVal2);
            TestOut(out testVal2);  //Calls method and out changes to 222
            Console.WriteLine("Returned value: {0}", testVal2); //Prints 222 again due to out parameter
            */

            //Ref Parameters test #5
            /*Console.WriteLine("\nRef parameter test:");
            int testVal3 = 3;
            Console.WriteLine("Original value is {0}", testVal3);
            TestRef(ref testVal3);  //Calls method and ref will modify the original value
            Console.WriteLine("Returned value: {0}", testVal3); //The original value is now changed
            */

            //Optional Parameters #6
            /*Console.WriteLine("\nCalling TestOptional with a parameter");
            TestOptional(4); //Calls method and passes 4 into aValue

            //Optional parameter passed with no parameters
            Console.WriteLine("\nCalling TestOptional with no parameter");
            TestOptional(); //Will print the original assignment (444)
            */

            //Multiple and Named Parameters #7
            /*Console.WriteLine("\nTestMultiple all three set");
            TestMultiple(1, 2, 3); //Calls TestMultiple and sets values in order 1, 2, 3

            //Multiple Parameters, not all set
            Console.WriteLine("\nTestMultiple set just first two");
            TestMultiple(1, 2); //Changes aValue to 1, bValue to 2, cValue stays 333

            //Multiple Parameters with named parameter
            Console.WriteLine("\nTestMultiple set just first 2");
            TestMultiple(1, cValue: 3);  //Sets aValue to 1, bValue stays 222, cValue set to 3
            */

            //Overloaded Methods #8
            Console.WriteLine("\nTest overloaded method with string");
            TestOverloaded("Test with string"); //Find method with string

            Console.WriteLine("\nTest overloaded method with numbers");
            TestOverloaded(5, 5.5);



        }

        public static void TestOverloaded(string strParam) //Method 1 #8 for string
        {
            Console.WriteLine("String overload called with a value of {0}", strParam);
        }

        public static void TestOverloaded(int intParam, double dblParam) //Method 2 #8 for int & dbl
        {
            Console.WriteLine("Numeric overload called with values of {0} and {1}", intParam, dblParam);
        }

        public static void TestMultiple(int aValue, int bValue = 222, int cValue = 333) //Method for #7
        {
            Console.WriteLine("Inside TestMultiple -" + "Values: " + "{0}, {1}, {2}", aValue, bValue, cValue);

        }

        public static void TestOptional(int aValue = 444)  //Method for #6
        {
            Console.WriteLine("In TestOptional Value is {0}", aValue);
        }

        public static void TestRef(ref int aValue) //Method for #5
        {
            aValue = 333;
            Console.WriteLine("In TestRef Value is {0}", aValue);
        }

        public static void TestOut(out int aValue) //Method for #4
        {
            aValue = 222;
            Console.WriteLine("In TestOut Value is {0}", aValue);
        }
        public static void TestArray(int[] anArray) //Method for #3
        {
            anArray[0] = 111;
            Console.WriteLine("In Test Value is {0}", anArray[0]);  //Arrays are passed by ref so elements of original array are changed
        }
        public static void Test(int aValue) //Method for #2
        {
            aValue = 111;
            Console.WriteLine("In test Value is {0}", aValue);
        }
        //The method Test copies testVal1 into aValue but doesn't change the original so prints 1, 111, 1

       



    }
}
