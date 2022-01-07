using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            byte b = 5;
            sbyte sb = 5;

            short s = 5;
            ushort us = 5;

            int i = 5;   
            uint ui= 2;

            long l = 5;
            ulong ul = 5;

            float f = 5.0f;
            double d = 5;
            decimal dc = 5;

            char c = 'c';
            string str = "Patika.dev";

            bool b1 = true;
            bool b2 = false;
            bool b3 = 10>2;

            object ob1 = 'o';
            object ob2 = "Patika.dev";
            object ob3 = 4;
            object ob4 = 4.3;

            string textEmpty = string.Empty;
            string txt1 = "Patika";
            string txt2 = ".dev";
            string combinedText = txt1 + txt2;
            Console.WriteLine(combinedText);

            int nm1 = 5;
            int nm2 = 2;
            int totalNumber = nm1+nm2;
            Console.WriteLine(totalNumber);


            string strNumber = "20";
            int number = 20;

            string strTotalNumber = strNumber + number.ToString();
            Console.WriteLine(strTotalNumber);
            int intTotalNumber = number + Convert.ToInt32(strNumber);
            Console.WriteLine(intTotalNumber);
            int intTotalNumberWParse = number + int.Parse(strNumber);
            Console.WriteLine(intTotalNumberWParse);

            
            DateTime dt = DateTime.Now;

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);
            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            #endregion

            #region Operators

            // Assignment Operators
            int a = 5;
            int e = 4;
            a = a+4;
            Console.WriteLine(a);
            a += e;
            Console.WriteLine(a);
            a *= e;
            Console.WriteLine(a);
            a -= e;
            Console.WriteLine(a);
            a /= e;
            Console.WriteLine(a);

            //////////////////////////

            // Logical Operators

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect");
            if(isSuccess || isCompleted)
            Console.WriteLine("Great");
            if(isSuccess && !isCompleted)
            Console.WriteLine("Fine");

            ///////////////////////////

            //Comparison Operators

            int numberA = 3;
            int numberB = 4;
            bool checkNumber = numberA<numberB;
            Console.WriteLine(checkNumber);

            checkNumber = numberA>numberB;
            Console.WriteLine(checkNumber);
            checkNumber = numberA>=numberB;
            Console.WriteLine(checkNumber);
            checkNumber = numberA<=numberB;
            Console.WriteLine(checkNumber);
            checkNumber = numberA==numberB;
            Console.WriteLine(checkNumber);
            checkNumber = numberA!=numberB;
            Console.WriteLine(checkNumber);

            // Arithmetic Operators
            int num1 = 6;
            int num2 = 2;
            int result = num1/num2;
            Console.WriteLine(result);
            result = num1 + num2;
            Console.WriteLine(result);
            result = num1 - num2;
            Console.WriteLine(result);
            result = num1++;
            Console.WriteLine(num1);

            int y = 20;
            int x = 3;
            int result2 = y%x;
            Console.WriteLine(result2);


            //////////////////////////////

            #endregion

        }
    }
}
