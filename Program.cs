using System;
using System.Collections;
using System.Collections.Generic;

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

            //////////////////////////////

            #region Type Conversion

            //Implicit Conversion

            byte by = 2;
            short sh = 10;
            ushort ush = 15;

            int res = by+sh+ush;
            Console.WriteLine("res: " + res);

            long lg = res;
            Console.WriteLine("lg: " + lg);

            float fl = lg;
            Console.WriteLine("fl: " + lg);

            string st = "Patika.de";
            char chr = 'v';

            object rs = st+chr;
            Console.WriteLine(rs);

            //Explicit Conversion

            float w = 3.3f;
            int itg = (int)w;
            Console.WriteLine("itg: " + itg);

            int itg2 =  5;
            byte byt = (byte)itg2; 
            Console.WriteLine("byt: " + itg2);

            //

            // ToString
            int yy = 20;
            string zz = yy.ToString();
            Console.WriteLine("zz: " + zz);

            //

            // Convert
            string ss = "10";
            int tt = Convert.ToInt32(ss);
            Console.WriteLine("ss: " + ss);

            //

            // Parse
            string ff = "10.3";
            double dd = double.Parse(ff);
            Console.WriteLine("ff: " + ff);

            //

            #endregion

            TryCatchFunc();
            IfElseIfFunc();
            SwitchCaseFunc();
            ForLoopFunc();
            WhileForEachFunc();
            ArrayFunc();
            ArrayMethodsFunc();

            Console.WriteLine("**** Addition ****");

            int additionA = 3;
            int additionB = 2;
            Console.WriteLine($"Toplam Sayı : {additionA+additionB}");

            int additionTotal = AdditionFunc(additionA,additionB);
            Console.WriteLine($"Toplam Sayı : {additionTotal}");

            Methods _methodsCls = new Methods();
            _methodsCls.PrintToScreenFunc($"Toplam Sayı : {additionTotal}");

            int plusAddition = _methodsCls.PlusAndAdditionFunc(ref additionA, ref additionB);
            _methodsCls.PrintToScreenFunc($"Toplam Sayı : {plusAddition}");
            Console.WriteLine($"Toplam Sayı : {additionA+additionB}");

            Console.WriteLine("**** Methods Overloading ****");

            string outString = "999";
            int outNumber;
            bool outNumberResult = int.TryParse(outString,out outNumber);

            if(outNumberResult)
            {
                Console.WriteLine("Başarılı.");
                Console.WriteLine(outNumber);
            }
            else
            {
                Console.WriteLine("Başarısız.");
            }

            int addNumberResult;

            _methodsCls.OutPlusAndAdditionFunc(4,5,out addNumberResult);
            Console.WriteLine($"Toplam Sayı : {addNumberResult}");

            string overLoadString1 = "Patika.dev";
            string overLoadString2 = "Patika";
            string overLoadString3 = ".dev";
            int overLoadInt = 3;

            _methodsCls.OverloadPrintToScreenFunc(overLoadString1);
            _methodsCls.OverloadPrintToScreenFunc(overLoadString2, overLoadString3);
            _methodsCls.OverloadPrintToScreenFunc(overLoadInt);

            Console.WriteLine("**** Recursive ****");

            Console.WriteLine(_methodsCls.RecursiveFunc(3,4));
            Console.WriteLine(_methodsCls.Factorial(3));

            Console.WriteLine("**** Extension ****");
            string name = "Patika .dev";
            int[] unsortedArray = {3,1,17,6,39,22,4,8};
            int isNumberEven = 5;

            Console.WriteLine(name.CheckSpaces());
            Console.WriteLine(name.RemoveSpaces());
            Console.WriteLine(name.MakeUpperCase());
            Console.WriteLine(name.MakeLowerCase());

            unsortedArray.SortArray();
            unsortedArray.PrintToScreenIntArray();

            Console.WriteLine(isNumberEven.IsEven());

            _methodsCls.StringMethod();
            _methodsCls.DateTimeMethods();

            CollectionsGenericFunc();
            CollectionsArrayListFunc();



        }

        public static void TryCatchFunc()
        {
            try
            {
                //Console.WriteLine("Bir sayi giriniz : ");
                //int a = int.Parse(Console.ReadLine());
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("200000000000");
            }
            //catch(Exception ex)
            //{
            //   Console.WriteLine("Bir hata olustu : " + ex.Message.ToString());
            //}
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
            
        }
    
        public static void IfElseIfFunc()
        {
            int time = DateTime.Now.Hour;

            if(time>6 && time<11)
                Console.WriteLine("Günaydın.");
            else if(time<18)
                Console.WriteLine("İyi günler.");
            else
                Console.WriteLine("İyi akşamlar.");

            string result = time<18 ? "İyi günler." : "İyi akşamlar.";
            Console.WriteLine(result);

            result = time>6 && time<11 ? "Günaydın." : time<18 ? "İyi günler." : "İyi akşamlar.";
            Console.WriteLine(result);               
        }

        public static void SwitchCaseFunc()
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız.");
                    break;
                
                default:
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    break;
                
                default:
                break;
            }

        }
    
        public static void ForLoopFunc()
        {
            for (int i = 1; i <=20; i++)
            {
                if(i%2==1)
                    Console.WriteLine(i);
                
            }


            int totalOddNumber = 0;
            int totalEvenNumber = 0;
            for (int i = 1; i <=20; i++)
            {
                if(i%2==1)
                    totalOddNumber += i;
                else
                    totalEvenNumber += i;
            }

            Console.WriteLine("Toplam tek sayi : " + totalOddNumber);
            Console.WriteLine("Toplam çift sayi : " + totalEvenNumber);

            for (int i = 0; i <= 5; i++)
            {
                if(i==3)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 5; i++)
            {
                if(i==2)
                    continue;
                Console.WriteLine(i);
            }


        }

        public static void WhileForEachFunc()
        {
            int number = 5;
            int counter = 1;
            int totalNumber = 0;

            while (counter<=number)
            {
                 totalNumber += counter;
                 counter++;
            }

            Console.WriteLine("Sayının ortalaması : " + totalNumber/number);

            char character = 'a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine();

            string[] items = {"itemA", "itemB", "itemC", "itemD"};
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    
        public static void ArrayFunc()
        {
            string[] animals = {"Kedi", "Köpek", "Kuş",};
            Console.WriteLine(animals[2]);

            string[] colors = new string[4];
            colors[0] = "Mavi";
            Console.WriteLine(colors[0]);

            int[] numbers;
            numbers = new int[3];
            numbers[0] = 10;
            Console.WriteLine(numbers[0]);

            //////////////
            Console.Write("Lütfen dizinin uzunluğu için bir sayı giriniz : ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Lütfen dizinin {0}. elemanı için bir sayı giriniz : ", i+1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int totalNumber = 0;
            foreach (var number in array)
            {
                totalNumber += number;
            }

            Console.WriteLine("Sayıların ortalaması : " + totalNumber/arrayLength);

        }

        public static void ArrayMethodsFunc()
        {
            Console.WriteLine("**** Sırasız Dize ****");
            int[] numbers = {5,2,7,3,33,20,86};

            foreach (var number in numbers)
                Console.WriteLine(number);
            

            Console.WriteLine("**** Sıralı Dize ****");
            Array.Sort(numbers);

            foreach (var number in numbers)
                Console.WriteLine(number);
            

            Console.WriteLine("**** Array.Clear() ****");

            Array.Clear(numbers,3,2);
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("**** Array.Reverse() ****");

            Array.Reverse(numbers);
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("**** Array.IndexOf() ****");
            Console.WriteLine(Array.IndexOf(numbers,3));

            Console.WriteLine("**** Array.Resize() ****");
            Array.Resize<int>(ref numbers,8);
            numbers[7] = 101;
            foreach (var number in numbers)
                Console.WriteLine(number);







        }

        public static int AdditionFunc(int a, int b)
        {
            return a+b;
        }

        public static void CollectionsGenericFunc()
        {
            Console.WriteLine("**** Int Listesi ****");
            List<int> numberList = new List<int>();
            numberList.Add(4);
            numberList.Add(2);
            numberList.Add(7);
            numberList.Add(6);
            numberList.Add(10);
            numberList.Add(19);
            numberList.Add(12);

            Console.WriteLine("**** String Listesi ****");
            List<string> stringList = new List<string>();
            stringList.Add("Mavi");
            stringList.Add("Kırmızı");
            stringList.Add("Yeşil");
            stringList.Add("Mor");
            stringList.Add("Sarı");


            //Count
            Console.WriteLine("**** Count ****");
            Console.WriteLine($"Int listesinin eleman sayısı : {numberList.Count}");
            Console.WriteLine($"String listesinin eleman sayısı : {stringList.Count}");

            //ForEach ve List.ForEach
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

            stringList.ForEach(item => Console.WriteLine(item));

            //Listeden eleman çıkarma
            Console.WriteLine("**** Remove ****");
            numberList.Remove(10);
            numberList.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("**** RemoveAt ****");
            stringList.RemoveAt(2);
            stringList.ForEach(item => Console.WriteLine(item));

            //Liste içerisinde Arama
            Console.WriteLine("**** Contains ****");
            if(stringList.Contains("Mor"))
                Console.WriteLine("Listerde mor renk var");

            //Eleman ile indexe erişme
            Console.WriteLine("**** BinarySearch ****");
            Console.WriteLine(stringList.BinarySearch("Sarı"));

            //Diziyi liste çevirme
            Console.WriteLine("**** Array'den Listeye ****");
            string[] stringArray = {"Aslan", "Kedi", "Köpek", "At"};
            List<string> animalList = new List<string>(stringArray);
            animalList.ForEach(item => Console.WriteLine($"Hayvan listesi : {item}"));

            //Clear
            animalList.Clear();
            
            //List içerisinde nesne tutma
            Console.WriteLine("**** List<Class> ****");
            List<Users> userList = new List<Users>();
            Users user1 = new Users(); 
            user1.Name = "Ahmet";
            user1.SurName = "Veli";
            user1.Age = 23;

            Users user2 = new Users(); 
            user2.Name = "Mehmet";
            user2.SurName = "Çalışkan";
            user2.Age = 25;

            userList.Add(user1);
            userList.Add(user2);

            foreach (Users user in userList)
            {
                Console.WriteLine($"Kullanıcının adı : {user.Name}");
                Console.WriteLine($"Kullanıcının soyadı : {user.SurName}");
                Console.WriteLine($"Kullanıcının yaşı : {user.Age}");
            }

            List<Users> newUserList = new List<Users>();
            newUserList.Add(new Users(){
                Name = "Mert",
                SurName = "Kaya",
                Age = 26
                
            });
            
        }

        public static void CollectionsArrayListFunc()
        {
            Console.WriteLine("**** ArrayList ****");
            ArrayList aList= new ArrayList();

            aList.Add("Hakan");
            aList.Add(2);
            aList.Add(true);
            aList.Add('c');

            foreach (var item in aList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** AddRange ****");
            //AddRange
            string[] colorList = {"sarı", "siyah", "mor", "eflatun"};
            List<int> numberList= new List<int>(){1,2,7,10,3,6,92,5};
            aList.AddRange(colorList);
            aList.AddRange(numberList);

            foreach (var item in aList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("**** Sort ****");
            //Sort
            ArrayList bList = new ArrayList();
            bList.AddRange(numberList);
            bList.Sort();

            foreach (var item in bList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Binary Search ****");
            //BinarySearch
            Console.WriteLine(bList.BinarySearch(2));

            Console.WriteLine("**** Reverse ****");
            //Reverse
            bList.Reverse();

            foreach (var item in bList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Clear ****");
            //Clear
            bList.Clear();

            foreach (var item in bList)
            {
                Console.WriteLine(item);
            }




        }


    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveSpaces(this string param)
        {
            string[] array = param.Split(" ");
            
            return string.Join("",array);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void PrintToScreenIntArray(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
            
        }

        public static bool IsEven(this int param)
        {
            return param%2 == 0;
        }

    }

    class Methods
    {
        public void PrintToScreenFunc(string data)
        {
            Console.WriteLine(data);
        }

        public int PlusAndAdditionFunc(ref int e, ref int d)
        {
            e+=1;
            d+=1;
            return e+d;
        }

        public void OutPlusAndAdditionFunc(int a, int b, out int result)
        {
            result = a+b;
        }

        public void OverloadPrintToScreenFunc(string data)
        {
            Console.WriteLine(data);
        }

        public void OverloadPrintToScreenFunc(int data)
        {
            Console.WriteLine(data);
        }

        public void OverloadPrintToScreenFunc(string data, string data2)
        {
            Console.WriteLine(data+data2);
        }

        public int RecursiveFunc(int number, int exponents)
        {
            if(exponents<2)
            return number;
            return RecursiveFunc(number,exponents-1) * number;
            //RecursiveFunc(3,4)
            //RecursiveFunc(3,3)= 3
            //RecursiveFunc(3,2)= 3*3 
            //RecursiveFunc(3,1)= 3*3*3 
            //3*3*3*3 = 3^4
        }

        public int Factorial(int n)
        {
            if(n==1)
            return 1;
            return Factorial(n-1)*n;

            //n==4
            //(4-1)*4 = 3*4 = 12
            //(3-1)*4 = 2*4 = 8
            //(2-1)*4 = 1*4 = 4
            //12+8+4 = 24
        }

        public void StringMethod()
        {
            string sentence1 = "Dersimiz CSharp. Hoşgeldiniz";
            string sentence2 = "CSharp";

            Console.WriteLine($"Birinci cümlenin karakter uzunluğu : {sentence1.Length}");
            
            Console.WriteLine("**** ToLower, ToUpper ****");
            //ToLower, ToUpper
            Console.WriteLine(sentence1.ToLower());
            Console.WriteLine(sentence1.ToUpper());

            Console.WriteLine("**** Concat ****");
            //Concat
            Console.WriteLine(string.Concat(sentence2," dersleri"));

            Console.WriteLine("**** Compare, CompareTo ****");
            //Compare, CompareTo
            Console.WriteLine(sentence1.CompareTo(sentence2));
            Console.WriteLine(string.Compare(sentence1,sentence2,true));
            Console.WriteLine(string.Compare(sentence1,sentence2,false));

            Console.WriteLine("**** Contains ****");
            //Contains
            Console.WriteLine(sentence1.Contains("Dersimiz"));
            Console.WriteLine(sentence1.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(sentence2.StartsWith("CS"));

            Console.WriteLine("**** IndexOf ****");
            //IndexOf
            Console.WriteLine(sentence1.IndexOf("CS"));
            Console.WriteLine(sentence1.IndexOf("Patika"));
            Console.WriteLine(sentence1.LastIndexOf("z"));

            Console.WriteLine("**** Insert ****");
            //Insert
            Console.WriteLine(sentence1.Insert(0,"Merhaba. "));

            Console.WriteLine("**** PadLeft, PadRight ****");
            //PadLeft, PadRight
            Console.WriteLine(sentence1 + sentence2.PadLeft(30));
            Console.WriteLine(sentence1 + sentence2.PadRight(30,'-'));
            Console.WriteLine(sentence1.PadLeft(50) + sentence2);
            Console.WriteLine(sentence1.PadRight(50,'*') + sentence2);

            Console.WriteLine("**** Remove ****");
            //Remove
            Console.WriteLine(sentence1.Remove(5));
            Console.WriteLine(sentence1.Remove(5,5));
            Console.WriteLine(sentence1.Remove(0,1));

            Console.WriteLine("**** Replace ****");
            //Replace
            Console.WriteLine(sentence1.Replace("CSharp","C#"));
            Console.WriteLine(sentence1.Replace(" ","*"));

            Console.WriteLine("**** Split ****");
            //Split
            Console.WriteLine(sentence1.Split(' ')[2]);

            Console.WriteLine("**** SubString ****");
            //SubString
            Console.WriteLine(sentence1.Substring(4));
            Console.WriteLine(sentence1.Substring(0,5));

        }

        public void DateTimeMethods()
        {
            Console.WriteLine("**** DateTime ****");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(8));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(7));
            Console.WriteLine(DateTime.Now.AddSeconds(2));
            Console.WriteLine(DateTime.Now.AddMilliseconds(40));


            Console.WriteLine("**** DateTime Format ****");
            Console.WriteLine(DateTime.Now.ToString("dd"));   //15
            Console.WriteLine(DateTime.Now.ToString("ddd"));  //Sat 
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));   //04
            Console.WriteLine(DateTime.Now.ToString("MMM"));  //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy"));   //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021


            Console.WriteLine("**** Math ****");
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(2.3));
            Console.WriteLine(Math.Round(2.7));
            Console.WriteLine(Math.Round(2.3));
            Console.WriteLine(Math.Floor(2.7));

            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));

            Console.WriteLine(Math.Pow(3,4));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(3));
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(10));



        }


    }

    public class Users
    {
        private string name;
        private string surName;

        private int age;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public int Age { get => age; set => age = value; }
    }

}
