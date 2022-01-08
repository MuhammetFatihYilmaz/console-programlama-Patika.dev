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
    }
}
