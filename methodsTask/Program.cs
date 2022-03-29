using System;
namespace methodsTask {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Task 1.");
            sayHello();
            Console.WriteLine("\n\n Task 2.");
            Welcome("Dees");
            Console.WriteLine("\n\n Task 3.");
            Console.WriteLine(" {0}",AddTwoNumbers(69, 420));
            Console.WriteLine("\n\n Task 4.");
            int numSpaces = numOfSpaces();
            Console.Write(" {0} spaces", numSpaces);
            Console.WriteLine("\n\n Task 5.");
            int sumOfArrayOfNumbers = sumOfArray();
            Console.WriteLine(" the sum of the elements in the array is {0}", sumOfArrayOfNumbers);
            Console.WriteLine("\n\n Task 6.");
            runTask6();
            Console.WriteLine("\n\n Task 7.");
            int numberRTE = numberRaisedToExponent();
            Console.WriteLine(numberRTE);
            System.Console.WriteLine("\n\n Task 8.");
            fibToN(69);
            System.Console.WriteLine("\n\n Task 9.");
            Console.Write(" enter a number");
            int numToCheckIfPrime = 0;
            bool isValid = int.TryParse(Console.ReadLine(), out numToCheckIfPrime);
            bool numisPrime = isPrime(numToCheckIfPrime);
            Console.WriteLine(numisPrime ? "is prime" : "Is not prime");
            System.Console.WriteLine("\n\n Task 10.");
            int task10Bucker = sumOfDigits();



        }
        static void sayHello() {Console.WriteLine(" Welcome Friends!\n Have a nice day!");}
        static void Welcome(string inputName) {Console.WriteLine(" Welcome Friend {0} !\na nice day!", inputName);}
        static int AddTwoNumbers(int number1, int number2) {return number1 + number2;}
        static int numOfSpaces() {Console.Write(" Please enter a string : "); string inputString = Console.ReadLine();Console.Write("\n {0} has", inputString);return inputString.Split().Length -1;}
        static int sumOfArray() {int[] tempSpaceArray = new int[5];for(int i =0; i<5;i++) {Console.Write(" element {0} : ",i);try {tempSpaceArray[i] = Int32.Parse(Console.ReadLine());}catch {Console.WriteLine("something when wrong!");i--;}}int bucket =0;for(int j = 0; j<tempSpaceArray.Length; j++){bucket += tempSpaceArray[j];}return bucket;}
        static void runTask6() {int number1 =0;int number2 =0;bool number1Valid = int.TryParse(Console.ReadLine(), out number1);if (number1Valid) {bool number2Valid = int.TryParse(Console.ReadLine(), out number2); if(number2Valid) {swapNumbers(number1, number2);Console.WriteLine(" number 1 : {0}\n number 2 : {1}", number2, number1); }}else {runTask6();}}
        static void swapNumbers(int num1, int num2) {int swapSpace = num1;num1 = num2;num2 = swapSpace;}
        static int numberRaisedToExponent() {int number =0;int exponent =0;bool numberIsValid = int.TryParse(Console.ReadLine(), out number);bool exponentIsValid = int.TryParse(Console.ReadLine(), out exponent);if (numberIsValid && exponentIsValid) {return Convert.ToInt32(Math.Pow(Convert.ToDouble(number),  Convert.ToDouble(exponent)));} else {numberRaisedToExponent();return 0;}}   
        static void fibToN(int n ) {int a = 0;int b = 1;Console.Write(" 0");while(b <= n) {Console.Write(", {0}",b);int oldB = b;b += a;a = oldB;}}
        static bool isPrime(int number) {int timesCorrect = 0;for( int i = number; i > 0; i--) {if (number % i == 0) {timesCorrect ++;}}if (timesCorrect == 2) {return true;} else {return false;}}
        static int sumOfDigits() {List<string> numbersUC = new List<string>();int bucket = 0;string unconvertedDigits = Console.ReadLine();foreach(Char number in unconvertedDigits) {numbersUC.Add(Convert.ToString(number));}foreach(string n in numbersUC) {bucket += Convert.ToInt32(n);}System.Console.WriteLine(bucket);return bucket;}
    }
}